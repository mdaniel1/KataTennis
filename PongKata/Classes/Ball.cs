using PongKata.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongKata
{
    public class Ball
    {
        public const int BALL_DEFAULT_X_LOCATION = 620;
        public const int BALL_DEFAULT_Y_LOCATION = 330;
        public const int BALL_DEFAULT_X_SPEED = -4;
        public const int BALL_DEFAULT_Y_SPEED = 4;
        public const int BALL_BOTTOM_WINDOW_LOCATION = 658;
        public const int BALL_LEFT_WINDOW_LOCATION = 0;
        public const int BALL_RIGHT_WINDOW_LOCATION = 1280;
        Random rng = new Random();
        private PictureBox ball;
        int xSpeed;
        int ySpeed;

        public Ball(PictureBox ball)
        {
            this.ball = ball;
            xSpeed = BALL_DEFAULT_X_SPEED;
            ySpeed = BALL_DEFAULT_Y_SPEED;
        }

        public void processMoveBall(Player player1, Player player2)
        {
            ball.Location = new Point(ball.Location.X + xSpeed,
                Math.Max(PongKataForm.TOP_WINDOW_LOCATION, 
                Math.Min(BALL_BOTTOM_WINDOW_LOCATION, ball.Location.Y + ySpeed)
                )
            );

            if(ball.Location.Y == BALL_BOTTOM_WINDOW_LOCATION || ball.Location.Y == PongKataForm.TOP_WINDOW_LOCATION)
            {
                BounceVertical();
            }

            if (player1.paddle.Bounds.IntersectsWith(ball.Bounds) || player2.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                BounceFromPaddle();
            }

            if(ball.Location.X <= BALL_LEFT_WINDOW_LOCATION)
            {
                scoreForPlayer(player2, player1);
                resetBall();
            } else if(ball.Location.X >= BALL_RIGHT_WINDOW_LOCATION)
            {
                scoreForPlayer(player1, player2);
                resetBall();
            }
        }

        public void scoreForPlayer(Player playerWhoScored, Player otherPlayer)
        {
            switch (playerWhoScored.currentScore)
            {
                case "0":
                    playerWhoScored.currentScore = "15";
                    break;
                case "15":
                    playerWhoScored.currentScore = "30";
                    break;
                case "30":
                    playerWhoScored.currentScore = "40";
                    break;
                case "40":
                    if (otherPlayer.currentScore.Equals("40")) //Deuce
                    {
                        playerWhoScored.currentScore = "Adv.";
                    }
                    else if (otherPlayer.currentScore.Equals("Adv."))
                    {
                        otherPlayer.currentScore = "40";
                    }
                    else
                    {
                        playerWhoScored.setsWon++;
                        playerWhoScored.currentScore = "0";
                        otherPlayer.currentScore = "0";
                    }
                    break;
                case "Adv.":
                    playerWhoScored.setsWon++;
                    playerWhoScored.currentScore = "0";
                    otherPlayer.currentScore = "0";
                    break;
            }

            playerWhoScored.updateScore();
            playerWhoScored.updateSetsWon();
            otherPlayer.updateScore();
            otherPlayer.updateSetsWon();
        }

        private void resetBall()
        {
            do
            {
                ySpeed = rng.Next(-2, 3);
                xSpeed = rng.Next(-2, 3);
            } while (ySpeed == 0 || xSpeed == 0);
            
            ball.Location = new Point(BALL_DEFAULT_X_LOCATION, BALL_DEFAULT_Y_LOCATION);
        }

        private void BounceFromPaddle()
        {
            ySpeed *= -1;
            if (ySpeed < 0)
                ySpeed = rng.Next(ySpeed - 2, ySpeed);
            else
                ySpeed = rng.Next(ySpeed, ySpeed + 2);

            xSpeed *= -1;
            if (xSpeed < 0)
                xSpeed = rng.Next(xSpeed - 2, xSpeed);
            else
                xSpeed = rng.Next(xSpeed, xSpeed + 2);
        }

        private void BounceVertical()
        {
            ySpeed *= -1;
        }
    }
}