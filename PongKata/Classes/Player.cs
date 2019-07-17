using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongKata.Classes
{
    public class Player
    {
        public bool goingUp { get; set; }
        public bool goingDown { get; set; }
        public int acceleration { get; set; }
        public PictureBox paddle { get; set; }
        public string currentScore { get; set; }
        public int setsWon { get; set; }
        private Label scoreLabel;
        private Label setsLabel;

        public Player(PictureBox paddle, Label scoreLabel, Label setsLabel)
        {
            goingUp = false;
            goingDown = false;
            acceleration = 0;
            this.paddle = paddle;
            currentScore = "0";
            setsWon = 0;
            this.scoreLabel = scoreLabel;
            this.setsLabel = setsLabel;
            this.setsLabel.Text = "0";
            this.scoreLabel.Text = "0";
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

        public void updateScore()
        {
            scoreLabel.Text = currentScore;
        }

        public void updateSetsWon()
        {
            setsLabel.Text = setsWon.ToString();
        }
    }
}
