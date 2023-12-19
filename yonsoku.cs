using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _34_makibuchi
{
    public partial class yonsoku : Form1
    {
        Seisei Seisei=new Seisei();
        public int Ans;
        public yonsoku()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                label1.Text = Seisei.Wa().siki;
                Ans = Seisei.Wa().Answer;
                
            }else if (radioButton2.Checked == true)
            {
                label1.Text = Seisei.Sa().siki;
                Ans = Seisei.Sa().Answer;
            }
            else if (radioButton3.Checked == true)
            {
                label1.Text = Seisei.Seki().siki;
                Ans = Seisei.Seki().Answer;
            }
            else if (radioButton4.Checked == true)
            {
                label1.Text = Seisei.Syou().siki;
                Ans = Seisei.Syou().Answer;
            }
            else if (radioButton5.Checked == true)
            {
                label1.Text = Seisei.Sa().siki;
                Ans = Seisei.Sa().Answer;
            }
            else
            {
                label1.Text = "問題の種類を選択してください";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+$")==false)
            {
                label2.Text = "数字を入力してください";
            }
            string TextFull = textBox1.Text;
            string TextHalf = Regex.Replace(TextFull, "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            if (Convert.ToInt32(TextHalf) == Ans)
            {
                label2.Text = "正解";
            }
            else
            {
                label2.Text = "不正解";
            }
        }
    }

    public class Seisei
    {
        public struct ANSWER
        {
           public  int Answer;
           public  string siki;
        }
        int a, b;
        float Ans;

        string a_string, b_string;
        public void Atai()
        {
            Random random = new Random();
            a = random.Next(100);
            b = random.Next(100);
            a_string = Convert.ToString(a);
            b_string = Convert.ToString(b);
        }
        public ANSWER Wa()
        {
            ANSWER A=new ANSWER();
            A.siki = "(式)" + a_string + "+" + b_string;
            Ans = a + b;
            A.Answer = Check(Ans);
            if (Check(Ans) != -999999999)
            {
                return A;
            }
            else
            {
                Atai();
                return Wa();
            }
        }
        public ANSWER Sa()
        {
            ANSWER A = new ANSWER();
            A.siki = "(式)" + a_string + "-" + b_string;
            Ans = a - b;
            A.Answer = Check(Ans);
            if (Check(Ans) != -999999999)
            {
                return A;
            }
            else
            {
                Atai();
                return Sa();
            }
        }
        public ANSWER Seki()
        {
            ANSWER A = new ANSWER();
            A.siki = "(式)" + a_string + "x" + b_string;
            Ans = a * b;
            A.Answer = Check(Ans);
            if (Check(Ans) != -999999999)
            {
                return A;
            }
            else
            {
                Atai();
                return Seki();
            }
        }
        public ANSWER Syou()
        {
            ANSWER A = new ANSWER();
            A.siki = "(式)" + a_string + "÷" + b_string;
            Ans = a / b;
            A.Answer = Check(Ans);
            if (Check(Ans) != -999999999)
            {
                return A;
            }
            else
            {
                Atai();
                return Syou();
            }
        }
        public int Check(float d)
        {
            if ((int)d == d)
            {
                return (int)d;
            }
            else
            {
                return -999999999;
            }
        }
    }
}
