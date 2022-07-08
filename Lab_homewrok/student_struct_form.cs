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
    public partial class student_struct_form : Form
    {
        public student_struct_form()
        {
            InitializeComponent();
        }

        //把student的資料放在外面 另一顆btn才可以使用
        student sc;

        //儲存//按鍵button1

        string result = "成績 : ";

        private void button1_Click(object sender, EventArgs e)
        {
            //student sc;
            sc.studentName = textBox1.Text;
            sc.chscores = int.Parse(textBox2.Text);
            sc.englishscores = int.Parse(textBox3.Text);
            sc.mathscores = int.Parse(textBox4.Text);
            result =("姓名 : " + sc.studentName +Environment.NewLine +"國文 : " + sc.chscores +Environment.NewLine + "英文 : " + sc.englishscores + Environment.NewLine + "數學 : " +sc.mathscores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //紀錄最高、最低分的科目中文
            string HighScore_Name, LowScore_Name;

            //紀錄最高、最低分的科目分數
            int HighScore, LowScore;

            #region 用三元運算寫法
            //先拿國文分數跟英文分數比較，如果哪個高HighScore、HighScore_Name就是哪個
            HighScore_Name = sc.chscores > sc.englishscores ? "國文" : "英文";
            HighScore = sc.chscores > sc.englishscores ? sc.chscores : sc.englishscores;

            //相反的，比較高的同時也比較低的
            LowScore_Name = sc.chscores > sc.englishscores ? "英文" : "國文";
            LowScore = sc.chscores > sc.englishscores ? sc.englishscores : sc.chscores;

            //再來拿HighScore來跟剩下的數學比較，哪個高就是哪個
            HighScore_Name = HighScore > sc.mathscores ? HighScore_Name : "數學";
            HighScore = HighScore > sc.mathscores ? HighScore : sc.mathscores;

            //相反的，比較高的同時也比較低的
            LowScore_Name = LowScore > sc.mathscores ? "數學" : LowScore_Name;
            LowScore = LowScore > sc.mathscores ? sc.mathscores : LowScore;
            #endregion

            #region 用if-else寫法

            ////先比較國文跟英文
            //if (sc.chscores > sc.englishscores)
            //{
            //    HighScore_Name = "國文";
            //    HighScore = sc.chscores;
            //    LowScore_Name = "英文";
            //    LowScore = sc.englishscores;
            //}
            //else
            //{
            //    HighScore_Name = "英文";
            //    HighScore = sc.englishscores;
            //    LowScore_Name = "國文";
            //    LowScore = sc.chscores;
            //}

            ////再拿國英比較完 最高的分數跟數學比
            //if (HighScore < sc.mathscores)
            //{
            //    HighScore_Name = "數學";
            //    HighScore = sc.mathscores;
            //}

            ////再拿國英比較完 最低的分數跟數學比
            //if (LowScore > sc.mathscores)
            //{
            //    LowScore_Name = "數學";
            //    LowScore = sc.mathscores;
            //}

            #endregion
            string Compare_result="目前最高成績科目為 : " + HighScore_Name + "  " + HighScore + "分" + Environment.NewLine +"目前最低成績科目為 : " + LowScore_Name + "  " + LowScore + "分";

            label7.Text = Compare_result;

            }

        }
    
}
