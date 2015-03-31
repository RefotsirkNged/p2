using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2(string tourNameLabel, object tourTypeLabel, object gameType)
        {
            InitializeComponent();
            tournamentNameHere.Text = tourNameLabel;
            tournamentTypeHere.Text = Convert.ToString(tourTypeLabel);
            gameHere.Text = Convert.ToString(gameType);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int howManyTeams = 1;
        private void applyTeamData_Click(object sender, EventArgs e)
        {
            
            string numberOfTeam = Convert.ToString(howManyTeams);
            string teamName = textBox_teamName.Text;
            string teamSeeding = textBox_teamSeeding.Text;
            string[] Row = { numberOfTeam, teamName, teamSeeding };
            Convert.ToInt32(howManyTeams);
            howManyTeams++;
            teamGridView.Rows.Add(Row);
            textBox_teamName.Clear();
            textBox_teamSeeding.Clear();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
