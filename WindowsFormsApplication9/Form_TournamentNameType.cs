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
    public partial class Form_TournamentNameType : Form
    {
        TournamentModel model = new TournamentModel();
        public Form_TournamentNameType()
        {
         
            InitializeComponent();
            try
            {
                textBox1.Text = model.Name;
                est_tourTime.Value = model.est_StartTime;
                est_startDate.Value = model.est_StartDate;
                gameSelect.SelectedItem = TournamentManager.gameType;
                tournamentFormat.SelectedItem = TournamentManager.tournamentType;
            }
            catch (ArgumentNullException)
            {
                textBox1.Text = model.Name;
                est_tourTime.Value = DateTime.Today;
                est_startDate.Value = DateTime.Today;
                gameSelect.SelectedItem = "";
                tournamentFormat.SelectedItem = "";
            }
            catch(FormatException)
            {
                MessageBox.Show("An error occured, you will have to reenter the required fields");
            }
            catch (ArgumentOutOfRangeException)
            {
                textBox1.Text = "";
                est_tourTime.Value = DateTime.Today;
                est_startDate.Value = DateTime.Today;
                gameSelect.SelectedItem = "";
                tournamentFormat.SelectedItem = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && tournamentFormat.SelectedItem != null && gameSelect.SelectedItem != null)
                {
                    Form_AddTeams f2 = new Form_AddTeams();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please make sure you have filled out all fields");
                    return;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
           model.est_StartTime = est_startDate.Value;
        }

        private void gameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Maybe add custom game, possibly in this selector or in another textbox
          
            model.Game = Convert.ToString(gameSelect.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            model.Name = textBox1.Text;
        }

        private void tournamentFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
           model.TournamentType = Convert.ToString(tournamentFormat.SelectedItem);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            model.est_StartTime = est_tourTime.Value;
        }
    }
}
