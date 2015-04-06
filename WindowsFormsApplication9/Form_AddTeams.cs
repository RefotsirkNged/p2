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
    public partial class Form_AddTeams : Form
    {
        public Form_AddTeams(string tourNameLabel, object tourTypeLabel, object gameType)
        {
            InitializeComponent();
            tournamentNameHere.Text = tourNameLabel;
            tournamentTypeHere.Text = Convert.ToString(tourTypeLabel);
            gameHere.Text = Convert.ToString(gameType);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //is this variable ok here, it seems so alone?
        int howManyTeams = 1;
        private void applyTeamData_Click(object sender, EventArgs e)
        {
            //This should be stored in List instead, not as it is now. Its prolly better that way.
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



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void generate_tournament_Click(object sender, EventArgs e)
        {
            Form_RunTournament f3 = new Form_RunTournament(this.tournamentNameHere.Text);
            f3.Show();
            this.Hide(); 
        }


        private void back_Click_2(object sender, EventArgs e)
        {
            Form_TournamentNameType f1 = new Form_TournamentNameType();
            f1.Show();
            this.Hide();
        }
    }
}
