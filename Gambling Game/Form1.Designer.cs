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
            this.components = new System.ComponentModel.Container();
            this.btnGamble = new System.Windows.Forms.Button();
            this.btnBetUp = new System.Windows.Forms.Button();
            this.btnBetDown = new System.Windows.Forms.Button();
            this.btnMaxBet = new System.Windows.Forms.Button();
            this.btnMinBet = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.imgDieBox3 = new System.Windows.Forms.PictureBox();
            this.imgDieBox1 = new System.Windows.Forms.PictureBox();
            this.imgDieBox2 = new System.Windows.Forms.PictureBox();
            this.btnLow = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.imgYouLose = new System.Windows.Forms.PictureBox();
            this.lblYouLose = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            this.imgRulesPage = new System.Windows.Forms.PictureBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRulesText1 = new System.Windows.Forms.Label();
            this.lblRulesText5 = new System.Windows.Forms.Label();
            this.lblRulesText4 = new System.Windows.Forms.Label();
            this.lblRulesText3 = new System.Windows.Forms.Label();
            this.lblRulesText2 = new System.Windows.Forms.Label();
            this.lblRulesText6 = new System.Windows.Forms.Label();
            this.lblRulesText7 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrQuit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYouLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRulesPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGamble
            // 
            this.btnGamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamble.Location = new System.Drawing.Point(302, 267);
            this.btnGamble.Name = "btnGamble";
            this.btnGamble.Size = new System.Drawing.Size(203, 63);
            this.btnGamble.TabIndex = 3;
            this.btnGamble.Text = "Gamble!";
            this.btnGamble.UseVisualStyleBackColor = true;
            this.btnGamble.Click += new System.EventHandler(this.btnGamble_Click);
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
            this.btnBetUp.Click += new System.EventHandler(this.btnBetUp_Click);
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
            this.btnBetDown.Click += new System.EventHandler(this.btnBetDown_Click);
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
            this.btnMaxBet.Click += new System.EventHandler(this.btnMaxBet_Click);
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
            this.btnMinBet.Click += new System.EventHandler(this.btnMinBet_Click);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.SystemColors.Control;
            this.lblControls.Location = new System.Drawing.Point(602, 304);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(158, 26);
            this.lblControls.TabIndex = 8;
            this.lblControls.Text = "Betting Controls";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMoney.Location = new System.Drawing.Point(25, 379);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(125, 20);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "Money: $100";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBet.Location = new System.Drawing.Point(25, 416);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(72, 20);
            this.lblBet.TabIndex = 10;
            this.lblBet.Text = "Bet: $0";
            // 
            // imgDieBox3
            // 
            this.imgDieBox3.BackColor = System.Drawing.Color.Transparent;
            this.imgDieBox3.Image = global::Gambling_Game.Properties.Resources.die_face_3;
            this.imgDieBox3.Location = new System.Drawing.Point(531, 52);
            this.imgDieBox3.Name = "imgDieBox3";
            this.imgDieBox3.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox3.TabIndex = 2;
            this.imgDieBox3.TabStop = false;
            // 
            // imgDieBox1
            // 
            this.imgDieBox1.BackColor = System.Drawing.Color.Transparent;
            this.imgDieBox1.Image = global::Gambling_Game.Properties.Resources.die_face_1;
            this.imgDieBox1.Location = new System.Drawing.Point(118, 52);
            this.imgDieBox1.Name = "imgDieBox1";
            this.imgDieBox1.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox1.TabIndex = 1;
            this.imgDieBox1.TabStop = false;
            // 
            // imgDieBox2
            // 
            this.imgDieBox2.BackColor = System.Drawing.Color.Transparent;
            this.imgDieBox2.Image = global::Gambling_Game.Properties.Resources.die_face_2;
            this.imgDieBox2.Location = new System.Drawing.Point(325, 52);
            this.imgDieBox2.Name = "imgDieBox2";
            this.imgDieBox2.Size = new System.Drawing.Size(163, 165);
            this.imgDieBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDieBox2.TabIndex = 0;
            this.imgDieBox2.TabStop = false;
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.Location = new System.Drawing.Point(246, 381);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(72, 43);
            this.btnLow.TabIndex = 11;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMiddle.Location = new System.Drawing.Point(361, 381);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(72, 43);
            this.btnMiddle.TabIndex = 12;
            this.btnMiddle.Text = "Middle";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.Location = new System.Drawing.Point(476, 381);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(72, 43);
            this.btnHigh.TabIndex = 13;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // imgYouLose
            // 
            this.imgYouLose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imgYouLose.Location = new System.Drawing.Point(-1, 0);
            this.imgYouLose.Name = "imgYouLose";
            this.imgYouLose.Size = new System.Drawing.Size(800, 453);
            this.imgYouLose.TabIndex = 14;
            this.imgYouLose.TabStop = false;
            this.imgYouLose.Visible = false;
            // 
            // lblYouLose
            // 
            this.lblYouLose.AutoSize = true;
            this.lblYouLose.BackColor = System.Drawing.Color.Black;
            this.lblYouLose.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYouLose.Location = new System.Drawing.Point(16, 188);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(764, 76);
            this.lblYouLose.TabIndex = 15;
            this.lblYouLose.Text = "You Lose! (You ran out of money)";
            this.lblYouLose.Visible = false;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Green;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRules.Location = new System.Drawing.Point(12, 304);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(72, 43);
            this.btnRules.TabIndex = 16;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // imgRulesPage
            // 
            this.imgRulesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.imgRulesPage.Location = new System.Drawing.Point(-1, -1);
            this.imgRulesPage.Name = "imgRulesPage";
            this.imgRulesPage.Size = new System.Drawing.Size(800, 453);
            this.imgRulesPage.TabIndex = 17;
            this.imgRulesPage.TabStop = false;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRules.Font = new System.Drawing.Font("Palatino Linotype", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRules.Location = new System.Drawing.Point(280, -13);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(246, 106);
            this.lblRules.TabIndex = 18;
            this.lblRules.Text = "Rules";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(324, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRulesText1
            // 
            this.lblRulesText1.AutoSize = true;
            this.lblRulesText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText1.Location = new System.Drawing.Point(38, 154);
            this.lblRulesText1.Name = "lblRulesText1";
            this.lblRulesText1.Size = new System.Drawing.Size(738, 18);
            this.lblRulesText1.TabIndex = 20;
            this.lblRulesText1.Text = "You start with $100. You are gambling on the sum of three dice using the buttons " +
    "on the screen, ";
            // 
            // lblRulesText5
            // 
            this.lblRulesText5.AutoSize = true;
            this.lblRulesText5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText5.Location = new System.Drawing.Point(38, 239);
            this.lblRulesText5.Name = "lblRulesText5";
            this.lblRulesText5.Size = new System.Drawing.Size(716, 18);
            this.lblRulesText5.TabIndex = 21;
            this.lblRulesText5.Text = "you guess correctly, the money you bet will be doubled. You may keep going for as" +
    " long as you ";
            // 
            // lblRulesText4
            // 
            this.lblRulesText4.AutoSize = true;
            this.lblRulesText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText4.Location = new System.Drawing.Point(38, 219);
            this.lblRulesText4.Name = "lblRulesText4";
            this.lblRulesText4.Size = new System.Drawing.Size(704, 18);
            this.lblRulesText4.TabIndex = 22;
            this.lblRulesText4.Text = "have), and once you have made a bet and chosen a range, press the gamble button t" +
    "o play. If ";
            // 
            // lblRulesText3
            // 
            this.lblRulesText3.AutoSize = true;
            this.lblRulesText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText3.Location = new System.Drawing.Point(38, 198);
            this.lblRulesText3.Name = "lblRulesText3";
            this.lblRulesText3.Size = new System.Drawing.Size(703, 18);
            this.lblRulesText3.TabIndex = 23;
            this.lblRulesText3.Text = "8, Middle: sum of 9 - 13, High: sum of 14 - 18. You must bet whatever money you w" +
    "ish (and ";
            // 
            // lblRulesText2
            // 
            this.lblRulesText2.AutoSize = true;
            this.lblRulesText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText2.Location = new System.Drawing.Point(38, 177);
            this.lblRulesText2.Name = "lblRulesText2";
            this.lblRulesText2.Size = new System.Drawing.Size(732, 18);
            this.lblRulesText2.TabIndex = 24;
            this.lblRulesText2.Text = "below the “Gamble” button. The following are the ranges for the three buttons; Lo" +
    "w: sum of  3 - ";
            // 
            // lblRulesText6
            // 
            this.lblRulesText6.AutoSize = true;
            this.lblRulesText6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText6.Location = new System.Drawing.Point(38, 259);
            this.lblRulesText6.Name = "lblRulesText6";
            this.lblRulesText6.Size = new System.Drawing.Size(717, 18);
            this.lblRulesText6.TabIndex = 25;
            this.lblRulesText6.Text = "wish (you can quit at any time, otherwise there is no cap to how much you can win" +
    "), or if you ";
            // 
            // lblRulesText7
            // 
            this.lblRulesText7.AutoSize = true;
            this.lblRulesText7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRulesText7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRulesText7.Location = new System.Drawing.Point(38, 278);
            this.lblRulesText7.Name = "lblRulesText7";
            this.lblRulesText7.Size = new System.Drawing.Size(394, 18);
            this.lblRulesText7.TabIndex = 26;
            this.lblRulesText7.Text = "lose the program will quit. Gamble, and have fun!  ";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Location = new System.Drawing.Point(12, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(72, 43);
            this.btnQuit.TabIndex = 29;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrQuit
            // 
            this.tmrQuit.Interval = 5000;
            this.tmrQuit.Tick += new System.EventHandler(this.tmrQuit_Tick);
            // 
            // GambleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Gambling_Game.Properties.Resources.Casino_Table;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRulesText7);
            this.Controls.Add(this.lblRulesText6);
            this.Controls.Add(this.lblRulesText2);
            this.Controls.Add(this.lblRulesText3);
            this.Controls.Add(this.lblRulesText4);
            this.Controls.Add(this.lblRulesText5);
            this.Controls.Add(this.lblRulesText1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.imgRulesPage);
            this.Controls.Add(this.lblYouLose);
            this.Controls.Add(this.imgYouLose);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnLow);
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
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnQuit);
            this.Name = "GambleGame";
            this.Text = "Gambling Game";
            this.Load += new System.EventHandler(this.GambleGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDieBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYouLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRulesPage)).EndInit();
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
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.PictureBox imgYouLose;
        private System.Windows.Forms.Label lblYouLose;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.PictureBox imgRulesPage;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRulesText1;
        private System.Windows.Forms.Label lblRulesText5;
        private System.Windows.Forms.Label lblRulesText4;
        private System.Windows.Forms.Label lblRulesText3;
        private System.Windows.Forms.Label lblRulesText2;
        private System.Windows.Forms.Label lblRulesText6;
        private System.Windows.Forms.Label lblRulesText7;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrQuit;
    }
}

