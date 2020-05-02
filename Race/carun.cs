using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class carrun
    {
        public int cargo;
        public Random Random;
        public int racer;
        public int carpos;
        public PictureBox MyPictureBox = null;

        public void engine()
        {
            cargo = 0;
            MyPictureBox.Left = racer;
        }
        public bool carruner()
        {
            var A = Random.Next(1, 22);
            cargo += A;
            MyPictureBox.Left = racer + cargo;

            if (MyPictureBox.Left >= carpos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}