﻿namespace ScreenSaver
{
    partial class frmScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.pictureTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pictureTimer
            // 
            this.pictureTimer.Enabled = true;
            this.pictureTimer.Interval = 60000;
            this.pictureTimer.Tick += new System.EventHandler(this.pictureTimer_Tick);
            // 
            // frmScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(296, 264);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreenSaver";
            this.ShowInTaskbar = false;
            this.Text = "Screen Saver";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScreenSaver_Load);
            this.Click += new System.EventHandler(this.frmScreenSaver_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmScreenSaver_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmScreenSaver_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer pictureTimer;
    }
}

