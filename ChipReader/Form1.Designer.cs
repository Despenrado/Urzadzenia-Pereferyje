namespace ChipReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonGetTelecom = new System.Windows.Forms.Button();
            this.buttonGetSMS = new System.Windows.Forms.Button();
            this.textBoxHEX = new System.Windows.Forms.TextBox();
            this.textBoxASCII = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(993, 27);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonGetTelecom
            // 
            this.buttonGetTelecom.Location = new System.Drawing.Point(13, 44);
            this.buttonGetTelecom.Name = "buttonGetTelecom";
            this.buttonGetTelecom.Size = new System.Drawing.Size(498, 27);
            this.buttonGetTelecom.TabIndex = 1;
            this.buttonGetTelecom.Text = "GetTelecom";
            this.buttonGetTelecom.UseVisualStyleBackColor = true;
            this.buttonGetTelecom.Click += new System.EventHandler(this.buttonGetTelecom_Click);
            // 
            // buttonGetSMS
            // 
            this.buttonGetSMS.Location = new System.Drawing.Point(516, 44);
            this.buttonGetSMS.Name = "buttonGetSMS";
            this.buttonGetSMS.Size = new System.Drawing.Size(490, 27);
            this.buttonGetSMS.TabIndex = 2;
            this.buttonGetSMS.Text = "GetSMS";
            this.buttonGetSMS.UseVisualStyleBackColor = true;
            this.buttonGetSMS.Click += new System.EventHandler(this.buttonGetSMS_Click);
            // 
            // textBoxHEX
            // 
            this.textBoxHEX.Location = new System.Drawing.Point(13, 80);
            this.textBoxHEX.Multiline = true;
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.ReadOnly = true;
            this.textBoxHEX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHEX.Size = new System.Drawing.Size(498, 358);
            this.textBoxHEX.TabIndex = 3;
            // 
            // textBoxASCII
            // 
            this.textBoxASCII.Location = new System.Drawing.Point(516, 78);
            this.textBoxASCII.Multiline = true;
            this.textBoxASCII.Name = "textBoxASCII";
            this.textBoxASCII.ReadOnly = true;
            this.textBoxASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxASCII.Size = new System.Drawing.Size(490, 358);
            this.textBoxASCII.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.textBoxASCII);
            this.Controls.Add(this.textBoxHEX);
            this.Controls.Add(this.buttonGetSMS);
            this.Controls.Add(this.buttonGetTelecom);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonGetTelecom;
        private System.Windows.Forms.Button buttonGetSMS;
        private System.Windows.Forms.TextBox textBoxHEX;
        private System.Windows.Forms.TextBox textBoxASCII;
    }
}

