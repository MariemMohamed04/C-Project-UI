﻿namespace final_ui
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 255);
            ClientSize = new Size(1009, 397);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameForm";
            Text = "GameForm";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}