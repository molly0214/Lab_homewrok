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
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        int hour, minute, second;
        string alarmhour, alarmminute;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alarmhour = comboBox1.Text;
            alarmminute = comboBox2.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            label1.Text = hour.ToString();
            label4.Text = minute.ToString();
            label5.Text = second.ToString();
            ring_alarm();
        }

        void ring_alarm()
        {
            if(alarmhour == hour.ToString()&& alarmminute == minute.ToString() && second.ToString() == "0")
            {
                 MessageBox.Show("times upppp!!");
            }
           
        }



        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for(int i = 0;  i<24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for(int j =0;  j<60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
