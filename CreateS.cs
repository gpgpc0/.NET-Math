using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _34_makibuchi
{
    public partial class CreateS : Form1
    {
        public CreateS()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!((Regex.IsMatch(textBox1.Text, @"^\d+$") == false) || (Regex.IsMatch(textBox2.Text, @"^\d+$") == false) || (Regex.IsMatch(textBox3.Text, @"^\d+$") == false) || (Regex.IsMatch(textBox4.Text, @"^\d+$") == false)|| (Regex.IsMatch(textBox5.Text, @"^\d+$") == false)))
            {
                var dict1 = new Dictionary<string, double>
            {
                { "Resistance", Convert.ToDouble(textBox1.Text) },
                { "Indactance", Convert.ToDouble(textBox2.Text) },
                { "Capacitance", Convert.ToDouble(textBox3.Text) },
                { "RadFrequency", Convert.ToDouble(textBox4.Text) }
            };
                File.WriteAllText(@".\UserQuestion\" + textBox5.Text + ".json", JsonUtil.ToJson(dict1));
            }
            else
            {
                textBox1.Text = "数字を入力してください";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
