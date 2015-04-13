using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicTest
{
    public partial class TournamentTree : Form
    {
        public TournamentTree()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Code that creates lines
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 3);
            //Upper line             
            graphicsObj.DrawLine(myPen,
              //(x, y) start, (x, y) end
                20, 40,      170, 40);
            //Lower line
            graphicsObj.DrawLine(myPen, 
                20, 180, 170, 180);
            //Upper to mid line
            graphicsObj.DrawLine(myPen, 
                170, 40, 250, 110);
            //Lower to mid line
            graphicsObj.DrawLine(myPen, 
                170, 180, 250, 110);
            //End line
            graphicsObj.DrawLine(myPen, 
                250, 110, 280, 110);

        }   
          
    }
}
