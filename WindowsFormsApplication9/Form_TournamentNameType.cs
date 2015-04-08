﻿using System;
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
        public Form_TournamentNameType()
        {
            InitializeComponent();
            try
            {
                textBox1.Text = TournamentManager.tournamentName;
                est_tourTime.Value = DateTime.Parse(TournamentManager.est_startTime);
                est_startDateTime.Value = DateTime.Parse(TournamentManager.est_startDate);
                gameSelect.SelectedItem = TournamentManager.gameType;
                tournamentFormat.SelectedItem = TournamentManager.tournamentType;
            }
            catch (ArgumentNullException)
            {
                textBox1.Text = "";
                est_tourTime.Value = DateTime.Today;
                est_startDateTime.Value = DateTime.Today;
                gameSelect.SelectedItem = "";
                tournamentFormat.SelectedItem = "";
            }
            catch(FormatException)
            {
                
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
            TournamentManager.est_startDate = Convert.ToString(this.est_startDateTime);
        }

        private void gameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Maybe add custom game, possibly in this selector or in another textbox
            TournamentManager.gameType = Convert.ToString(gameSelect.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TournamentManager.tournamentName = textBox1.Text;
        }

        private void tournamentFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            TournamentManager.tournamentType = Convert.ToString(tournamentFormat.SelectedItem);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            TournamentManager.est_startTime = est_tourTime.Text;
        }
    }
}
