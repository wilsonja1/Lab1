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
        Guy[] GuyArray = new Guy[3];
        public Form1()
        {
            InitializeComponent();
            Random MyRandomizer = new Random();

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RaceTrackLength = 400,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLength = 400,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLength = 400,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RaceTrackLength = 400,
                Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "joe",
                Cash = 10,
                MyLabel = label2,
                MyRadioButton = radioButton1
            };

            GuyArray[1] = new Guy()
            {
                Name = "bob",
                Cash = 10,
                MyLabel = label3,
                MyRadioButton = radioButton2
            };

            GuyArray[2] = new Guy()
            {
                Name = "al",
                Cash = 10,
                MyLabel = label4,
                MyRadioButton = radioButton3
            };
        }

        //Race
        private void button2_Click(object sender, EventArgs e)
        {
            bool x = true;
            bool y = false;
            int winner = -1;
            while (x)
            {
                for (var i = 0; i < 4; i++)
                {
                    y = GreyhoundArray[i].Run();
                    if (y)
                    {
                        x = false;
                        winner = i;
                        break;
                    }
                    System.Threading.Thread.Sleep(100);
                }
            }
            finish(winner);
        }

        //Bet
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GuyArray[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            if (radioButton2.Checked)
            {
                GuyArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);

            }
            if (radioButton3.Checked)
            {
                GuyArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            updateGuyLabels();
        }

        private void updateGuyLabels()
        {
            foreach (var i in GuyArray)
            {
                i.UpdateLabels();
            }
        }

        private void finish(int winner)
        {
            foreach (var i in GuyArray)
            {
                i.MyBet.PayOut(winner);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = GuyArray[0].Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = GuyArray[1].Name;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = GuyArray[2].Name;

        }
    }
}
