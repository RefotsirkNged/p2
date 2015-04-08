using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApplication9
{
    public class DrawMatchMap
    {
        public void arrangeBoxes()
        {

        }
        public void teamGroupBox()
        {
            GroupBox teamBox = new GroupBox();
            teamBox.Name = "teamBox_" +TournamentManager.teamName;
            teamBox.Text = TournamentManager.teamName;
            teamBox.Width = 100;
            teamBox.Height = 50;
            
            
        }
    }
}
