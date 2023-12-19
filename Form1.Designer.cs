
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
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.機能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.各種計算機能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.問題作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.四則問題ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角関数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.図形問題ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ホームへ戻るToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.機能ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ホームへ戻るToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編集ToolStripMenuItem.Text = "編集";
            // 
            // 機能ToolStripMenuItem
            // 
            this.機能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.各種計算機能ToolStripMenuItem,
            this.問題作成ToolStripMenuItem});
            this.機能ToolStripMenuItem.Name = "機能ToolStripMenuItem";
            this.機能ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.機能ToolStripMenuItem.Text = "機能";
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // 各種計算機能ToolStripMenuItem
            // 
            this.各種計算機能ToolStripMenuItem.Name = "各種計算機能ToolStripMenuItem";
            this.各種計算機能ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.各種計算機能ToolStripMenuItem.Text = "各種計算機能";
            // 
            // 問題作成ToolStripMenuItem
            // 
            this.問題作成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.四則問題ToolStripMenuItem,
            this.三角関数ToolStripMenuItem,
            this.図形問題ToolStripMenuItem});
            this.問題作成ToolStripMenuItem.Name = "問題作成ToolStripMenuItem";
            this.問題作成ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.問題作成ToolStripMenuItem.Text = "問題生成";
            this.問題作成ToolStripMenuItem.Click += new System.EventHandler(this.問題作成ToolStripMenuItem_Click);
            // 
            // 四則問題ToolStripMenuItem
            // 
            this.四則問題ToolStripMenuItem.Name = "四則問題ToolStripMenuItem";
            this.四則問題ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.四則問題ToolStripMenuItem.Text = "四則問題";
            this.四則問題ToolStripMenuItem.Click += new System.EventHandler(this.四則問題ToolStripMenuItem_Click);
            // 
            // 三角関数ToolStripMenuItem
            // 
            this.三角関数ToolStripMenuItem.Name = "三角関数ToolStripMenuItem";
            this.三角関数ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.三角関数ToolStripMenuItem.Text = "三角関数";
            // 
            // 図形問題ToolStripMenuItem
            // 
            this.図形問題ToolStripMenuItem.Name = "図形問題ToolStripMenuItem";
            this.図形問題ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.図形問題ToolStripMenuItem.Text = "図形問題";
            // 
            // ホームへ戻るToolStripMenuItem
            // 
            this.ホームへ戻るToolStripMenuItem.Name = "ホームへ戻るToolStripMenuItem";
            this.ホームへ戻るToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ホームへ戻るToolStripMenuItem.Text = "ホームへ戻る";
            this.ホームへ戻るToolStripMenuItem.Click += new System.EventHandler(this.ホームへ戻るToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem 各種計算機能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 問題作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 四則問題ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角関数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 図形問題ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ホームへ戻るToolStripMenuItem;
    }
}

