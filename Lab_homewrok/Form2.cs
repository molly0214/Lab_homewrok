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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string tel = textBox2.Text;
            string time = textBox3.Text;
            string gate = textBox4.Text;
            string aa = textBox5.Text;

            MessageBox.Show("歡迎光臨 " + Name + Environment.NewLine + "電話:" + tel + Environment.NewLine + "現在時間: " + time + Environment.NewLine + "請至" + gate + Environment.NewLine + "登機口:" + aa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helloForm1 hello = new helloForm1();
            hello.Show();
        }


    }
}
