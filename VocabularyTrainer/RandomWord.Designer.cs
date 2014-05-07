﻿namespace RussianVocabularyHelper
{
    partial class RandomWord
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
            this.lblRussian = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRussian
            // 
            this.lblRussian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRussian.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRussian.Location = new System.Drawing.Point(0, 0);
            this.lblRussian.Name = "lblRussian";
            this.lblRussian.Size = new System.Drawing.Size(284, 32);
            this.lblRussian.TabIndex = 0;
            this.lblRussian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(0, 32);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(284, 32);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "(Answer)";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.MouseLeave += new System.EventHandler(this.lblAnswer_MouseLeave);
            this.lblAnswer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer_MouseMove);
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Location = new System.Drawing.Point(41, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(243, 39);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next >>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 39);
            this.panel1.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(41, 39);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RandomWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblRussian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomWord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Word";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.RandomWord_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRussian;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
    }
}