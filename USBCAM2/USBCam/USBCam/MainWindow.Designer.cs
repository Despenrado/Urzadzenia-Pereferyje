namespace USBCam
{
    partial class MainWindow
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
            this.button_searchDev = new System.Windows.Forms.Button();
            this.cmbDevList1 = new System.Windows.Forms.ComboBox();
            this.pbCam1 = new System.Windows.Forms.PictureBox();
            this.labelCamera1 = new System.Windows.Forms.Label();
            this.buttonSsCam1 = new System.Windows.Forms.Button();
            this.buttonCamOneStop = new System.Windows.Forms.Button();
            this.buttonPictureCamOne = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRecordingCamOne = new System.Windows.Forms.Button();
            this.buttonStopRecordingCamOne = new System.Windows.Forms.Button();
            this.brightness1label = new System.Windows.Forms.Label();
            this.saturation1label = new System.Windows.Forms.Label();
            this.contrast1label = new System.Windows.Forms.Label();
            this.trackBarBright1 = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation1 = new System.Windows.Forms.TrackBar();
            this.trackBarContrast1 = new System.Windows.Forms.TrackBar();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.labelRec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_searchDev
            // 
            this.button_searchDev.Location = new System.Drawing.Point(16, 10);
            this.button_searchDev.Margin = new System.Windows.Forms.Padding(4);
            this.button_searchDev.Name = "button_searchDev";
            this.button_searchDev.Size = new System.Drawing.Size(465, 28);
            this.button_searchDev.TabIndex = 0;
            this.button_searchDev.Text = "Search devices";
            this.button_searchDev.UseVisualStyleBackColor = true;
            this.button_searchDev.Click += new System.EventHandler(this.button_searchDev_Click);
            // 
            // cmbDevList1
            // 
            this.cmbDevList1.FormattingEnabled = true;
            this.cmbDevList1.Location = new System.Drawing.Point(16, 66);
            this.cmbDevList1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDevList1.Name = "cmbDevList1";
            this.cmbDevList1.Size = new System.Drawing.Size(465, 24);
            this.cmbDevList1.TabIndex = 1;
            // 
            // pbCam1
            // 
            this.pbCam1.Location = new System.Drawing.Point(19, 250);
            this.pbCam1.Margin = new System.Windows.Forms.Padding(4);
            this.pbCam1.Name = "pbCam1";
            this.pbCam1.Size = new System.Drawing.Size(462, 336);
            this.pbCam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam1.TabIndex = 3;
            this.pbCam1.TabStop = false;
            this.pbCam1.Click += new System.EventHandler(this.pbCam1_Click);
            // 
            // labelCamera1
            // 
            this.labelCamera1.AutoSize = true;
            this.labelCamera1.Location = new System.Drawing.Point(16, 43);
            this.labelCamera1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCamera1.Name = "labelCamera1";
            this.labelCamera1.Size = new System.Drawing.Size(73, 17);
            this.labelCamera1.TabIndex = 4;
            this.labelCamera1.Text = "Camera 1:";
            // 
            // buttonSsCam1
            // 
            this.buttonSsCam1.Location = new System.Drawing.Point(15, 100);
            this.buttonSsCam1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSsCam1.Name = "buttonSsCam1";
            this.buttonSsCam1.Size = new System.Drawing.Size(87, 28);
            this.buttonSsCam1.TabIndex = 7;
            this.buttonSsCam1.Text = "Start";
            this.buttonSsCam1.UseVisualStyleBackColor = true;
            this.buttonSsCam1.Click += new System.EventHandler(this.buttonSsCam1_Click);
            // 
            // buttonCamOneStop
            // 
            this.buttonCamOneStop.Location = new System.Drawing.Point(110, 100);
            this.buttonCamOneStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCamOneStop.Name = "buttonCamOneStop";
            this.buttonCamOneStop.Size = new System.Drawing.Size(87, 28);
            this.buttonCamOneStop.TabIndex = 8;
            this.buttonCamOneStop.Text = "Stop";
            this.buttonCamOneStop.UseVisualStyleBackColor = true;
            this.buttonCamOneStop.Click += new System.EventHandler(this.buttonCamOneStop_Click);
            // 
            // buttonPictureCamOne
            // 
            this.buttonPictureCamOne.Location = new System.Drawing.Point(204, 100);
            this.buttonPictureCamOne.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPictureCamOne.Name = "buttonPictureCamOne";
            this.buttonPictureCamOne.Size = new System.Drawing.Size(87, 28);
            this.buttonPictureCamOne.TabIndex = 11;
            this.buttonPictureCamOne.Text = "Photo";
            this.buttonPictureCamOne.UseVisualStyleBackColor = true;
            this.buttonPictureCamOne.Click += new System.EventHandler(this.buttonPictureCamOne_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // buttonRecordingCamOne
            // 
            this.buttonRecordingCamOne.Location = new System.Drawing.Point(299, 100);
            this.buttonRecordingCamOne.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecordingCamOne.Name = "buttonRecordingCamOne";
            this.buttonRecordingCamOne.Size = new System.Drawing.Size(87, 28);
            this.buttonRecordingCamOne.TabIndex = 13;
            this.buttonRecordingCamOne.Text = "Record";
            this.buttonRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonRecordingCamOne.Click += new System.EventHandler(this.buttonRecordingCamOne_Click);
            // 
            // buttonStopRecordingCamOne
            // 
            this.buttonStopRecordingCamOne.Enabled = false;
            this.buttonStopRecordingCamOne.Location = new System.Drawing.Point(225, 358);
            this.buttonStopRecordingCamOne.Name = "buttonStopRecordingCamOne";
            this.buttonStopRecordingCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonStopRecordingCamOne.TabIndex = 18;
            this.buttonStopRecordingCamOne.Text = "Stop";
            this.buttonStopRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonStopRecordingCamOne.Click += new System.EventHandler(this.buttonStopRecordingCamOne_Click);
            // 
            // brightness1label
            // 
            this.brightness1label.AutoSize = true;
            this.brightness1label.Location = new System.Drawing.Point(45, 152);
            this.brightness1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightness1label.Name = "brightness1label";
            this.brightness1label.Size = new System.Drawing.Size(75, 17);
            this.brightness1label.TabIndex = 15;
            this.brightness1label.Text = "Brightness";
            this.brightness1label.Click += new System.EventHandler(this.brightness1label_Click);
            // 
            // saturation1label
            // 
            this.saturation1label.AutoSize = true;
            this.saturation1label.Location = new System.Drawing.Point(218, 152);
            this.saturation1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturation1label.Name = "saturation1label";
            this.saturation1label.Size = new System.Drawing.Size(73, 17);
            this.saturation1label.TabIndex = 16;
            this.saturation1label.Text = "Saturation";
            // 
            // contrast1label
            // 
            this.contrast1label.AutoSize = true;
            this.contrast1label.Location = new System.Drawing.Point(394, 149);
            this.contrast1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrast1label.Name = "contrast1label";
            this.contrast1label.Size = new System.Drawing.Size(61, 17);
            this.contrast1label.TabIndex = 17;
            this.contrast1label.Text = "Contrast";
            // 
            // trackBarBright1
            // 
            this.trackBarBright1.Location = new System.Drawing.Point(19, 173);
            this.trackBarBright1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarBright1.Maximum = 100;
            this.trackBarBright1.Minimum = -100;
            this.trackBarBright1.Name = "trackBarBright1";
            this.trackBarBright1.Size = new System.Drawing.Size(125, 56);
            this.trackBarBright1.TabIndex = 18;
            this.trackBarBright1.Scroll += new System.EventHandler(this.TrackBarBrightness);
            // 
            // trackBarSaturation1
            // 
            this.trackBarSaturation1.Location = new System.Drawing.Point(188, 173);
            this.trackBarSaturation1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarSaturation1.Maximum = 100;
            this.trackBarSaturation1.Minimum = -100;
            this.trackBarSaturation1.Name = "trackBarSaturation1";
            this.trackBarSaturation1.Size = new System.Drawing.Size(125, 56);
            this.trackBarSaturation1.TabIndex = 19;
            this.trackBarSaturation1.Scroll += new System.EventHandler(this.TrackBarSaturation);
            // 
            // trackBarContrast1
            // 
            this.trackBarContrast1.Location = new System.Drawing.Point(356, 170);
            this.trackBarContrast1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarContrast1.Maximum = 100;
            this.trackBarContrast1.Minimum = -100;
            this.trackBarContrast1.Name = "trackBarContrast1";
            this.trackBarContrast1.Size = new System.Drawing.Size(125, 56);
            this.trackBarContrast1.TabIndex = 20;
            this.trackBarContrast1.Scroll += new System.EventHandler(this.TrackBarContrast);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Location = new System.Drawing.Point(394, 100);
            this.buttonStopRecord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(87, 28);
            this.buttonStopRecord.TabIndex = 27;
            this.buttonStopRecord.Text = "StopR";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRec.ForeColor = System.Drawing.Color.Red;
            this.labelRec.Location = new System.Drawing.Point(393, 228);
            this.labelRec.Name = "labelRec";
            this.labelRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRec.Size = new System.Drawing.Size(85, 20);
            this.labelRec.TabIndex = 28;
            this.labelRec.Text = "Recording";
            this.labelRec.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 599);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.trackBarContrast1);
            this.Controls.Add(this.trackBarSaturation1);
            this.Controls.Add(this.trackBarBright1);
            this.Controls.Add(this.contrast1label);
            this.Controls.Add(this.saturation1label);
            this.Controls.Add(this.brightness1label);
            this.Controls.Add(this.buttonRecordingCamOne);
            this.Controls.Add(this.buttonPictureCamOne);
            this.Controls.Add(this.buttonCamOneStop);
            this.Controls.Add(this.buttonSsCam1);
            this.Controls.Add(this.labelCamera1);
            this.Controls.Add(this.pbCam1);
            this.Controls.Add(this.cmbDevList1);
            this.Controls.Add(this.button_searchDev);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "USBCam";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_searchDev;
        private System.Windows.Forms.ComboBox cmbDevList1;
        private System.Windows.Forms.PictureBox pbCam1;
        private System.Windows.Forms.Label labelCamera1;
        private System.Windows.Forms.Button buttonSsCam1;
        private System.Windows.Forms.Button buttonCamOneStop;
        private System.Windows.Forms.Button buttonPictureCamOne;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRecordingCamOne;
        private System.Windows.Forms.Button buttonStopRecordingCamOne;
        private System.Windows.Forms.Label brightness1label;
        private System.Windows.Forms.Label saturation1label;
        private System.Windows.Forms.Label contrast1label;
        private System.Windows.Forms.TrackBar trackBarBright1;
        private System.Windows.Forms.TrackBar trackBarSaturation1;
        private System.Windows.Forms.TrackBar trackBarContrast1;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.Label labelRec;
    }
}

