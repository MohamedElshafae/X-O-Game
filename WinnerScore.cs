using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_o_Form
{
    public partial class WinnerScore : Form
    {
        public WinnerScore()
        {
            InitializeComponent();
        }

        private void Descrease_Click(object sender, EventArgs e)
        {
            if (int.Parse(WScore.Text) == 1)
                return;
            WScore.Text = (int.Parse(WScore.Text)-1).ToString();
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            WScore.Text = (int.Parse(WScore.Text) + 1).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            frm.WinnerScore = int.Parse(WScore.Text);
            Close();
        }
    }
}
