
namespace BookmarksManager
{
    partial class Form_BookMarksManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.view_BookMarks = new System.Windows.Forms.DataGridView();
            this.btn_ImportHTML = new System.Windows.Forms.Button();
            this.btn_ExportHTML = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ImportHTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportHTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_BookMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.view_BookMarks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Exit);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ExportHTML);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ImportHTML);
            this.splitContainer1.Size = new System.Drawing.Size(938, 351);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 2;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportHTMLMenuItem,
            this.ExportHTMLMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 21);
            this.FileMenu.Text = "文件";
            // 
            // view_BookMarks
            // 
            this.view_BookMarks.AllowUserToAddRows = false;
            this.view_BookMarks.AllowUserToResizeRows = false;
            this.view_BookMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_BookMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_BookMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_BookMarks.Location = new System.Drawing.Point(3, 3);
            this.view_BookMarks.MultiSelect = false;
            this.view_BookMarks.Name = "view_BookMarks";
            this.view_BookMarks.ReadOnly = true;
            this.view_BookMarks.RowHeadersVisible = false;
            this.view_BookMarks.RowTemplate.Height = 23;
            this.view_BookMarks.Size = new System.Drawing.Size(932, 305);
            this.view_BookMarks.TabIndex = 0;
            // 
            // btn_ImportHTML
            // 
            this.btn_ImportHTML.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportHTML.Location = new System.Drawing.Point(3, 3);
            this.btn_ImportHTML.Name = "btn_ImportHTML";
            this.btn_ImportHTML.Size = new System.Drawing.Size(90, 30);
            this.btn_ImportHTML.TabIndex = 0;
            this.btn_ImportHTML.Text = "导入HTML";
            this.btn_ImportHTML.UseVisualStyleBackColor = true;
            this.btn_ImportHTML.Click += new System.EventHandler(this.ImportHTML_OnMouseClick);
            // 
            // btn_ExportHTML
            // 
            this.btn_ExportHTML.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ExportHTML.Location = new System.Drawing.Point(99, 3);
            this.btn_ExportHTML.Name = "btn_ExportHTML";
            this.btn_ExportHTML.Size = new System.Drawing.Size(90, 30);
            this.btn_ExportHTML.TabIndex = 1;
            this.btn_ExportHTML.Text = "导出HTML";
            this.btn_ExportHTML.UseVisualStyleBackColor = true;
            this.btn_ExportHTML.Click += new System.EventHandler(this.ExportHTML_OnMouseClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Location = new System.Drawing.Point(862, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(73, 30);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Exit_OnMouseClick);
            // 
            // ImportHTMLMenuItem
            // 
            this.ImportHTMLMenuItem.Name = "ImportHTMLMenuItem";
            this.ImportHTMLMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ImportHTMLMenuItem.Text = "导入HTML";
            this.ImportHTMLMenuItem.Click += new System.EventHandler(this.ImportHTML_OnMouseClick);
            // 
            // ExportHTMLMenuItem
            // 
            this.ExportHTMLMenuItem.Name = "ExportHTMLMenuItem";
            this.ExportHTMLMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExportHTMLMenuItem.Text = "导出HTML";
            this.ExportHTMLMenuItem.Click += new System.EventHandler(this.ExportHTML_OnMouseClick);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "退出软件";
            this.ExitMenuItem.Click += new System.EventHandler(this.Exit_OnMouseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindMenuItem,
            this.AddFolderMenuItem,
            this.BatchMenuItem});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(44, 21);
            this.EditMenu.Text = "编辑";
            // 
            // FindMenuItem
            // 
            this.FindMenuItem.Name = "FindMenuItem";
            this.FindMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FindMenuItem.Text = "查找";
            this.FindMenuItem.Click += new System.EventHandler(this.OnMouseClick404);
            // 
            // AddFolderMenuItem
            // 
            this.AddFolderMenuItem.Name = "AddFolderMenuItem";
            this.AddFolderMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddFolderMenuItem.Text = "添加文件夹";
            this.AddFolderMenuItem.Click += new System.EventHandler(this.OnMouseClick404);
            // 
            // BatchMenuItem
            // 
            this.BatchMenuItem.Name = "BatchMenuItem";
            this.BatchMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BatchMenuItem.Text = "批量操作";
            this.BatchMenuItem.Click += new System.EventHandler(this.OnMouseClick404);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WarnMenuItem,
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 21);
            this.HelpMenu.Text = "帮助";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutMenuItem.Text = "关于";
            this.AboutMenuItem.Click += new System.EventHandler(this.OnMouseClick404);
            // 
            // WarnMenuItem
            // 
            this.WarnMenuItem.Name = "WarnMenuItem";
            this.WarnMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WarnMenuItem.Text = "注意事项";
            this.WarnMenuItem.Click += new System.EventHandler(this.Warn_OnMouseClick);
            // 
            // Form_BookMarksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 381);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(471, 210);
            this.Name = "Form_BookMarksManager";
            this.Text = "BookMarksManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_BookMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView view_BookMarks;
        private System.Windows.Forms.Button btn_ImportHTML;
        private System.Windows.Forms.Button btn_ExportHTML;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem ImportHTMLMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportHTMLMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem FindMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem WarnMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}

