namespace WindowsFormsApplication9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applyTeamData = new System.Windows.Forms.Button();
            this.teamGridView = new System.Windows.Forms.DataGridView();
            this.textBox_teamName = new System.Windows.Forms.TextBox();
            this.textBox_teamSeeding = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.generate_tournament = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.teamSeeding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.numberOfTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tournamentNameHere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter team name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team Seeding:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // applyTeamData
            // 
            this.applyTeamData.Location = new System.Drawing.Point(552, 91);
            this.applyTeamData.Name = "applyTeamData";
            this.applyTeamData.Size = new System.Drawing.Size(75, 20);
            this.applyTeamData.TabIndex = 1;
            this.applyTeamData.Text = "Apply";
            this.applyTeamData.UseVisualStyleBackColor = true;
            this.applyTeamData.Click += new System.EventHandler(this.applyTeamData_Click);
            // 
            // teamGridView
            // 
            this.teamGridView.AllowUserToAddRows = false;
            this.teamGridView.AllowUserToOrderColumns = true;
            this.teamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfTeam,
            this.teamName,
            this.teamSeeding});
            this.teamGridView.Location = new System.Drawing.Point(12, 120);
            this.teamGridView.Name = "teamGridView";
            this.teamGridView.Size = new System.Drawing.Size(604, 267);
            this.teamGridView.TabIndex = 3;
            this.teamGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_teamName
            // 
            this.textBox_teamName.Location = new System.Drawing.Point(132, 91);
            this.textBox_teamName.Name = "textBox_teamName";
            this.textBox_teamName.Size = new System.Drawing.Size(174, 20);
            this.textBox_teamName.TabIndex = 4;
            // 
            // textBox_teamSeeding
            // 
            this.textBox_teamSeeding.Location = new System.Drawing.Point(400, 91);
            this.textBox_teamSeeding.Name = "textBox_teamSeeding";
            this.textBox_teamSeeding.Size = new System.Drawing.Size(122, 20);
            this.textBox_teamSeeding.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(596, 120);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 267);
            this.vScrollBar1.TabIndex = 6;
            // 
            // generate_tournament
            // 
            this.generate_tournament.Location = new System.Drawing.Point(552, 417);
            this.generate_tournament.Name = "generate_tournament";
            this.generate_tournament.Size = new System.Drawing.Size(75, 23);
            this.generate_tournament.TabIndex = 7;
            this.generate_tournament.Text = "Generate";
            this.generate_tournament.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(458, 417);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = " Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // teamSeeding
            // 
            this.teamSeeding.HeaderText = "Team Seeding";
            this.teamSeeding.Name = "teamSeeding";
            this.teamSeeding.Width = 120;
            // 
            // teamName
            // 
            this.teamName.HeaderText = "Team name";
            this.teamName.Name = "teamName";
            this.teamName.Width = 375;
            // 
            // numberOfTeam
            // 
            this.numberOfTeam.HeaderText = "#";
            this.numberOfTeam.Name = "numberOfTeam";
            this.numberOfTeam.Width = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tournament: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tournamentNameHere
            // 
            this.tournamentNameHere.AutoSize = true;
            this.tournamentNameHere.Location = new System.Drawing.Point(79, 18);
            this.tournamentNameHere.Name = "tournamentNameHere";
            this.tournamentNameHere.Size = new System.Drawing.Size(115, 13);
            this.tournamentNameHere.TabIndex = 10;
            this.tournamentNameHere.Text = "TournamentNameHere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "tournamentTypeHere";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tournamentNameHere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.generate_tournament);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox_teamSeeding);
            this.Controls.Add(this.textBox_teamName);
            this.Controls.Add(this.teamGridView);
            this.Controls.Add(this.applyTeamData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Tournament Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyTeamData;
        private System.Windows.Forms.DataGridView teamGridView;
        private System.Windows.Forms.TextBox textBox_teamName;
        private System.Windows.Forms.TextBox textBox_teamSeeding;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button generate_tournament;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfTeam;
        private System.Windows.Forms.DataGridViewLinkColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamSeeding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tournamentNameHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}