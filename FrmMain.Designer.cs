﻿namespace WFA230320
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            pnl = new Panel();
            SuspendLayout();
            // 
            // tmrUpdate
            // 
            tmrUpdate.Interval = 500;
            // 
            // pnl
            // 
            pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl.BackColor = Color.White;
            pnl.Location = new Point(12, 12);
            pnl.Name = "pnl";
            pnl.Size = new Size(760, 537);
            pnl.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnl);
            Name = "FrmMain";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmrUpdate;
        private Panel pnl;
    }
}