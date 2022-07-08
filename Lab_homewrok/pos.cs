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
    public partial class Pos : Form
    {
        //宣告每個物品的單價
        int airpod = 500, iphone = 999, mac = 3000, ipad = 700;

        //先宣告每個物品被點擊的次數
        int airpod_times = 0, iphone_times = 0, mac_times = 0, ipad_times = 0;

        //總金額
        int total_amount = 0;

        //紀錄每個物品是排列在listbox裡面第幾個
        int total_Index = 0;
        int airpod_Index;
        int iphone_Index;
        int mac_Index;
        int ipad_Index;

        public Pos()
        {
            InitializeComponent();
        }

        //AirPod
        private void button1_Click(object sender, EventArgs e)
        {
            //每點一次airpod按鈕就增加airpod數量一次
            airpod_times++;

            //用點級數量來看，如果是第一次的話要先決定好在listbox裡排第幾個
            if (airpod_times == 1)
            {
                //因為只有四種商品，所以每種商品近來第一次時total_Index在賦予每個商品第幾個後要+1
                if (total_Index < 5 && total_Index > 0)
                {

                    airpod_Index = total_Index++;
                }
                else
                {
                    //若是第一筆點進來的話得給這筆第【0】個位置，也就是在listbox上第一項，隨後total_Index紀錄為1，代表listbox上已經有一筆項目
                    airpod_Index = 0;
                    total_Index++;
                }

            }
            else
            {
                //若不是第一次點進來，則去找到那筆商品在第幾個位置後去移除
                listBox1.Items.RemoveAt(airpod_Index);
            }
            //listBox1去顯示出總共多少個airpod共多少錢
            listBox1.Items.Insert(airpod_Index, button1.Text + "X" + airpod_times + ",共" + airpod * airpod_times + "元");
            button1.Text = "AirPod $500";
            //每次點過按鈕後都要重新計算價錢，把全部的單價去乘上數量
            total_amount = airpod * airpod_times + iphone * iphone_times + mac * mac_times + ipad * ipad_times;
            //最後把總金額顯示在textBox1上
            textBox1.Text = "NT$" + total_amount + "元";
        }


        //Iphone
        private void button2_Click(object sender, EventArgs e)
        {
            iphone_times++;

            if (iphone_times == 1)
            {
                if (total_Index < 5 && total_Index > 0)
                {

                    iphone_Index = total_Index++;
                }
                else
                {
                    iphone_Index = 0;
                    total_Index++;
                }
            }
            else
            {
                listBox1.Items.RemoveAt(iphone_Index);
            }
            listBox1.Items.Insert(iphone_Index, button2.Text + "X" + iphone_times + ",共" + iphone * iphone_times + "元");

            button2.Text = "Iphone $999";
            total_amount = airpod * airpod_times + iphone * iphone_times + mac * mac_times + ipad * ipad_times;
            textBox1.Text = "NT$" + total_amount + "元";
        }

        //Mac
        private void button3_Click(object sender, EventArgs e)
        {
            mac_times++;

            if (mac_times == 1)
            {
                if (total_Index < 5 && total_Index > 0)
                {

                    mac_Index = total_Index++;
                }
                else
                {
                    mac_Index = 0;
                    total_Index++;
                }
            }
            else
            {
                listBox1.Items.RemoveAt(mac_Index);
            }

            listBox1.Items.Insert(mac_Index, button3.Text + "X" + mac_times + ",共" + mac * mac_times + "元");
            button3.Text = "Mac $3000";
            total_amount = airpod * airpod_times + iphone * iphone_times + mac * mac_times + ipad * ipad_times;
            textBox1.Text = "NT$" + total_amount + "元";
        }

        //Ipad
        private void button4_Click(object sender, EventArgs e)
        {
            ipad_times++;

            if (ipad_times == 1)
            {
                if (total_Index < 5 && total_Index > 0)
                {

                    ipad_Index = total_Index++;
                }
                else
                {
                    ipad_Index = 0;
                    total_Index++;
                }

            }
            else
            {
                listBox1.Items.RemoveAt(ipad_Index);
            }

            listBox1.Items.Insert(ipad_Index, button4.Text + "X" + ipad_times + ",共" + ipad * ipad_times + "元");
            button4.Text = "Ipad $700";
            total_amount = airpod * airpod_times + iphone * iphone_times + mac * mac_times + ipad * ipad_times;
            textBox1.Text = "NT$" + total_amount + "元";
        }

        //現金
        private void button5_Click(object sender, EventArgs e)
        {
            //判斷金額欄是否有金額
            if (total_amount == 0)
            {
                MessageBox.Show("請先選擇項目!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("總金額:NT$" + total_amount, "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //信用卡
        private void button6_Click(object sender, EventArgs e)
        {
            //判斷金額欄是否有金額
            if (total_amount == 0)
            {
                MessageBox.Show("請先選擇項目!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int aa = Convert.ToInt32(total_amount * 0.9);
                MessageBox.Show("總金額:NT$" +total_amount + "\n折扣後金額 : " +aa);
            }
        }

        //清除清單按鈕
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            airpod_times = iphone_times = mac_times = ipad_times = 0;
            total_amount = 0;
            total_Index = airpod_Index = iphone_Index = mac_Index = ipad_Index = 0;
            textBox1.Text = null;
        }

    }
}