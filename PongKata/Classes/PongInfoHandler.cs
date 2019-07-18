using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongKata.Classes
{
    public class PongInfoHandler
    {
        public Label scoreLabelP1 { get; set; }
        public Label setsLabelP1 { get; set; }
        public Label scoreLabelP2 { get; set; }
        public Label setsLabelP2 { get; set; }
        public Label winnerLabel { get; set; }
        public Button startButton { get; set; }

        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public Ball ball { get; set; }
        public Timer timer { get; set; }

        public PongInfoHandler(Label scoreLabelP1,
            Label setsLabelP1,
            Label scoreLabelP2,
            Label setsLabelP2,
            Label winnerLabel,
            Button startButton,
            Player player1,
            Player player2,
            Ball ball,
            Timer timer)
        {
            this.scoreLabelP1 = scoreLabelP1;
            this.setsLabelP1 = setsLabelP1;
            this.scoreLabelP2 = scoreLabelP2;
            this.setsLabelP2 = setsLabelP2;
  
            this.player1 = player1;
            this.player2 = player2;
            this.ball = ball;
            this.timer = timer;

            resetScore();

            this.startButton = startButton;

            this.winnerLabel = winnerLabel;
        }

        private void resetScore()
        {
            setsLabelP1.Text = "0";
            scoreLabelP1.Text = "0";
            setsLabelP2.Text = "0";
            scoreLabelP2.Text = "0";
            player1.currentScore = "0";
            player1.setsWon = 0;
            player2.currentScore = "0";
            player2.setsWon = 0;
            player1.winner = false;
            player2.winner = false;
        }

        internal void updateScore()
        {
            scoreLabelP1.Text = player1.currentScore;
            scoreLabelP2.Text = player2.currentScore;
        }

        internal void updateSetsWon()
        {
            setsLabelP1.Text = player1.setsWon.ToString();
            setsLabelP2.Text = player2.setsWon.ToString();
        }

        internal void checkWinner()
        {
            if (player1.winner || player2.winner)
            {
                if (player1.winner)
                {
                    winnerLabel.Text = "Player 1 won !";
                }
                else{
                    winnerLabel.Text = "Player 2 won !";
                }

                startButton.Enabled = true;
                startButton.Visible = true;
                timer.Enabled = false;
                resetScore();
                ball.resetBall();
            }
            

        }
    }
}
