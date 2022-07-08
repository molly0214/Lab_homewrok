using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_homewrok
{
    public partial class XOGAME : Form
    { 
        bool isX = true;

        public XOGAME()
        {
           
            InitializeComponent();
        }

        private void testWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") MessageBox.Show("X WIN!!");
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") MessageBox.Show("X WIN!!");
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") MessageBox.Show("X WIN!!");
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") MessageBox.Show("X WIN!!");
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") MessageBox.Show("X WIN!!");
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") MessageBox.Show("X WIN!!");
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") MessageBox.Show("X WIN!!");
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") MessageBox.Show("X WIN!!");
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") MessageBox.Show("O WIN!!");
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") MessageBox.Show("O WIN!!");
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") MessageBox.Show("O WIN!!");
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") MessageBox.Show("O WIN!!");
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") MessageBox.Show("O WIN!!");
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") MessageBox.Show("O WIN!!");
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") MessageBox.Show("O WIN!!");
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") MessageBox.Show("O WIN!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isX == true)
            {
                button1.Text = "X";
                isX = false;
            }
            else
            {
                button1.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button2.Text = "X";
                isX = false;
            }
            else
            {
                button2.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button3.Text = "X";
                isX = false;
            }
            else
            {
                button3.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button4.Text = "X";
                isX = false;
            }
            else
            {
                button4.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button5.Text = "X";
                isX = false;
            }
            else
            {
                button5.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button6.Text = "X";
                isX = false;
            }
            else
            {
                button6.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button7.Text = "X";
                isX = false;
            }
            else
            {
                button7.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button8.Text = "X";
                isX = false;
            }
            else
            {
                button8.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button9.Text = "X";
                isX = false;
            }
            else
            {
                button9.Text = "O";
                isX = true;
            }
            testWin();
        }

        private void button10_Click(object sender, EventArgs e)
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
