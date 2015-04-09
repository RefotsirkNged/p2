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
  
        public Form_AddTeams()
        {
            InitializeComponent();
            tournamentNameHere.Text = TournamentModel.Name;
            tournamentTypeHere.Text = Convert.ToString(TournamentModel.TournamentType);
            gameHere.Text = TournamentModel.Game;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
         int howManyTeams = 1;
        
        //is this variable ok here, it seems so alone?
      
        private void applyTeamData_Click(object sender, EventArgs e)
        {
            try
            {
                //This should be stored in List instead, not as it is now. Its prolly better that way.
                string numberOfTeam = Convert.ToString(howManyTeams);
                string teamName = textBox_teamName.Text;
                if (string.IsNullOrWhiteSpace(textBox_teamName.Text))
                {
                    MessageBox.Show("Please enter team name before attempting to add them to tournament");
                    return;
                }
               
                string[] Row = { numberOfTeam, teamName };
                Convert.ToInt32(howManyTeams);
                howManyTeams++;
                TournamentModel.TeamAmount = howManyTeams;
                teamGridView.Rows.Add(Row);
                textBox_teamName.Clear();
               
            }
            catch (IndexOutOfRangeException)
            {

                MessageBox.Show("Input is out of range, please try again");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("The format of the input is not valid, please correct it");
                return;
            }
           
            
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
            Form_RunTournament f3 = new Form_RunTournament();
            f3.Show();
            this.Hide(); 
        }


        private void back_Click_2(object sender, EventArgs e)
        {
            Form_TournamentNameType f1 = new Form_TournamentNameType();
            f1.Show();
            this.Hide();
        }

        private void textBox_teamSeeding_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_teamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tournamentNameHere_Click(object sender, EventArgs e)
        {

        }

        private void gameHere_Click(object sender, EventArgs e)
        {

        }
    }
}
