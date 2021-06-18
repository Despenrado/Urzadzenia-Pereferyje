namespace Modem
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
            this.buttonCall = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.buttonDecline = new System.Windows.Forms.Button();
            this.buttonAllow = new System.Windows.Forms.Button();
            this.textBoxMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(176, 33);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(75, 27);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(12, 33);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(153, 22);
            this.textBoxPhoneNumber.TabIndex = 1;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(278, 384);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(448, 27);
            this.buttonSendMessage.TabIndex = 2;
            this.buttonSendMessage.Text = "Send Message";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(278, 356);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(448, 22);
            this.textBoxSendMessage.TabIndex = 3;
            // 
            // buttonDecline
            // 
            this.buttonDecline.Location = new System.Drawing.Point(12, 384);
            this.buttonDecline.Name = "buttonDecline";
            this.buttonDecline.Size = new System.Drawing.Size(113, 27);
            this.buttonDecline.TabIndex = 4;
            this.buttonDecline.Text = "Decline";
            this.buttonDecline.UseVisualStyleBackColor = true;
            this.buttonDecline.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAllow
            // 
            this.buttonAllow.Location = new System.Drawing.Point(138, 384);
            this.buttonAllow.Name = "buttonAllow";
            this.buttonAllow.Size = new System.Drawing.Size(113, 27);
            this.buttonAllow.TabIndex = 5;
            this.buttonAllow.Text = "Allow";
            this.buttonAllow.UseVisualStyleBackColor = true;
            this.buttonAllow.Click += new System.EventHandler(this.buttonAllow_Click);
            // 
            // textBoxMessageBox
            // 
            this.textBoxMessageBox.Location = new System.Drawing.Point(278, 33);
            this.textBoxMessageBox.Multiline = true;
            this.textBoxMessageBox.Name = "textBoxMessageBox";
            this.textBoxMessageBox.ReadOnly = true;
            this.textBoxMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessageBox.Size = new System.Drawing.Size(448, 317);
            this.textBoxMessageBox.TabIndex = 6;
            this.textBoxMessageBox.TextChanged += new System.EventHandler(this.textBoxMessageBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.textBoxMessageBox);
            this.Controls.Add(this.buttonAllow);
            this.Controls.Add(this.buttonDecline);
            this.Controls.Add(this.textBoxSendMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.buttonCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxSendMessage;
        private System.Windows.Forms.Button buttonDecline;
        private System.Windows.Forms.Button buttonAllow;
        private System.Windows.Forms.TextBox textBoxMessageBox;
    }
}

