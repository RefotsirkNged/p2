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
    public partial class Form_RunTournament : Form
    {
        TournamentModel model = new TournamentModel();
        public Form_RunTournament()
        {
            InitializeComponent();
            tournamentBox.Text = TournamentModel.Name;
            //konverterer til string fordi textbox ik kan lide DateTime format
            tour_StartTime.Text = Convert.ToString(TournamentModel.est_StartTime);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmationBox = MessageBox.Show("Are you sure you want to end the tournament, results will be posted on the scoreboard", "Confirmation on ending tournament", MessageBoxButtons.YesNo);
            if (confirmationBox == DialogResult.Yes)
            {
                Form_Scoreboard f4 = new Form_Scoreboard();
                f4.Show();
                this.Close();
            }
            else if (confirmationBox == DialogResult.No)
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tour_StartTime_Click(object sender, EventArgs e)
        {

        }

        private void est_endTime_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void tournamentBox_Enter(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_Scoreboard f4 = new Form_Scoreboard();
            f4.Show();
       
        }

        public void TournamentCount_TextChanged(object sender, EventArgs e)
        {

        }

        public void teamGroupBox()
        {
          
            GroupBox teamBox = new GroupBox();
            teamBox.Name = "teamBox_" + TournamentManager.teamName;
            teamBox.Text = TournamentManager.teamName;
            teamBox.Width = 100;
            teamBox.Height = 50;
            teamBox.Left += 100;
            teamBox.Top += 100;

        }

        private void startTournament_Click(object sender, EventArgs e)
        {
            teamGroupBox();
        }
    }
}
