
namespace _34_makibuchi
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データを保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ホームへ戻るToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.機能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.問題作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.四則問題ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自作問題作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.このソフトについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.機能ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データを保存ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // データを保存ToolStripMenuItem
            // 
            this.データを保存ToolStripMenuItem.Name = "データを保存ToolStripMenuItem";
            this.データを保存ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.データを保存ToolStripMenuItem.Text = "現在のデータを保存";
            this.データを保存ToolStripMenuItem.Click += new System.EventHandler(this.データを保存ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ホームへ戻るToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Click += new System.EventHandler(this.編集ToolStripMenuItem_Click);
            // 
            // ホームへ戻るToolStripMenuItem
            // 
            this.ホームへ戻るToolStripMenuItem.Enabled = false;
            this.ホームへ戻るToolStripMenuItem.Name = "ホームへ戻るToolStripMenuItem";
            this.ホームへ戻るToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ホームへ戻るToolStripMenuItem.Text = "ホームへ戻る";
            this.ホームへ戻るToolStripMenuItem.Click += new System.EventHandler(this.ホームへ戻るToolStripMenuItem_Click);
            // 
            // 機能ToolStripMenuItem
            // 
            this.機能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.問題作成ToolStripMenuItem,
            this.自作問題作成ToolStripMenuItem});
            this.機能ToolStripMenuItem.Name = "機能ToolStripMenuItem";
            this.機能ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.機能ToolStripMenuItem.Text = "機能";
            // 
            // 問題作成ToolStripMenuItem
            // 
            this.問題作成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.四則問題ToolStripMenuItem});
            this.問題作成ToolStripMenuItem.Name = "問題作成ToolStripMenuItem";
            this.問題作成ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.問題作成ToolStripMenuItem.Text = "問題生成";
            this.問題作成ToolStripMenuItem.Click += new System.EventHandler(this.問題作成ToolStripMenuItem_Click);
            // 
            // 四則問題ToolStripMenuItem
            // 
            this.四則問題ToolStripMenuItem.Name = "四則問題ToolStripMenuItem";
            this.四則問題ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.四則問題ToolStripMenuItem.Text = "電気回路計算";
            this.四則問題ToolStripMenuItem.Click += new System.EventHandler(this.四則問題ToolStripMenuItem_Click);
            // 
            // 自作問題作成ToolStripMenuItem
            // 
            this.自作問題作成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作成ToolStripMenuItem});
            this.自作問題作成ToolStripMenuItem.Name = "自作問題作成ToolStripMenuItem";
            this.自作問題作成ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.自作問題作成ToolStripMenuItem.Text = "自作問題作成";
            this.自作問題作成ToolStripMenuItem.Click += new System.EventHandler(this.自作問題作成ToolStripMenuItem_Click);
            // 
            // 作成ToolStripMenuItem
            // 
            this.作成ToolStripMenuItem.Name = "作成ToolStripMenuItem";
            this.作成ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.作成ToolStripMenuItem.Text = "作成";
            this.作成ToolStripMenuItem.Click += new System.EventHandler(this.作成ToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.このソフトについてToolStripMenuItem,
            this.ヘルプToolStripMenuItem1});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // このソフトについてToolStripMenuItem
            // 
            this.このソフトについてToolStripMenuItem.Name = "このソフトについてToolStripMenuItem";
            this.このソフトについてToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.このソフトについてToolStripMenuItem.Text = "このソフトについて";
            this.このソフトについてToolStripMenuItem.Click += new System.EventHandler(this.このソフトについてToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem1
            // 
            this.ヘルプToolStripMenuItem1.Name = "ヘルプToolStripMenuItem1";
            this.ヘルプToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ヘルプToolStripMenuItem1.Text = "ヘルプ";
            this.ヘルプToolStripMenuItem1.Click += new System.EventHandler(this.ヘルプToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "電気回路学習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 機能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ホームへ戻るToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データを保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 問題作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 四則問題ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem このソフトについてToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 自作問題作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作成ToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

