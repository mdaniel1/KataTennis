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
            this.globalSetsLabel = new System.Windows.Forms.Label();
            this.globalScoreLabel = new System.Windows.Forms.Label();
            this.setsWonP1Label = new System.Windows.Forms.Label();
            this.separationBarLabel = new System.Windows.Forms.Label();
            this.setsWonP2Label = new System.Windows.Forms.Label();
            this.currentScoreP1Label = new System.Windows.Forms.Label();
            this.separationBar2Label = new System.Windows.Forms.Label();
            this.currentScoreP2Label = new System.Windows.Forms.Label();
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
            this.pbBall.Location = new System.Drawing.Point(620, 330);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(22, 22);
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // globalSetsLabel
            // 
            this.globalSetsLabel.AutoSize = true;
            this.globalSetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalSetsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.globalSetsLabel.Location = new System.Drawing.Point(561, 9);
            this.globalSetsLabel.Name = "globalSetsLabel";
            this.globalSetsLabel.Size = new System.Drawing.Size(54, 20);
            this.globalSetsLabel.TabIndex = 3;
            this.globalSetsLabel.Text = "Sets : ";
            // 
            // globalScoreLabel
            // 
            this.globalScoreLabel.AutoSize = true;
            this.globalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.globalScoreLabel.Location = new System.Drawing.Point(561, 29);
            this.globalScoreLabel.Name = "globalScoreLabel";
            this.globalScoreLabel.Size = new System.Drawing.Size(59, 20);
            this.globalScoreLabel.TabIndex = 4;
            this.globalScoreLabel.Text = "Score :";
            // 
            // setsWonP1Label
            // 
            this.setsWonP1Label.AutoSize = true;
            this.setsWonP1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setsWonP1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setsWonP1Label.Location = new System.Drawing.Point(626, 9);
            this.setsWonP1Label.Name = "setsWonP1Label";
            this.setsWonP1Label.Size = new System.Drawing.Size(40, 20);
            this.setsWonP1Label.TabIndex = 5;
            this.setsWonP1Label.Text = "Adv.";
            // 
            // separationBarLabel
            // 
            this.separationBarLabel.AutoSize = true;
            this.separationBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separationBarLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.separationBarLabel.Location = new System.Drawing.Point(670, 9);
            this.separationBarLabel.Name = "separationBarLabel";
            this.separationBarLabel.Size = new System.Drawing.Size(14, 20);
            this.separationBarLabel.TabIndex = 6;
            this.separationBarLabel.Text = "-";
            // 
            // setsWonP2Label
            // 
            this.setsWonP2Label.AutoSize = true;
            this.setsWonP2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setsWonP2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setsWonP2Label.Location = new System.Drawing.Point(694, 9);
            this.setsWonP2Label.Name = "setsWonP2Label";
            this.setsWonP2Label.Size = new System.Drawing.Size(40, 20);
            this.setsWonP2Label.TabIndex = 7;
            this.setsWonP2Label.Text = "Adv.";
            // 
            // currentScoreP1Label
            // 
            this.currentScoreP1Label.AutoSize = true;
            this.currentScoreP1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreP1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentScoreP1Label.Location = new System.Drawing.Point(626, 29);
            this.currentScoreP1Label.Name = "currentScoreP1Label";
            this.currentScoreP1Label.Size = new System.Drawing.Size(40, 20);
            this.currentScoreP1Label.TabIndex = 8;
            this.currentScoreP1Label.Text = "Adv.";
            // 
            // separationBar2Label
            // 
            this.separationBar2Label.AutoSize = true;
            this.separationBar2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separationBar2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.separationBar2Label.Location = new System.Drawing.Point(672, 29);
            this.separationBar2Label.Name = "separationBar2Label";
            this.separationBar2Label.Size = new System.Drawing.Size(14, 20);
            this.separationBar2Label.TabIndex = 9;
            this.separationBar2Label.Text = "-";
            // 
            // currentScoreP2Label
            // 
            this.currentScoreP2Label.AutoSize = true;
            this.currentScoreP2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreP2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentScoreP2Label.Location = new System.Drawing.Point(694, 29);
            this.currentScoreP2Label.Name = "currentScoreP2Label";
            this.currentScoreP2Label.Size = new System.Drawing.Size(40, 20);
            this.currentScoreP2Label.TabIndex = 10;
            this.currentScoreP2Label.Text = "Adv.";
            // 
            // PongKataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.currentScoreP2Label);
            this.Controls.Add(this.separationBar2Label);
            this.Controls.Add(this.currentScoreP1Label);
            this.Controls.Add(this.setsWonP2Label);
            this.Controls.Add(this.separationBarLabel);
            this.Controls.Add(this.setsWonP1Label);
            this.Controls.Add(this.globalScoreLabel);
            this.Controls.Add(this.globalSetsLabel);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPaddleP1;
        private System.Windows.Forms.PictureBox pbPaddleP2;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label globalSetsLabel;
        private System.Windows.Forms.Label globalScoreLabel;
        private System.Windows.Forms.Label setsWonP1Label;
        private System.Windows.Forms.Label separationBarLabel;
        private System.Windows.Forms.Label setsWonP2Label;
        private System.Windows.Forms.Label currentScoreP1Label;
        private System.Windows.Forms.Label separationBar2Label;
        private System.Windows.Forms.Label currentScoreP2Label;
    }
}

