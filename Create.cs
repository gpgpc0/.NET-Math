using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace _34_makibuchi
{
    public partial class Create : Form1
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dict1 = new Dictionary<string, double>();
            dict1.Add("Resistance", Convert.ToDouble(textBox1.Text));
            dict1.Add("Indactance",Convert.ToDouble(textBox2.Text));
            dict1.Add("Capacitance",Convert.ToDouble(textBox3.Text));
            dict1.Add("RadFrequency", Convert.ToDouble(textBox4.Text));
            File.WriteAllText(@".\UserQuestion\" + textBox5.Text + ".json", JsonUtil.ToJson(dict1));
        }
    }
}
