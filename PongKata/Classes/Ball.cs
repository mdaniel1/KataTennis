using System.Windows.Forms;

namespace PongKata
{
    internal class Ball
    {
        private PictureBox ball;
        int xSpeed;
        int ySpeed;

        public Ball(PictureBox ball)
        {
            this.ball = ball;
            xSpeed = 1;
            ySpeed = 1;
        }

        void processMoveBall()
        {
            //TODO
        }
    }
}