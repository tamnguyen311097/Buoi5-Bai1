﻿namespace Client
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
            this.btnImagesClient = new System.Windows.Forms.Button();
            this.btnMusicsClient = new System.Windows.Forms.Button();
            this.btnFilesClient = new System.Windows.Forms.Button();
            this.btnSendClient = new System.Windows.Forms.Button();
            this.txtMessageClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1Client = new System.Windows.Forms.ListBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImagesClient
            // 
            this.btnImagesClient.Location = new System.Drawing.Point(587, 199);
            this.btnImagesClient.Name = "btnImagesClient";
            this.btnImagesClient.Size = new System.Drawing.Size(82, 35);
            this.btnImagesClient.TabIndex = 17;
            this.btnImagesClient.Text = "Images";
            this.btnImagesClient.UseVisualStyleBackColor = true;
            // 
            // btnMusicsClient
            // 
            this.btnMusicsClient.Location = new System.Drawing.Point(587, 144);
            this.btnMusicsClient.Name = "btnMusicsClient";
            this.btnMusicsClient.Size = new System.Drawing.Size(82, 35);
            this.btnMusicsClient.TabIndex = 16;
            this.btnMusicsClient.Text = "Musics";
            this.btnMusicsClient.UseVisualStyleBackColor = true;
            // 
            // btnFilesClient
            // 
            this.btnFilesClient.Location = new System.Drawing.Point(587, 89);
            this.btnFilesClient.Name = "btnFilesClient";
            this.btnFilesClient.Size = new System.Drawing.Size(82, 35);
            this.btnFilesClient.TabIndex = 15;
            this.btnFilesClient.Text = "Files";
            this.btnFilesClient.UseVisualStyleBackColor = true;
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(573, 329);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(125, 97);
            this.btnSendClient.TabIndex = 14;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // txtMessageClient
            // 
            this.txtMessageClient.Location = new System.Drawing.Point(35, 329);
            this.txtMessageClient.Multiline = true;
            this.txtMessageClient.Name = "txtMessageClient";
            this.txtMessageClient.Size = new System.Drawing.Size(512, 97);
            this.txtMessageClient.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Message";
            // 
            // listBox1Client
            // 
            this.listBox1Client.FormattingEnabled = true;
            this.listBox1Client.ItemHeight = 16;
            this.listBox1Client.Location = new System.Drawing.Point(35, 78);
            this.listBox1Client.Name = "listBox1Client";
            this.listBox1Client.Size = new System.Drawing.Size(504, 196);
            this.listBox1Client.TabIndex = 11;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(116, 28);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(211, 22);
            this.txtServerIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(391, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 26);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 441);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnImagesClient);
            this.Controls.Add(this.btnMusicsClient);
            this.Controls.Add(this.btnFilesClient);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.txtMessageClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1Client);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagesClient;
        private System.Windows.Forms.Button btnMusicsClient;
        private System.Windows.Forms.Button btnFilesClient;
        private System.Windows.Forms.Button btnSendClient;
        private System.Windows.Forms.TextBox txtMessageClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1Client;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
    }
}

