using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Utils;
using PCSC.Exceptions;

namespace ChipReader
{
    public partial class Form1 : Form
    {
        private static SCardError error;
        private static SCardReader sCardReader;
        private static IntPtr ptr;
        private static SCardContext context;
        private static string hexData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // nawiązanie połączenia z czytnikiem
                context = new SCardContext();

                context.Establish(SCardScope.System);
                // otrzymanie listy czytników
                var readers = context.GetReaders();
                // połączenie z pierwszym czytnikiem
                sCardReader = new SCardReader(context);
                error = sCardReader.Connect(readers.FirstOrDefault(), SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);

                if (error != SCardError.Success)
                {
                    MessageBox.Show(SCardHelper.StringifyError(error));
                }

                switch (sCardReader.ActiveProtocol)
                {
                    case SCardProtocol.T0:
                        ptr = SCardPCI.T0;
                        break;
                    case SCardProtocol.T1:
                        ptr = SCardPCI.T1;
                        break;
                    default:
                        throw new PCSCException(SCardError.CardUnsupported, "Not supported protocol");
                }
            }
            catch(PCSCException exeption)
            {
                textBoxASCII.AppendText(exeption.Message + Environment.NewLine);
                textBoxHEX.AppendText(exeption.Message + Environment.NewLine);
            }
        }

        private void buttonGetTelecom_Click(object sender, EventArgs e)
        {
            textBoxASCII.AppendText(" Get TELECOM " + Environment.NewLine);
            textBoxHEX.AppendText(" Get TELECOM " + Environment.NewLine);
            try
            {
                byte[] command;
                // ustalenie katalogu fo odczytu (7F10)
                command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };
                textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);

                // ustalenie pliku fo odczytu (6F3A)
                command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3A };
                textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);
                // odczyt informacji z karty
                command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F }; //get response
                textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);
                }
               
            catch (PCSCException exeption)
            {
                textBoxASCII.AppendText(exeption.Message + Environment.NewLine);
                textBoxHEX.AppendText(exeption.Message + Environment.NewLine);
            }
        }


        private string commandToCard(byte[] cmd)
        {
            hexData = "";
            var receivedData = new byte[256];
            // transmitowanie danych do karty czypowej
            error = sCardReader.Transmit(ptr, cmd, ref receivedData);

            if (error != SCardError.Success)
            {
                MessageBox.Show(SCardHelper.StringifyError(error));
            }
            // wyświetlanie danych naprawionych do karty w programie
            return writeResponse(receivedData);
        }

        private string writeResponse(byte[] data)
        {
            var builder = new StringBuilder();

            foreach (byte v in data)
            {
                // ustawienie postaci danych do wyświetlania 
                builder.Append(string.Format("{0:X2} ", v));
            }

            var result = builder.ToString();
           
            return $"{result}";
        }

        private void buttonGetSMS_Click(object sender, EventArgs e)
        {
            textBoxASCII.AppendText(" Get SMS " + Environment.NewLine);
            textBoxHEX.AppendText(" Get SMS " + Environment.NewLine);
            try
            {
                byte[] command;
                // ustalenie katalogu fo odczytu (7F10)
                command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };
                textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);
                // ustalenie pliku fo odczytu (6F3C)
                command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3C };
                textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);


                for (byte i = 1; i < 10; i++)
                {
                    // odczyt sms o numerze "i"
                    command = new byte[] { 0xA0, 0xB2, i, 0x04, 0xB0 }; //read record
                    textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);
                    var receivedData = new byte[256];
                    sCardReader.Transmit(ptr, command, ref receivedData);
                    textBoxASCII.AppendText(ConvertToAscii(receivedData) + Environment.NewLine + Environment.NewLine);

                }
                    command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F }; //get response
                    textBoxHEX.AppendText(commandToCard(command) + Environment.NewLine);
                
               

            }
            catch (PCSCException exeption)
            {
                textBoxASCII.AppendText(exeption.Message + Environment.NewLine);
                textBoxHEX.AppendText(exeption.Message + Environment.NewLine);
            }
        }

        
        private string ConvertToAscii(byte[] data)
        {
            data = data.Skip(24).Where(x => x != 0xFF).ToArray();

            var msgBytes = UnpackGsm(data);

            var builder = new StringBuilder();

            foreach (var bt in msgBytes)
            {
                builder.Append(bt);
            }

            // konwersja do czytelnych liter

            return Encoding.UTF8.GetString(msgBytes).ToString();
        }

        private byte[] UnpackGsm(byte[] data)
        {
            byte[] shifted = new byte[(data.Length * 8) / 7];
            // maska do dekodowania danych
            byte[] decodeMask = new byte[] { 128, 192, 224, 240, 248, 252, 254 };

            int shiftIndex = 0;
            int shiftOffset = 0;

            foreach (byte bt in data)
            {
                if (shiftOffset == 7)
                {
                    shifted[shiftIndex] = 0;
                    shiftOffset = 0;
                    shiftIndex++;
                }

                shifted[shiftIndex] = (byte)((bt << shiftOffset) & 127);

                shiftOffset++;
                shiftIndex++;
            }

            int moveOffset = 0;
            int moveIndex = 0;
            int unpackIndex = 1;
            byte[] unpackedBytes = new byte[shifted.Length];

            if (shifted.Length > 0)
            {
                unpackedBytes[unpackIndex - 1] = shifted[unpackIndex - 1];
            }

            foreach (byte b in data)
            {
                if (unpackIndex != shifted.Length)
                {
                    if (moveOffset == 7)
                    {
                        moveOffset = 0;
                        unpackIndex++;
                        unpackedBytes[unpackIndex - 1] = shifted[unpackIndex - 1];
                    }

                    if (unpackIndex != shifted.Length)
                    {
                        int extractedBitsByte = (data[moveIndex] & decodeMask[moveOffset]);

                        extractedBitsByte = (extractedBitsByte >> (7 - moveOffset));

                        int movedBitsByte = (extractedBitsByte | shifted[unpackIndex]);

                        unpackedBytes[unpackIndex] = (byte)movedBitsByte;

                        moveOffset++;
                        unpackIndex++;
                        moveIndex++;
                    }
                }
            }

            if (unpackedBytes[unpackedBytes.Length - 1] == 0)
            {
                byte[] finalResultBytes = new byte[unpackedBytes.Length - 1];
                Array.Copy(unpackedBytes, 0, finalResultBytes, 0, finalResultBytes.Length);

                return finalResultBytes;
            }

            return unpackedBytes;
        }
    }
}