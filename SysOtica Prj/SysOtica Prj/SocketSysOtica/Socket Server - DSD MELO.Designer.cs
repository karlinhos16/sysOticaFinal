﻿namespace SocketSysOtica
{
    partial class Socket_Server___DSD_MELO
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
            this.rtbConversa = new System.Windows.Forms.RichTextBox();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbConversa
            // 
            this.rtbConversa.Location = new System.Drawing.Point(0, 0);
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.Size = new System.Drawing.Size(283, 174);
            this.rtbConversa.TabIndex = 0;
            this.rtbConversa.Text = "";
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(0, 180);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(283, 80);
            this.rtbMensagem.TabIndex = 1;
            this.rtbMensagem.Text = "";
            this.rtbMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyDown);
            this.rtbMensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyUp);
            // 
            // Socket_Server___DSD_MELO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.rtbConversa);
            this.Name = "Socket_Server___DSD_MELO";
            this.Text = "Socket_Server___DSD_MELO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Socket_Server___DSD_MELO_FormClosing);
            this.Load += new System.EventHandler(this.Socket_Server___DSD_MELO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConversa;
        private System.Windows.Forms.RichTextBox rtbMensagem;
    }
}