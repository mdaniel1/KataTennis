namespace PongKata
{
    partial class PongKataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongKataForm));
            this.pbPaddleP1 = new System.Windows.Forms.PictureBox();
            this.pbPaddleP2 = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPaddleP1
            // 
            this.pbPaddleP1.Image = ((System.Drawing.Image)(resources.GetObject("pbPaddleP1.Image")));
            this.pbPaddleP1.Location = new System.Drawing.Point(12, 228);
            this.pbPaddleP1.Name = "pbPaddleP1";
            this.pbPaddleP1.Size = new System.Drawing.Size(21, 144);
            this.pbPaddleP1.TabIndex = 0;
            this.pbPaddleP1.TabStop = false;
            // 
            // pbPaddleP2
            // 
            this.pbPaddleP2.Image = ((System.Drawing.Image)(resources.GetObject("pbPaddleP2.Image")));
            this.pbPaddleP2.Location = new System.Drawing.Point(1231, 228);
            this.pbPaddleP2.Name = "pbPaddleP2";
            this.pbPaddleP2.Size = new System.Drawing.Size(21, 144);
            this.pbPaddleP2.TabIndex = 1;
            this.pbPaddleP2.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(609, 303);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(21, 23);
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PongKataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbPaddleP2);
            this.Controls.Add(this.pbPaddleP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PongKataForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Kata";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongKataForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongKataForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPaddleP1;
        private System.Windows.Forms.PictureBox pbPaddleP2;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer Timer;
    }
}

