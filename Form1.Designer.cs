
namespace Helecopter_shooting_game
{
    partial class Form1
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtscore = new System.Windows.Forms.Label();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.Color.White;
            this.txtscore.Location = new System.Drawing.Point(12, 9);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(80, 24);
            this.txtscore.TabIndex = 4;
            this.txtscore.Text = "Score: 0";
            // 
            // ufo
            // 
            this.ufo.Image = global::Helecopter_shooting_game.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(811, 216);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Helecopter_shooting_game.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(77, 169);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // pillar1
            // 
            this.pillar1.Image = global::Helecopter_shooting_game.Properties.Resources.pillar;
            this.pillar1.Location = new System.Drawing.Point(288, 292);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(56, 185);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 1;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            this.pillar2.Image = global::Helecopter_shooting_game.Properties.Resources.pillar;
            this.pillar2.Location = new System.Drawing.Point(567, 0);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(59, 185);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 0;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(925, 478);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.pillar2);
            this.Name = "Form1";
            this.Text = "Helicopter Shooter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtscore;
    }
}

