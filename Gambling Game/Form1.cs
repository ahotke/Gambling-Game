using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gambling_Game
{
    public partial class GambleGame : Form
    {
        public void EnableButtons(Button keepDisabled)
        {
            btnLow.Enabled = true;
            btnMiddle.Enabled = true;
            btnHigh.Enabled = true;
            btnLow.BackColor = Color.LightGray;
            btnMiddle.BackColor = Color.LightGray;
            btnHigh.BackColor = Color.LightGray;
            keepDisabled.Enabled = false;
            
        }

       

        Random generator = new Random();
        int die1, die2, die3;
        List<Bitmap> die_faces = new List<Bitmap>
        {
            Properties.Resources.die_face_1,
            Properties.Resources.die_face_1,
            Properties.Resources.die_face_2,
            Properties.Resources.die_face_3,
            Properties.Resources.die_face_4,
            Properties.Resources.die_face_5,
            Properties.Resources.die_face_6,
        };
        public GambleGame()
        {
            InitializeComponent();
        }

        private void GambleGame_Load(object sender, EventArgs e)
        {

        }

        int money = 100, bet, sum;
        string range;

        private void btnBetUp_Click(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                money -= 10;
                bet += 10;
                lblMoney.Text = ("Money: $" + money);
                lblBet.Text = ("Bet: $" + bet);
            }

        }

        private void btnBetDown_Click(object sender, EventArgs e)
        {
            if (bet >= 10) {
                bet -= 10;
                money += 10;
            }

            else if (bet < 10)
            {
                money += bet;
                bet = 0;
            }

            lblMoney.Text = ("Money: $" + money);
            lblBet.Text = ("Bet: $" + bet);
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            EnableButtons(btnLow);
            btnLow.BackColor = Color.Red;
            range = "low";
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            EnableButtons(btnMiddle);
            btnMiddle.BackColor = Color.Orange;
            range = "middle";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblRules.Visible = false;
            lblRulesText1.Visible = false;
            lblRulesText2.Visible = false;
            lblRulesText3.Visible = false;
            lblRulesText4.Visible = false;
            lblRulesText5.Visible = false;
            lblRulesText6.Visible = false;
            lblRulesText7.Visible = false;
            btnClose.Visible = false;
            imgRulesPage.Visible = false;
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            lblRules.Visible = true;
            lblRulesText1.Visible = true;
            lblRulesText2.Visible = true;
            lblRulesText3.Visible = true;
            lblRulesText4.Visible = true;
            lblRulesText5.Visible = true;
            lblRulesText6.Visible = true;
            lblRulesText7.Visible = true;
            btnClose.Visible = true;
            imgRulesPage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrQuit_Tick(object sender, EventArgs e)
        {
            tmrQuit.Enabled = false;
            this.Close();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            EnableButtons(btnHigh);
            btnHigh.BackColor = Color.Green;
            range = "high";
        }

        private void btnMaxBet_Click(object sender, EventArgs e)
        {
            if (bet > 0)
            {
                money += bet;
                bet = 0;
            }
            if (money > 0) {
                bet = money;
                money = 0;
            }
            lblMoney.Text = ("Money: $" + money);
            lblBet.Text = ("Bet: $" + bet);
        }

        private void btnMinBet_Click(object sender, EventArgs e)
        {
            if (bet > 0)
            {
                money += bet;
                bet = 0;
            }
            if (money >= 10)
            {
                bet = 10;
                money -= 10;
            }
            lblMoney.Text = ("Money: $" + money);
            lblBet.Text = ("Bet: $" + bet);
        }

        private void btnGamble_Click(object sender, EventArgs e)
        {
            die1 = generator.Next(1, die_faces.Count);
            die2 = generator.Next(1, die_faces.Count);
            die3 = generator.Next(1, die_faces.Count);

            sum = die1 + die2 + die3;

            if (range == "low" && sum <= 8) {

                bet = bet * 2;
                money += bet;
                bet = 0;
                lblMoney.Text = ("Money: $" + money);
                lblBet.Text = ("Bet: $" + bet);
            }

            else if (range == "middle" && sum > 8 && sum <= 13)
            {
                bet = bet * 2;
                money += bet;
                bet = 0;
                lblMoney.Text = ("Money: $" + money);
                lblBet.Text = ("Bet: $" + bet);
            }

            else if (range == "high" && sum > 13 && sum <= 18)
            {
                bet = bet * 2;
                money += bet;
                bet = 0;
                lblMoney.Text = ("Money: $" + money);
                lblBet.Text = ("Bet: $" + bet);
            }

            else
            {
                bet = 0;
                lblBet.Text = ("Bet: $" + bet);
            }

            imgDieBox1.Image = die_faces[die1];
            imgDieBox2.Image = die_faces[die2];
            imgDieBox3.Image = die_faces[die3];

            if (money == 0) {
                lblYouLose.Visible = true;
                imgYouLose.Visible = true;
                tmrQuit.Start();
            }
        }
    }
}
