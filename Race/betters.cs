using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class betters
    {
        public RadioButton carRB;
        public Label carLB;
        public bettingcash Placedbet;
        public string name;
        
        public int money;


        
        public void displayLB()
        {
            carLB.Text = Placedbet.casbetmoney(this);
            carRB.Text = $@"{name} has ${money} dollars";
        }
        public void winnercash(int winner)
        {
            money += Placedbet.cashbet(winner);
            ClearALL();
            displayLB();
        }

        public bool inserbet(int cash, int winner)
        {
            Placedbet = new bettingcash() { cash = cash, amount = this, car = winner };

            if (cash <= this.money)
            {
                Placedbet.cash = cash;
                Placedbet.car = winner;
                return true;
            }
            ClearALL();
            displayLB();
            return false;
        }
        public void ClearALL()
        {
            Placedbet.cash = 0;
        }

       
    }
}