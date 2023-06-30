using System.Drawing;

namespace x_o_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Hover(object sender, EventArgs e)
        {

            exit.ForeColor = Color.White;
            start.ForeColor = Color.DarkGray;
        }

        private void start_Hover(object sender, EventArgs e)
        {
            start.ForeColor = Color.White;
            exit.ForeColor = Color.DarkGray;
        }

        private void start_Click(object sender, EventArgs e)
        {
            WinnerScore frm = new WinnerScore();
            frm.Show();
            Hide();
        }

        private void Form1_Hover(object sender, EventArgs e)
        {
            exit.ForeColor = Color.DarkGray;
            start.ForeColor = Color.DarkGray;
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label1.ForeColor = Color.AliceBlue;
                label2.ForeColor = Color.FromArgb(160, 160, 160);
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                count++;
            }
            else if (count == 1) 
            {             
                label1.ForeColor = Color.AliceBlue;
                label2.ForeColor = Color.AliceBlue;
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                count++;
            }
            else if(count == 2)
            {
                label1.ForeColor = Color.AliceBlue;
                label2.ForeColor = Color.AliceBlue;
                label3.ForeColor = Color.AliceBlue;
                count++;
            }
            else if (count == 3)
            {
                label1.ForeColor = Color.AliceBlue;
                label2.ForeColor = Color.AliceBlue;
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                count++;
            }
            else if (count == 4)
            {
                label1.ForeColor = Color.AliceBlue;
                label2.ForeColor = Color.FromArgb(160, 160, 160);
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                count++;
            }

            else if (count == 5)
            {
                label1.ForeColor = Color.FromArgb(160, 160, 160);
                label2.ForeColor = Color.FromArgb(160, 160, 160);
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                count = 0;
            }


        }
    }
}