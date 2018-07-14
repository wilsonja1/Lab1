using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash.ToString() + " bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin };
            if (BetAmount < Cash) { 
                MyLabel.Text = Name + " bet " + MyBet.Amount.ToString();
                return true;
            }
            else
                return false;
        }

        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
