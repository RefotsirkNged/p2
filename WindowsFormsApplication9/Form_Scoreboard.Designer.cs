﻿namespace WindowsFormsApplication9
{
    partial class Form_Scoreboard
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
            this.tour_ScoreBoard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.closeScoreBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tour_ScoreBoard
            // 
            this.tour_ScoreBoard.Location = new System.Drawing.Point(16, 30);
            this.tour_ScoreBoard.Name = "tour_ScoreBoard";
            this.tour_ScoreBoard.Size = new System.Drawing.Size(664, 388);
            this.tour_ScoreBoard.TabIndex = 1;
            this.tour_ScoreBoard.TabStop = false;
            this.tour_ScoreBoard.Text = "tour_ScoreBoard";
            this.tour_ScoreBoard.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeScoreBoard
            // 
            this.closeScoreBoard.Location = new System.Drawing.Point(605, 424);
            this.closeScoreBoard.Name = "closeScoreBoard";
            this.closeScoreBoard.Size = new System.Drawing.Size(75, 23);
            this.closeScoreBoard.TabIndex = 4;
            this.closeScoreBoard.Text = "Close";
            this.closeScoreBoard.UseVisualStyleBackColor = true;
            this.closeScoreBoard.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 454);
            this.Controls.Add(this.closeScoreBoard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tour_ScoreBoard);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Tournament Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tour_ScoreBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button closeScoreBoard;

    }
}