namespace Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonStopWMP = new System.Windows.Forms.Button();
            this.buttonStartWMP = new System.Windows.Forms.Button();
            this.buttonPauseWMP = new System.Windows.Forms.Button();
            this.buttonStartSoundPlay = new System.Windows.Forms.Button();
            this.buttonStopPlaySound = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStopMCI = new System.Windows.Forms.Button();
            this.buttonPauseMCI = new System.Windows.Forms.Button();
            this.buttonStartDirectSound = new System.Windows.Forms.Button();
            this.buttonStopDirectSound = new System.Windows.Forms.Button();
            this.buttonPauseDerectSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRecordMCI = new System.Windows.Forms.Button();
            this.buttonStopRecordMCI = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(11, 91);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(464, 94);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(558, 11);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 27);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox.Location = new System.Drawing.Point(13, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(462, 23);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadFile.Location = new System.Drawing.Point(482, 11);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(75, 27);
            this.buttonLoadFile.TabIndex = 3;
            this.buttonLoadFile.Text = "Load";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStopWMP
            // 
            this.buttonStopWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopWMP.Location = new System.Drawing.Point(89, 230);
            this.buttonStopWMP.Name = "buttonStopWMP";
            this.buttonStopWMP.Size = new System.Drawing.Size(75, 27);
            this.buttonStopWMP.TabIndex = 5;
            this.buttonStopWMP.Text = "Stop";
            this.buttonStopWMP.UseVisualStyleBackColor = true;
            this.buttonStopWMP.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonStartWMP
            // 
            this.buttonStartWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartWMP.Location = new System.Drawing.Point(13, 230);
            this.buttonStartWMP.Name = "buttonStartWMP";
            this.buttonStartWMP.Size = new System.Drawing.Size(75, 27);
            this.buttonStartWMP.TabIndex = 6;
            this.buttonStartWMP.Text = "Start";
            this.buttonStartWMP.UseVisualStyleBackColor = true;
            this.buttonStartWMP.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPauseWMP
            // 
            this.buttonPauseWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseWMP.Location = new System.Drawing.Point(165, 230);
            this.buttonPauseWMP.Name = "buttonPauseWMP";
            this.buttonPauseWMP.Size = new System.Drawing.Size(75, 27);
            this.buttonPauseWMP.TabIndex = 7;
            this.buttonPauseWMP.Text = "Pause";
            this.buttonPauseWMP.UseVisualStyleBackColor = true;
            this.buttonPauseWMP.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // buttonStartSoundPlay
            // 
            this.buttonStartSoundPlay.Location = new System.Drawing.Point(13, 41);
            this.buttonStartSoundPlay.Name = "buttonStartSoundPlay";
            this.buttonStartSoundPlay.Size = new System.Drawing.Size(75, 27);
            this.buttonStartSoundPlay.TabIndex = 8;
            this.buttonStartSoundPlay.Text = "Start";
            this.buttonStartSoundPlay.UseVisualStyleBackColor = true;
            this.buttonStartSoundPlay.Click += new System.EventHandler(this.buttonStartSoundPlay_Click);
            // 
            // buttonStopPlaySound
            // 
            this.buttonStopPlaySound.Location = new System.Drawing.Point(95, 41);
            this.buttonStopPlaySound.Name = "buttonStopPlaySound";
            this.buttonStopPlaySound.Size = new System.Drawing.Size(75, 27);
            this.buttonStopPlaySound.TabIndex = 9;
            this.buttonStopPlaySound.Text = "Stop";
            this.buttonStopPlaySound.UseVisualStyleBackColor = true;
            this.buttonStopPlaySound.Click += new System.EventHandler(this.buttonStopPlaySound_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 330);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 27);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStopMCI
            // 
            this.buttonStopMCI.Location = new System.Drawing.Point(89, 330);
            this.buttonStopMCI.Name = "buttonStopMCI";
            this.buttonStopMCI.Size = new System.Drawing.Size(75, 27);
            this.buttonStopMCI.TabIndex = 11;
            this.buttonStopMCI.Text = "Stop";
            this.buttonStopMCI.UseVisualStyleBackColor = true;
            this.buttonStopMCI.Click += new System.EventHandler(this.buttonStopMCI_Click);
            // 
            // buttonPauseMCI
            // 
            this.buttonPauseMCI.Location = new System.Drawing.Point(165, 330);
            this.buttonPauseMCI.Name = "buttonPauseMCI";
            this.buttonPauseMCI.Size = new System.Drawing.Size(75, 27);
            this.buttonPauseMCI.TabIndex = 12;
            this.buttonPauseMCI.Text = "Pause";
            this.buttonPauseMCI.UseVisualStyleBackColor = true;
            this.buttonPauseMCI.Click += new System.EventHandler(this.buttonPauseMCI_Click);
            // 
            // buttonStartDirectSound
            // 
            this.buttonStartDirectSound.Location = new System.Drawing.Point(13, 380);
            this.buttonStartDirectSound.Name = "buttonStartDirectSound";
            this.buttonStartDirectSound.Size = new System.Drawing.Size(75, 27);
            this.buttonStartDirectSound.TabIndex = 13;
            this.buttonStartDirectSound.Text = "Start";
            this.buttonStartDirectSound.UseVisualStyleBackColor = true;
            this.buttonStartDirectSound.Click += new System.EventHandler(this.buttonStartDirectSound_Click);
            // 
            // buttonStopDirectSound
            // 
            this.buttonStopDirectSound.Location = new System.Drawing.Point(89, 380);
            this.buttonStopDirectSound.Name = "buttonStopDirectSound";
            this.buttonStopDirectSound.Size = new System.Drawing.Size(75, 27);
            this.buttonStopDirectSound.TabIndex = 14;
            this.buttonStopDirectSound.Text = "Stop";
            this.buttonStopDirectSound.UseVisualStyleBackColor = true;
            this.buttonStopDirectSound.Click += new System.EventHandler(this.buttonStopDirectSound_Click);
            // 
            // buttonPauseDerectSound
            // 
            this.buttonPauseDerectSound.Location = new System.Drawing.Point(165, 380);
            this.buttonPauseDerectSound.Name = "buttonPauseDerectSound";
            this.buttonPauseDerectSound.Size = new System.Drawing.Size(75, 27);
            this.buttonPauseDerectSound.TabIndex = 15;
            this.buttonPauseDerectSound.Text = "Pause";
            this.buttonPauseDerectSound.UseVisualStyleBackColor = true;
            this.buttonPauseDerectSound.Click += new System.EventHandler(this.buttonPauseDerectSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "PlaySound";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "WMP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "MCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "DirectSound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "WaveOut";
            // 
            // buttonRecordMCI
            // 
            this.buttonRecordMCI.Location = new System.Drawing.Point(275, 330);
            this.buttonRecordMCI.Name = "buttonRecordMCI";
            this.buttonRecordMCI.Size = new System.Drawing.Size(75, 27);
            this.buttonRecordMCI.TabIndex = 16;
            this.buttonRecordMCI.Text = "Record";
            this.buttonRecordMCI.UseVisualStyleBackColor = true;
            this.buttonRecordMCI.Click += new System.EventHandler(this.buttonRecordMCI_Click);
            // 
            // buttonStopRecordMCI
            // 
            this.buttonStopRecordMCI.Location = new System.Drawing.Point(351, 330);
            this.buttonStopRecordMCI.Name = "buttonStopRecordMCI";
            this.buttonStopRecordMCI.Size = new System.Drawing.Size(75, 27);
            this.buttonStopRecordMCI.TabIndex = 28;
            this.buttonStopRecordMCI.Text = "Stop";
            this.buttonStopRecordMCI.UseVisualStyleBackColor = true;
            this.buttonStopRecordMCI.Click += new System.EventHandler(this.buttonStopRecordMCI_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(176, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Proszę nie włączać, bo wątek nie wyłączsię";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStopRecordMCI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecordMCI);
            this.Controls.Add(this.buttonPauseDerectSound);
            this.Controls.Add(this.buttonStopDirectSound);
            this.Controls.Add(this.buttonStartDirectSound);
            this.Controls.Add(this.buttonPauseMCI);
            this.Controls.Add(this.buttonStopMCI);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStopPlaySound);
            this.Controls.Add(this.buttonStartSoundPlay);
            this.Controls.Add(this.buttonPauseWMP);
            this.Controls.Add(this.buttonStartWMP);
            this.Controls.Add(this.buttonStopWMP);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonStopWMP;
        private System.Windows.Forms.Button buttonStartWMP;
        private System.Windows.Forms.Button buttonPauseWMP;
        private System.Windows.Forms.Button buttonStartSoundPlay;
        private System.Windows.Forms.Button buttonStopPlaySound;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStopMCI;
        private System.Windows.Forms.Button buttonPauseMCI;
        private System.Windows.Forms.Button buttonStartDirectSound;
        private System.Windows.Forms.Button buttonStopDirectSound;
        private System.Windows.Forms.Button buttonPauseDerectSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRecordMCI;
        private System.Windows.Forms.Button buttonStopRecordMCI;
        private System.Windows.Forms.Label label6;
    }
}

