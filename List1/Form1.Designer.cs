
namespace List1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.啟動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.輸入表格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.啟動ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 啟動ToolStripMenuItem
            // 
            this.啟動ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.輸入表格ToolStripMenuItem,
            this.計算ToolStripMenuItem});
            this.啟動ToolStripMenuItem.Name = "啟動ToolStripMenuItem";
            this.啟動ToolStripMenuItem.Size = new System.Drawing.Size(81, 38);
            this.啟動ToolStripMenuItem.Text = "啟動";
            // 
            // 輸入表格ToolStripMenuItem
            // 
            this.輸入表格ToolStripMenuItem.Name = "輸入表格ToolStripMenuItem";
            this.輸入表格ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.輸入表格ToolStripMenuItem.Text = "輸入表格";
            this.輸入表格ToolStripMenuItem.Click += new System.EventHandler(this.輸入表格ToolStripMenuItem_Click);
            // 
            // 計算ToolStripMenuItem
            // 
            this.計算ToolStripMenuItem.Enabled = false;
            this.計算ToolStripMenuItem.Name = "計算ToolStripMenuItem";
            this.計算ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.計算ToolStripMenuItem.Text = "計算";
            this.計算ToolStripMenuItem.Click += new System.EventHandler(this.計算ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 啟動ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 輸入表格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 計算ToolStripMenuItem;
    }
}

