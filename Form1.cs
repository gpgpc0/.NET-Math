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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _34_makibuchi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void 問題作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 四則問題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            yonsoku.Yonsoku.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ホームへ戻るToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.Visible = true;
            if(this.Name!="Form1")Close();
        }
        private static yonsoku yonsoku;
        
        public static yonsoku Yonsoku
        {
              get
              {
                if (yonsoku == null || yonsoku.IsDisposed)
                {
                     yonsoku = new yonsoku();
                 }
                 return yonsoku;
              }
         }
        private static Form1 _Form1;
        public static Form1 form1
        {
            get
            {
                if (_Form1 == null || _Form1.IsDisposed)
                {
                    _Form1 = new Form1();
                }
                return _Form1;
            }
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void データを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void データを保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Name == "yonsoku")
            {
                var dict1 = new Dictionary<string, double>
                {
                    { "Resistance", yonsoku.Seisei.a },
                    { "Indactance", yonsoku.Seisei.b },
                    { "Capacitance", yonsoku.Seisei.c },
                    { "RadFrequency", yonsoku.Seisei.omega }
                };
                File.WriteAllText(@".\SavingQuestion\SavingConfig.json", JsonUtil.ToJson(dict1));
            }

        }

        private void 自作問題作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
