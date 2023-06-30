using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_o_Form
{
    public partial class Form2 : Form
    {
        public int WinnerScore;
        public Form2()
        {
            InitializeComponent();
        }
        int GameCount=0;
        private void home_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
        private void home_Hover(object sender, EventArgs e)
        {
            this.home.ForeColor = Color.White;
            this.playAgain.ForeColor = Color.DarkGray;
        }
        private void playagain_Hover(object sender, EventArgs e)
        {
            this.playAgain.ForeColor = Color.White;
            this.home.ForeColor = Color.DarkGray;
        }

        private void Form2_Hover(object sender, EventArgs e)
        {
            this.playAgain.ForeColor = Color.DarkGray;
            this.home.ForeColor = Color.DarkGray;
        }

        bool t = true;
        String x = "X";
        String y = "O";
        int count1 = 0,count2=0;
        private void button1_Click(object sender, EventArgs e)
        {
            GameCount++;
            Button b = sender as Button;          
           
            if (t)
            {              
                b.Text = x;
                t = false;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.Gray;
            }
            else
            {
                b.Text = y;
                t = true;
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.Gray;
            }

            b.Enabled = false;

            check();
            if (count1 == WinnerScore)
            {
                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                Winner.Text = "The Player One Won The Game";
                count1 = 0;
                player1Score.Text = count1.ToString();
                count2 = 0;
                player2Score.Text = count2.ToString();
                return;
            }
            else if (count2 == WinnerScore)
            {
                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                Winner.Text = "The Player Two Won The Game";
                count1 = 0;
                player1Score.Text = count1.ToString();
                count2 = 0;
                player2Score.Text = count2.ToString();
                return;

            }


        }

        public void check()
        {
            
            if(button1.Text== "X"&& button2.Text == "X" && button3.Text == "X"   ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X"||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X"||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X"||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X"||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X"||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                Winner.Text = "The Winner is Player 1";
                count1++;
                player1Score.Text = count1.ToString();
                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                Winner.Text = "the Winner is Player 2";
                count2++;
                player2Score.Text = count2.ToString();
                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else if(GameCount==9)
            {
                Winner.Text = "Tie";
                player1Score.Text = count1.ToString();
                player2Score.Text = count2.ToString();
                GameCount = 0;
            }



        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true; 
            button2.Enabled = true; 
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            Winner.Text = " ";
            GameCount = 0;


        }
    }
}
