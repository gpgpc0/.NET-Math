using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _34_makibuchi
{
/*関数名:素子直並列表示
         Resistance/Lindactance/Capasitance Tyokuretu/Heiretu Tyokkakuzahyou/Kyokuzahyou
 */

    public partial class yonsoku : Form1
    {
        public Seisei Seisei=new Seisei();
        public int Ans=0;
        public double AnsF=0;
        double check = 0;
        private void hantei()
        {
            unf = false;
            
            try
            {
                Convert.ToSingle(textBox1.Text);
            }
            catch (FormatException)
            {
                unf = true;
            }

            if (unf && (Regex.IsMatch(textBox1.Text, @"^\d+$") == false))
            {
                label2.Text = "数字を入力してください";
                return;
            }
            string TextFull = textBox1.Text;
            string TextHalf = Regex.Replace(TextFull, "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());

            check = Convert.ToDouble(TextHalf);

            if (check == AnsF)
            {
                label2.Text = "正解";
                return;
            }
            else if (AnsF == -999)
            {
                if (Convert.ToInt32(check) == Ans)
                {
                    label2.Text = "正解";
                    return;
                }
                else
                {
                    label2.Text = "不正解";
                    Debug.WriteLine("banana");
                    return;
                }
            }
            else
            {
                Debug.WriteLine("asdfs");
                label2.Text = "不正解";
                return;
            }
        }
        public yonsoku()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true && radioButton10.Checked == true && radioButton11.Checked == true)
            {
                Seisei.ANSWER result = Seisei.RTT();
                label1.Text = result.siki;
                Ans = result.Answer;
                AnsF = -999;
                
            }else if (radioButton1.Checked == true && radioButton9.Checked == true && radioButton11.Checked == true)
            {
                Seisei.ANSWER result = Seisei.RHT();
                label1.Text =result.siki;
                AnsF = result.AnswerF;
            }
            /*else if (radioButton3.Checked == true)
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
            }*/
            else
            {
                label1.Text = "問題の種類を選択してください";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hantei();
        }

        protected bool unf;
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            label3.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = true;
            label5.Enabled = true;
            label8.Enabled = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            label3.Enabled = true;
            label4.Enabled = true;
            label6.Enabled = false;
            label5.Enabled = false;
            label8.Enabled = false;
        }
    }

    public class Seisei
    {
        public struct ANSWER
        {
           public  int Answer;
           public double AnswerF;
           public  string siki;
           public double L;
           public double C;
        }
        private int a, b, c, omega;
        private double Ans;
        private ANSWER A = new ANSWER();
        private string a_string, b_string,omega_string;
        public void Atai()
        {
            Random random = new Random();
            a_string = "";
            b_string = "";
            omega_string = "";
            a = random.Next(1,100);
            b = random.Next(1,100);
            c = random.Next(1, 100);
            omega = random.Next(1, 100);
            a_string = Convert.ToString(a);
            b_string = Convert.ToString(b);
        }
        public ANSWER RTT()
        {
            Atai();
            ANSWER A = new ANSWER();
            A.siki = a_string + "Ωと" + b_string + "Ωを直列につないだ時の合成インピーダンスを求めよ。";
            Ans = a + b;
            A.Answer = Check(Ans);
            A.AnswerF = 0;
            if (Check(Ans) != -999999999)
            {
                return A;
            }
            else
            {
                Atai();
                return RTT();
            }
        }
        
        
        public ANSWER RHT()
        {
            Atai();
            ANSWER A = new ANSWER();
            A.siki = a_string + "Ωと" + b_string + "Ωを並列につないだ時の合成インピーダンスを求めよ。";
            double temp = 1 / ((1 / (double)a) + (1 / (double)b));
            A.AnswerF= (double)Math.Round(temp,2,MidpointRounding.AwayFromZero);
            A.Answer = 0;
            return A;
        }
        public ANSWER RLCTK()
        {
            Atai();
            ANSWER A = new ANSWER();
            return A;
        }
        public int Check(double d)
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