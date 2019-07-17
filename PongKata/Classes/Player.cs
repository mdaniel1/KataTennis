using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongKata.Classes
{
    class Player
    {
        public bool goingUp { get; set; }
        public bool goingDown { get; set; }
        public int acceleration { get; set; }
        public PictureBox paddle { get; set; }

        public Player()
        {
            goingUp = false;
            goingDown = false;
            acceleration = 0;
            paddle = null;
        }

        public Player(PictureBox paddle)
        {
            this.paddle = paddle;
        }
    }
}
