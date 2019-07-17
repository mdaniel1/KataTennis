using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Player(PictureBox paddle)
        {
            goingUp = false;
            goingDown = false;
            acceleration = 0;
            paddle = null;
            this.paddle = paddle;
        }

        public void processMovePaddle()
        {
            bool? paddleGoingUp = null; //null means the paddle is not moving

            if (goingUp)
                paddleGoingUp = true;

            if (goingDown)
            {
                if (paddleGoingUp.HasValue)
                {
                    paddleGoingUp = null; //If we're already pressing up, cancel the movement
                }
                else
                {
                    paddleGoingUp = false;
                }
            }

            movePaddle(paddleGoingUp);
        }

        private void movePaddle(bool? paddleGoingUp)
        {
            int movementSpeed = PongKataForm.PADDLE_SPEED + acceleration;

            if (paddleGoingUp.HasValue) //Value is not null
            {
                if (paddleGoingUp.Value) //And true
                {
                    movementSpeed *= -1;
                }

                //Sets the new location to a new one without going off limits
                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongKataForm.TOP_WINDOW_LOCATION,
                    Math.Min(PongKataForm.BOTTOM_WINDOW_LOCATION, paddle.Location.Y + movementSpeed))
                    );
            }
        }
    }
}
