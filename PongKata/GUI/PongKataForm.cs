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
        public const int PADDLE_SPEED = 5;
        public const int PADDLE_ACCEL = 5;
        public const int TOP_WINDOW_LOCATION = 0;
        public const int BOTTOM_WINDOW_LOCATION = 534;

        Player player1; 
        Player player2;
        Ball ball;
        PongInfoHandler pih;
        #endregion

        public PongKataForm()
        {
            InitializeComponent();
            player1 = new Player(pbPaddleP1);
            player2 = new Player(pbPaddleP2);
            ball = new Ball(pbBall, player1, player2);
            Timer.Enabled = false;
            winnerLabel.Text = "";
            pih = new PongInfoHandler(currentScoreP1Label, setsWonP1Label, currentScoreP2Label, setsWonP2Label, winnerLabel, startButton, player1, player2, ball, Timer);
            player1.pih = pih;
            player2.pih = pih;
            ball.pih = pih;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            player1.processMovePaddle();
            player2.processMovePaddle();
            ball.processMoveBall();
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
                case Keys.LShiftKey: //I don't really know why only ShiftKey is recognized, probably a matter of keyboard, so I'm putting all the possibilities for the left shift key just in case
                case Keys.Shift:
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

        private void startButton_Click(object sender, EventArgs e)
        {
            winnerLabel.Text = "";
            Timer.Enabled = true;
            startButton.Visible = false;
            this.ActiveControl = null; //Prevents the button from keeping the focus.
        }
    }
}
