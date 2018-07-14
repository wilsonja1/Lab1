using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        public Form1()
        {
            InitializeComponent();
            /*GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = PictureBox1,
                StartingPosition = PictureBox1.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = My
            }*/
        }
    }
}
