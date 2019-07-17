using PongKata.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace PongKata
{
    public partial class PongKataForm : Form
    {

        #region VARIABLES
        const int PADDLE_SPEED = 5;
        const int PADDLE_ACCEL = 5;
        const int TOP_WINDOW_LOCATION = 0;
        const int BOTTOM_WINDOW_LOCATION = 534;

        Player player1; 
        Player player2;
        #endregion

        public PongKataForm()
        {
            InitializeComponent();
            player1 = new Player(pbPaddleP1);
            player2 = new Player(pbPaddleP2);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            processMovePaddle(player1, player1.goingUp, player1.goingDown);
            processMovePaddle(player2, player2.goingUp, player2.goingDown);
        }

        private void processMovePaddle(Player player, bool isGoingUp, bool isGoingDown)
        {
            bool? paddleGoingUp = null; //null means the paddle is not moving

            if (isGoingUp)
                paddleGoingUp = true;

            if (isGoingDown)
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

            movePaddle(paddleGoingUp, player);
        }

        private void movePaddle(bool? paddleGoingUp, Player player)
        {
            int movementSpeed = PADDLE_SPEED + player.acceleration;

            if (paddleGoingUp.HasValue) //Value is not null
            {
                if (paddleGoingUp.Value) //And true
                {
                    movementSpeed *= -1;
                }

                //Sets the new location to a new one without going off limits
                player.paddle.Location = new Point(player.paddle.Location.X, 
                    Math.Max(TOP_WINDOW_LOCATION, 
                    Math.Min(BOTTOM_WINDOW_LOCATION, player.paddle.Location.Y + movementSpeed))
                    );
            }
        }

        private void PongKataForm_KeyDown(object sender, KeyEventArgs e)
        {
            checkInput(e, true);
        }

        private void PongKataForm_KeyUp(object sender, KeyEventArgs e)
        {
            checkInput(e, false);
        }

        private void checkInput(KeyEventArgs e, bool isKeyPressed)
        {
            //Player 1 uses ZS, Player 2 uses up and down arrows
            switch (e.KeyCode)
            {
                case Keys.Z:
                    player1.goingUp = isKeyPressed;
                    break;
                case Keys.S:
                    player1.goingDown = isKeyPressed;
                    break;
                case Keys.ShiftKey:
                    if (isKeyPressed)
                    {
                        player1.acceleration = PADDLE_ACCEL;
                    }else
                    {
                        player1.acceleration = 0;
                    }
                    break;
                case Keys.Up:
                    player2.goingUp = isKeyPressed;
                    break;
                case Keys.Down:
                    player2.goingDown = isKeyPressed;
                    break;
                case Keys.NumPad0:
                    if (isKeyPressed)
                    {
                        player2.acceleration = PADDLE_ACCEL;
                    }
                    else
                    {
                        player2.acceleration = 0;
                    }
                    break;
            }
        }
    }
}
