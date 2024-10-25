namespace Gambling_Game
{
    partial class GambleGame
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
            this.imgDieBox3 = new System.Windows.Forms.PictureBox();
            this.imgDieBox1 = new System.Windows.Forms.PictureBox();
            this.imgDieBox2 = new System.Windows.Forms.PictureBox();
            this.btnGamble = new System.Windows.Forms.Button();
            this.btnBetUp = new System.Windows.Forms.Button();
            this.btnBetDown = new System.Windows.Forms.Button();
            this.btnMaxBet = new System.Windows.Forms.Button();
            this.btnMinBet = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDieBox3
            // 
            this.imgDieBox3.Image = global::Gambling_Game.Properties.Resources.die_face_6;
            this.imgDieBox3.Location = new System.Drawing.Point(531, 52);
            this.imgDieBox3.Name = "imgDieBox3";
            this.imgDieBox3.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox3.TabIndex = 2;
            this.imgDieBox3.TabStop = false;
            // 
            // imgDieBox1
            // 
            this.imgDieBox1.Image = global::Gambling_Game.Properties.Resources.die_face_4;
            this.imgDieBox1.Location = new System.Drawing.Point(118, 52);
            this.imgDieBox1.Name = "imgDieBox1";
            this.imgDieBox1.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox1.TabIndex = 1;
            this.imgDieBox1.TabStop = false;
            // 
            // imgDieBox2
            // 
            this.imgDieBox2.Image = global::Gambling_Game.Properties.Resources.die_face_5;
            this.imgDieBox2.Location = new System.Drawing.Point(325, 52);
            this.imgDieBox2.Name = "imgDieBox2";
            this.imgDieBox2.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox2.TabIndex = 0;
            this.imgDieBox2.TabStop = false;
            // 
            // btnGamble
            // 
            this.btnGamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamble.Location = new System.Drawing.Point(300, 304);
            this.btnGamble.Name = "btnGamble";
            this.btnGamble.Size = new System.Drawing.Size(203, 63);
            this.btnGamble.TabIndex = 3;
            this.btnGamble.Text = "Gamble!";
            this.btnGamble.UseVisualStyleBackColor = true;
            // 
            // btnBetUp
            // 
            this.btnBetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetUp.Location = new System.Drawing.Point(620, 336);
            this.btnBetUp.Name = "btnBetUp";
            this.btnBetUp.Size = new System.Drawing.Size(48, 43);
            this.btnBetUp.TabIndex = 4;
            this.btnBetUp.Text = "+10";
            this.btnBetUp.UseVisualStyleBackColor = true;
            // 
            // btnBetDown
            // 
            this.btnBetDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetDown.Location = new System.Drawing.Point(620, 385);
            this.btnBetDown.Name = "btnBetDown";
            this.btnBetDown.Size = new System.Drawing.Size(48, 43);
            this.btnBetDown.TabIndex = 5;
            this.btnBetDown.Text = "-10";
            this.btnBetDown.UseVisualStyleBackColor = true;
            // 
            // btnMaxBet
            // 
            this.btnMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxBet.Location = new System.Drawing.Point(674, 336);
            this.btnMaxBet.Name = "btnMaxBet";
            this.btnMaxBet.Size = new System.Drawing.Size(72, 43);
            this.btnMaxBet.TabIndex = 6;
            this.btnMaxBet.Text = "Maximum";
            this.btnMaxBet.UseVisualStyleBackColor = true;
            // 
            // btnMinBet
            // 
            this.btnMinBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinBet.Location = new System.Drawing.Point(674, 385);
            this.btnMinBet.Name = "btnMinBet";
            this.btnMinBet.Size = new System.Drawing.Size(72, 43);
            this.btnMinBet.TabIndex = 7;
            this.btnMinBet.Text = "Minimum";
            this.btnMinBet.UseVisualStyleBackColor = true;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.Location = new System.Drawing.Point(602, 304);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(158, 26);
            this.lblControls.TabIndex = 8;
            this.lblControls.Text = "Betting Controls";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(25, 357);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(125, 20);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "Money: $100";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(25, 403);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(72, 20);
            this.lblBet.TabIndex = 10;
            this.lblBet.Text = "Bet: $0";
            // 
            // GambleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.btnMinBet);
            this.Controls.Add(this.btnMaxBet);
            this.Controls.Add(this.btnBetDown);
            this.Controls.Add(this.btnBetUp);
            this.Controls.Add(this.btnGamble);
            this.Controls.Add(this.imgDieBox3);
            this.Controls.Add(this.imgDieBox1);
            this.Controls.Add(this.imgDieBox2);
            this.Name = "GambleGame";
            this.Text = "Gambling Game";
            this.Load += new System.EventHandler(this.GambleGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDieBox2;
        private System.Windows.Forms.PictureBox imgDieBox1;
        private System.Windows.Forms.PictureBox imgDieBox3;
        private System.Windows.Forms.Button btnGamble;
        private System.Windows.Forms.Button btnBetUp;
        private System.Windows.Forms.Button btnBetDown;
        private System.Windows.Forms.Button btnMaxBet;
        private System.Windows.Forms.Button btnMinBet;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblBet;
    }
}

