namespace WindowsFormsApplication9
{
    partial class Form_TournamentNameType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameSelect = new System.Windows.Forms.ComboBox();
            this.tournamentFormat = new System.Windows.Forms.ComboBox();
            this.est_startDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.est_tourTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter tournament name: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select game: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Select tournament format";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameSelect
            // 
            this.gameSelect.FormattingEnabled = true;
            this.gameSelect.Items.AddRange(new object[] {
            "CS:GO",
            "DOTA II",
            "FIFA",
            "StarCraft II"});
            this.gameSelect.Location = new System.Drawing.Point(20, 138);
            this.gameSelect.Name = "gameSelect";
            this.gameSelect.Size = new System.Drawing.Size(195, 21);
            this.gameSelect.TabIndex = 12;
            this.gameSelect.SelectedIndexChanged += new System.EventHandler(this.gameSelect_SelectedIndexChanged);
            // 
            // tournamentFormat
            // 
            this.tournamentFormat.FormattingEnabled = true;
            this.tournamentFormat.Items.AddRange(new object[] {
            "Single Elimination",
            "Double Elimination",
            "Round Robin"});
            this.tournamentFormat.Location = new System.Drawing.Point(20, 192);
            this.tournamentFormat.Name = "tournamentFormat";
            this.tournamentFormat.Size = new System.Drawing.Size(195, 21);
            this.tournamentFormat.TabIndex = 13;
            this.tournamentFormat.SelectedIndexChanged += new System.EventHandler(this.tournamentFormat_SelectedIndexChanged);
            // 
            // est_startDateTime
            // 
            this.est_startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.est_startDateTime.Location = new System.Drawing.Point(20, 85);
            this.est_startDateTime.Name = "est_startDateTime";
            this.est_startDateTime.Size = new System.Drawing.Size(125, 20);
            this.est_startDateTime.TabIndex = 14;
            this.est_startDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select tournament start date and estimated time: ";
            // 
            // est_tourTime
            // 
            this.est_tourTime.CustomFormat = "HH:mm";
            this.est_tourTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.est_tourTime.Location = new System.Drawing.Point(152, 84);
            this.est_tourTime.Name = "est_tourTime";
            this.est_tourTime.ShowUpDown = true;
            this.est_tourTime.Size = new System.Drawing.Size(63, 20);
            this.est_tourTime.TabIndex = 17;
            this.est_tourTime.Value = new System.DateTime(2015, 4, 8, 14, 35, 0, 0);
            this.est_tourTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // Form_TournamentNameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 266);
            this.Controls.Add(this.est_tourTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.est_startDateTime);
            this.Controls.Add(this.tournamentFormat);
            this.Controls.Add(this.gameSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_TournamentNameType";
            this.Text = "Tournament Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox gameSelect;
        private System.Windows.Forms.ComboBox tournamentFormat;
        private System.Windows.Forms.DateTimePicker est_startDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker est_tourTime;

    }
}

