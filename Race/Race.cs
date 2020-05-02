using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class GOrun : Form
    {
        carrun[] carclass = new carrun[4];
        betters[] betclass = new betters[3];
        Random rand = new Random();

        private void carrun_Tick(object sender, EventArgs e)
        {
            for (int l = 0; l < 4; l++)
            {
                if (carclass[l].carruner())
                {
                    var winner = l + 1;
                    carrun1.Stop();
                    MessageBox.Show($@"Driver number {winner} wins!", @"The Winner is");

                    foreach (betters guy in betclass)
                    {
                        guy.winnercash(winner);
                    }

                    foreach (carrun drivers in carclass)
                    {
                        drivers.engine();
                    }

                    gamble.Enabled = true;
                    break;
                }
            }
        }
        public GOrun()
        {
            InitializeComponent();

            carclass[0] = new carrun()
            {
                MyPictureBox = PBbicycle1,
                racer = PBbicycle1.Left,
                carpos = racetrack.Width - PBbicycle1.Width,
                Random = rand
            };
            carclass[1] = new carrun()
            {
                MyPictureBox = PBbicycle2,
                racer = PBbicycle2.Left,
                carpos = racetrack.Width - PBbicycle2.Width,
                Random = rand
            };
            carclass[2] = new carrun()
            {
                MyPictureBox = PBbicycle3,
                racer = PBbicycle3.Left,
                carpos = racetrack.Width - PBbicycle3.Width,
                Random = rand
            };
            carclass[3] = new carrun()
            {
                MyPictureBox = PBbicycle4,
                racer = PBbicycle4.Left,
                carpos = racetrack.Width - PBbicycle4.Width,
                Random = rand
            };

            betclass[0] = new betters()
            {
                money = 50,
                Placedbet = null,
                carLB = JhonLB,
                carRB = JhonRB,
                name = "Jhon"
            };
            betclass[1] = new betters()
            {
                money = 50,
                Placedbet = null,
                carLB = TroyLB,
                carRB = troyRB,
                name = "troy"
            };
            betclass[2] = new betters()
            {
                money = 50,
                Placedbet = null,
                carLB = kateLB,
                carRB = kateRB,
                name = "kate"
            };

            foreach (betters guy in betclass)
            {
                guy.Placedbet = new bettingcash();
                guy.ClearALL();
                guy.displayLB();
            }

        }

        

        private void jhonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = betclass[0].name;
        }

        private void troyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = betclass[1].name;
        }

        private void kateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = betclass[2].name;
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            if (betclass[0].carRB.Checked)
            {
                if (betclass[0].inserbet((int)money.Value, (int)Driver.Value))
                {
                    betclass[0].displayLB();
                }
            }
            if (betclass[1].carRB.Checked)
            {
                if (betclass[1].inserbet((int)money.Value, (int)Driver.Value))
                {
                    betclass[1].displayLB();
                }
            }
            if (betclass[2].carRB.Checked)
            {
                if (betclass[2].inserbet((int)money.Value, (int)Driver.Value))
                {
                    betclass[2].displayLB();
                }
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            carrun1.Start();
            gamble.Enabled = false;
        }

        private void Jhon_Click(object sender, EventArgs e)
        {

        }

        private void troy_Enter(object sender, EventArgs e)
        {

        }

        private void kate_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
