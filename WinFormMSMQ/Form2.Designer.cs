﻿namespace WinFormMSMQ
{
    partial class Form2
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBDUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 86);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(320, 21);
            this.txtURL.TabIndex = 9;
            this.txtURL.Text = "FormatName:Direct=TCP:192.168.102.188\\private$\\YCqueue";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 113);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(401, 95);
            this.txtResponse.TabIndex = 8;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(12, 12);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(401, 66);
            this.txtRequest.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "远程接收";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "远程发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "本地接收";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBDUrl
            // 
            this.txtBDUrl.Location = new System.Drawing.Point(12, 243);
            this.txtBDUrl.Name = "txtBDUrl";
            this.txtBDUrl.Size = new System.Drawing.Size(320, 21);
            this.txtBDUrl.TabIndex = 11;
            this.txtBDUrl.Text = ".\\private$\\YCqueue";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 292);
            this.Controls.Add(this.txtBDUrl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBDUrl;
    }
}