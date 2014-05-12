namespace RussianVocabularyHelper
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
            this.components = new System.ComponentModel.Container();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCopy1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCopy2 = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigin
            // 
            this.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(0, 0);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(274, 49);
            this.lblOrigin.TabIndex = 0;
            this.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(0, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(274, 49);
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
            this.buttonNext.Size = new System.Drawing.Size(295, 39);
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
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 39);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOrigin);
            this.panel2.Controls.Add(this.buttonCopy1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 49);
            this.panel2.TabIndex = 4;
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy1.Location = new System.Drawing.Point(274, 0);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(62, 49);
            this.buttonCopy1.TabIndex = 2;
            this.buttonCopy1.Text = "Copy";
            this.buttonCopy1.UseVisualStyleBackColor = true;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAnswer);
            this.panel3.Controls.Add(this.buttonCopy2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 49);
            this.panel3.TabIndex = 5;
            // 
            // buttonCopy2
            // 
            this.buttonCopy2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy2.Location = new System.Drawing.Point(274, 0);
            this.buttonCopy2.Name = "buttonCopy2";
            this.buttonCopy2.Size = new System.Drawing.Size(62, 49);
            this.buttonCopy2.TabIndex = 3;
            this.buttonCopy2.Text = "Copy";
            this.buttonCopy2.UseVisualStyleBackColor = true;
            this.buttonCopy2.Click += new System.EventHandler(this.buttonCopy2_Click);
            this.buttonCopy2.MouseLeave += new System.EventHandler(this.buttonCopy2_MouseLeave);
            this.buttonCopy2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCopy2_MouseMove);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAnswer.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(0, 0);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(336, 29);
            this.tbAnswer.TabIndex = 6;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbAnswer);
            this.panel4.Controls.Add(this.labelResult);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 70);
            this.panel4.TabIndex = 7;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(0, 32);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(338, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // RandomWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 225);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomWord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Random Word";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.RandomWord_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCopy1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Timer timer;
    }
}