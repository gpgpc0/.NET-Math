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
using System.Diagnostics;

namespace _34_makibuchi
{
    public partial class Form1 : Form
    {
        private static yonsoku _y;
        private static CreateS _createS;
        private static Form1 _form1;
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 form1
        {
            get
            {
                if(_form1 == null||_form1.IsDisposed) 
                {
                    _form1=new Form1();
                    return _form1;
                }
                return _form1;
            }
        }
        public static yonsoku y
        {
            get
            {
                if(_y == null || _y.IsDisposed)
                {
                    _y=new yonsoku();
                    return _y;
                }
                return _y;
            }
        }
        public static CreateS createS
        {
            get
            {
                if(_createS == null || _createS.IsDisposed)
                {
                    _createS = new CreateS();
                    return _createS;
                }
                return _createS;
            }
        }

        private void 問題作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 四則問題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y.Close();
            if (!this.Equals(y))
            {
                form1.Hide();
                createS.Hide();
                yonsoku.y.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.Equals(form1))
            {
                ホームへ戻るToolStripMenuItem.Enabled = false;
            }
            else
            {
                //ホームへ戻るToolStripMenuItem.Enabled=true;
            }
        }

        private void ホームへ戻るToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.Close();
            if (!this.Equals(form1))
            {
                y.Hide();
                createS.Hide();
                form1.Show();
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
            if (this.Equals(y))
            {
                var dict1 = new Dictionary<string, double>
                {
                    { "Resistance", y.Seisei.a },
                    { "Indactance", y.Seisei.b },
                    { "Capacitance", y.Seisei.c },
                    { "RadFrequency", y.Seisei.omega }
                };
                File.WriteAllText(@".\SavingQuestion\SavingConfig.json", JsonUtil.ToJson(dict1));
            }

        }

        private void 自作問題作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ヘルプToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void このソフトについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createS.Close();
            if (!this.Equals(createS))
            {
                form1.Hide();
                y.Hide();
                CreateS.createS.Show();
            }
        }
    }
}
