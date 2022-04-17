using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label6.Visible = false;
            timer1.Enabled = true;
            button1.Enabled = true;
            button1.Text = "Başla";
            button1.ForeColor = Color.Green;
            b1.Text = ""; b1.Enabled = false;
            b2.Text = ""; b2.Enabled = false;
            b3.Text = ""; b3.Enabled = false;
            b4.Text = ""; b4.Enabled = false;
            b5.Text = ""; b5.Enabled = false;
            b6.Text = ""; b6.Enabled = false;
            b7.Text = ""; b7.Enabled = false;
            b8.Text = ""; b8.Enabled = false;
            b9.Text = ""; b9.Enabled = false;
        }
        int sira = 0;
        int Kazanma = 0;
        string kazanan;
        int player1_skor = 0, player2_skor = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0?"X":"O";
            b1.Text = isaret;
            b1.Enabled = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = Color.LightGreen; b2.BackColor = Color.LightGreen; b3.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0?"Winner Player 1": "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text == b4.Text && b4.Text == b7.Text)
            {
                b1.BackColor = Color.LightGreen; b4.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text == b5.Text && b5.Text == b9.Text)
            {
                b1.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if(b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" 
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b2.Text = isaret;
            b2.Enabled = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = Color.LightGreen; b2.BackColor = Color.LightGreen; b3.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b2.Text == b5.Text && b5.Text == b8.Text)
            {
                b2.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b3.Text = isaret;
            b3.Enabled = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = Color.LightGreen; b2.BackColor = Color.LightGreen; b3.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if( b3.Text == b5.Text && b5.Text == b7.Text)
            {
                b3.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if(b3.Text == b6.Text && b6.Text == b9.Text)
            {
                b3.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b4.Text = isaret;
            b4.Enabled = false;
            if(b1.Text == b4.Text && b4.Text == b7.Text)
            {
                b1.BackColor = Color.LightGreen; b4.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if(b4.Text == b5.Text && b5.Text == b6.Text)
            {
                b4.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b5.Text = isaret;
            b5.Enabled = false;
            if (b4.Text == b5.Text && b5.Text == b6.Text)
            {
                b4.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b3.Text == b5.Text && b5.Text == b7.Text)
            {
                b3.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b2.Text == b5.Text && b5.Text == b8.Text)
            {
                b2.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text == b5.Text && b5.Text == b9.Text)
            {
                b1.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label6.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label4.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b6.Text = isaret;
            b6.Enabled = false;
            if (b4.Text == b5.Text && b5.Text == b6.Text)
            {
                b4.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                button1.Enabled = true;
                label4.Visible = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b3.Text == b6.Text && b6.Text == b9.Text)
            {
                b3.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b7.Text = isaret;
            b7.Enabled = false;
            if (b1.Text == b4.Text && b4.Text == b7.Text)
            {
                b1.BackColor = Color.LightGreen; b4.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b3.Text == b5.Text && b5.Text == b7.Text)
            {
                b3.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b7.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if(b7.Text == b8.Text && b8.Text == b9.Text)
            {
                b7.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b8.Text = isaret;
            b8.Enabled = false;
            if (b7.Text == b8.Text && b8.Text == b9.Text)
            {
                b7.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b2.Text == b5.Text && b5.Text == b8.Text)
            {
                b2.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red; b2.BackColor = Color.Red; b3.BackColor = Color.Red; b4.BackColor = Color.Red; b5.BackColor = Color.Red; b6.BackColor = Color.Red; b7.BackColor = Color.Red; b8.BackColor = Color.Red; b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string isaret = sira%2==0 ? "X" : "O";
            b9.Text = isaret;
            b9.Enabled = false;
            if (b1.Text == b5.Text && b5.Text == b9.Text)
            {
                b1.BackColor = Color.LightGreen; b5.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b3.Text == b6.Text && b6.Text == b9.Text)
            {
                b3.BackColor = Color.LightGreen; b6.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false; b2.Enabled = false; b3.Enabled = false; b4.Enabled = false; b5.Enabled = false; b6.Enabled = false; b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b7.Text == b8.Text && b8.Text == b9.Text)
            {
                b7.BackColor = Color.LightGreen; b8.BackColor = Color.LightGreen; b9.BackColor = Color.LightGreen;
                b1.Enabled = false;b2.Enabled = false;b3.Enabled = false;b4.Enabled = false;b5.Enabled = false;b6.Enabled = false;b7.Enabled = false;b8.Enabled = false;b9.Enabled = false;
                Kazanma++;
                kazanan = sira%2==0 ? "Winner Player 1" : "Winner Player 2";
                label5.Text = kazanan;
                label4.Visible = true;
                button1.Enabled = true;
                if (sira%2==0)
                    player1_skor++;
                else
                    player2_skor++;
            }
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
                && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                Kazanma++;
                b1.BackColor = Color.Red;b2.BackColor = Color.Red;b3.BackColor = Color.Red;b4.BackColor = Color.Red;b5.BackColor = Color.Red;b6.BackColor = Color.Red;b7.BackColor = Color.Red;b8.BackColor = Color.Red;b9.BackColor = Color.Red;
                label6.Visible = true;
                button1.Enabled = true;
            }
            player1.Text = Convert.ToString(player1_skor);
            player2.Text = Convert.ToString(player2_skor);
            sira++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.Second.ToString();
            label12.Text = DateTime.Now.Minute.ToString();
            label13.Text = DateTime.Now.Hour.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            b1.Text = "";b1.Enabled = true; b1.BackColor = Color.LightBlue;
            b2.Text = "";b2.Enabled = true; b2.BackColor = Color.LightBlue;
            b3.Text = "";b3.Enabled = true; b3.BackColor = Color.LightBlue;
            b4.Text = "";b4.Enabled = true; b4.BackColor = Color.LightBlue;
            b5.Text = "";b5.Enabled = true; b5.BackColor = Color.LightBlue;
            b6.Text = "";b6.Enabled = true; b6.BackColor = Color.LightBlue;
            b7.Text = "";b7.Enabled = true; b7.BackColor = Color.LightBlue;
            b8.Text = "";b8.Enabled = true; b8.BackColor = Color.LightBlue;
            b9.Text = "";b9.Enabled = true; b9.BackColor = Color.LightBlue;
            label5.Text = "";
            label4.Visible = false;
            label6.Visible = false;
            Kazanma--;
            button1.ForeColor = Color.Red;
            button1.Text = "Tekrar Oyna";
            button1.Enabled = false;
            sira = 0;
        }
    }
}
