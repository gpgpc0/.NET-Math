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
        public double AnsF=0,Sheeta=0,AnsI;
        double[] check = { 0, 0, 0, 0 };
        private void hantei()
        {
            unf = false;
            
            try
            {
                Convert.ToSingle(textBox1.Text);
                Convert.ToSingle(textBox2.Text);
                Convert.ToSingle(textBox3.Text);
                Convert.ToSingle(textBox4.Text);
            }
            catch (FormatException)
            {
                unf = true;
            }

            if (unf && ((Regex.IsMatch(textBox1.Text, @"^\d+$") == false)|| (Regex.IsMatch(textBox2.Text, @"^\d+$") == false)|| (Regex.IsMatch(textBox3.Text, @"^\d+$") == false)|| (Regex.IsMatch(textBox4.Text, @"^\d+$") == false)))
            {
                label2.Text = "数字を入力してください";
                return;
            }
            string[] TextFull = new string[4], TextHalf = new string[4];
            TextFull[0] = textBox1.Text;
            TextHalf[0] = Regex.Replace(TextFull[0], "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            TextFull[1] = textBox2.Text;
            TextHalf[1] = Regex.Replace(TextFull[1], "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            TextFull[2] = textBox3.Text;
            TextHalf[2] = Regex.Replace(TextFull[2], "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            TextFull[3] = textBox4.Text;
            TextHalf[3] = Regex.Replace(TextFull[3], "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            for (int i = 0; i < 4; i++)check[i] = Convert.ToDouble(TextHalf[i]);
           
            if ((check[0] == AnsF&&check[1]==AnsI)||(check[2]==AnsF&&check[4]==Sheeta))
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
            else if (radioButton5.Checked == true&&radioButton10.Checked==true&&radioButton11.Checked==true)
            {
                Seisei.ANSWER result = Seisei.RLCTT(0);
                label1.Text = result.siki;
                
            }
            else if (radioButton5.Checked == true&&radioButton10.Checked==true&&radioButton7.Checked==true)
            {
                Seisei.ANSWER result = Seisei.RLCTT(1);
                label1.Text = result.siki;

            }/*
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

        private void yonsoku_Load(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton8.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
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
           public double J;
        }
        private double a, b, c, omega;
        private double Ans;
        private ANSWER A = new ANSWER();
        private string a_string, b_string, c_string, omega_string;
        public void Atai()
        {
            Random random = new Random();
            a_string = "";
            b_string = "";
            c_string = "";
            omega_string = "";
            a = random.Next(1,100);
            b = random.Next(1,100);
            c = random.Next(1, 100);
            omega = random.Next(1, 100);
            a_string = Convert.ToString(a);
            b_string = Convert.ToString(b);
            c_string = Convert.ToString(c);
            omega_string = Convert.ToString(omega);
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
        public ANSWER RLCTT(int flag)
        {
            double tempR = 0;
            ANSWER A = new ANSWER();
            Atai();
            A.siki = "角周波数が" + omega_string + "rad/sであるとき" + a_string + "の抵抗、" + b_string + "mの誘導性の素子と、" + c_string + "μの容量性の素子を直列につないだ。この時の合成インピーダンスを求めよ。";
            b *= 0.001;
            c *= 0.000001;
            tempR = a;
            double tempI = b * omega + c * omega;
            if (flag == 0)
            {
                A.AnswerF = tempR;
                A.J = tempI;
                return A;
            }
            else
            {
                A.AnswerF = CheckK(tempR, tempI);
                A.J=Math.Sqrt(tempR * tempR + tempI * tempI);
                if (A.J == -999999999)
                {
                    return RLCTT(flag);
                }
                else
                {
                    return A;
                }
            }
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
        public double CheckK(double Re,double Im)
        {
            double a = Math.Atan2(Im, Re);
            if ((int)a == a)
            {
                return a;
            }
            else
            {
                return -999999999;
            }
        } 

    }
}