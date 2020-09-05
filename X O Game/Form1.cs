using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "O";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "O";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "O";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "O";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(button1.Text=="X" && button5.Text=="X" && button9.Text=="X")
            {
                label2.Text = "Winer ...";
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label2.Text = "Winer ...";
            }

            else
                label2.Text = "Loser ...";

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "button1";
            button2.Text = "button2";
            button3.Text = "button3";
            button4.Text = "button4";
            button5.Text = "button5";
            button6.Text = "button6";
            button7.Text = "button7";
            button8.Text = "button8";
            button9.Text = "button9";
            label2.Text = "Winer Or Loser ...";
        }
    }
}
