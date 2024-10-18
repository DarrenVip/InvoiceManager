namespace InvoiceManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            tsmi_setting = new ToolStripMenuItem();
            tsmi_exit = new ToolStripMenuItem();
            tsmi_about = new ToolStripMenuItem();
            tsmi_help = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            btn_Rename = new Button();
            btn_OK = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            clm_file = new DataGridViewTextBoxColumn();
            clm_amount = new DataGridViewTextBoxColumn();
            clm_day = new DataGridViewTextBoxColumn();
            clm_md5 = new DataGridViewTextBoxColumn();
            cml_finsh = new DataGridViewCheckBoxColumn();
            clm_fullName = new DataGridViewTextBoxColumn();
            btn_Exp = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem, tsmi_about, tsmi_help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1740, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmi_setting, tsmi_exit });
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(62, 28);
            设置ToolStripMenuItem.Text = "文件";
            // 
            // tsmi_setting
            // 
            tsmi_setting.Name = "tsmi_setting";
            tsmi_setting.Size = new Size(146, 34);
            tsmi_setting.Text = "设置";
            tsmi_setting.Click += tsmi_setting_Click;
            // 
            // tsmi_exit
            // 
            tsmi_exit.Name = "tsmi_exit";
            tsmi_exit.Size = new Size(146, 34);
            tsmi_exit.Text = "退出";
            tsmi_exit.Click += tsmi_exit_Click;
            // 
            // tsmi_about
            // 
            tsmi_about.Name = "tsmi_about";
            tsmi_about.Size = new Size(62, 28);
            tsmi_about.Text = "关于";
            tsmi_about.Click += tsmi_about_Click;
            // 
            // tsmi_help
            // 
            tsmi_help.Name = "tsmi_help";
            tsmi_help.Size = new Size(62, 28);
            tsmi_help.Text = "帮助";
            tsmi_help.Click += tsmi_help_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(1740, 961);
            splitContainer1.SplitterDistance = 449;
            splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(449, 961);
            treeView1.TabIndex = 0;
            treeView1.AfterCheck += treeView1_AfterCheck;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Exp);
            groupBox1.Controls.Add(btn_Rename);
            groupBox1.Controls.Add(btn_OK);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 143);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "操作";
            // 
            // btn_Rename
            // 
            btn_Rename.BackColor = SystemColors.Highlight;
            btn_Rename.ForeColor = SystemColors.ButtonHighlight;
            btn_Rename.Location = new Point(790, 73);
            btn_Rename.Name = "btn_Rename";
            btn_Rename.Size = new Size(150, 64);
            btn_Rename.TabIndex = 3;
            btn_Rename.Text = "重命名文件";
            btn_Rename.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            btn_OK.BackColor = SystemColors.Highlight;
            btn_OK.ForeColor = SystemColors.ButtonHighlight;
            btn_OK.Location = new Point(946, 73);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(150, 64);
            btn_OK.TabIndex = 2;
            btn_OK.Text = "识别发票";
            btn_OK.UseVisualStyleBackColor = false;
            btn_OK.Click += btn_OK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "文件数：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(625, 47);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "未报销：";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clm_file, clm_amount, clm_day, clm_md5, cml_finsh, clm_fullName });
            dataGridView2.Location = new Point(0, 185);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1287, 776);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // clm_file
            // 
            clm_file.HeaderText = "文件";
            clm_file.MinimumWidth = 8;
            clm_file.Name = "clm_file";
            clm_file.Width = 600;
            // 
            // clm_amount
            // 
            clm_amount.HeaderText = "发票金额";
            clm_amount.MinimumWidth = 8;
            clm_amount.Name = "clm_amount";
            clm_amount.Width = 150;
            // 
            // clm_day
            // 
            clm_day.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clm_day.HeaderText = "开票日期";
            clm_day.MinimumWidth = 8;
            clm_day.Name = "clm_day";
            clm_day.Width = 150;
            // 
            // clm_md5
            // 
            clm_md5.HeaderText = "MD5";
            clm_md5.MinimumWidth = 8;
            clm_md5.Name = "clm_md5";
            clm_md5.Visible = false;
            clm_md5.Width = 150;
            // 
            // cml_finsh
            // 
            cml_finsh.HeaderText = "是否报销";
            cml_finsh.MinimumWidth = 8;
            cml_finsh.Name = "cml_finsh";
            cml_finsh.ReadOnly = true;
            cml_finsh.Width = 150;
            // 
            // clm_fullName
            // 
            clm_fullName.HeaderText = "路径";
            clm_fullName.MinimumWidth = 8;
            clm_fullName.Name = "clm_fullName";
            clm_fullName.Visible = false;
            clm_fullName.Width = 150;
            // 
            // btn_Exp
            // 
            btn_Exp.BackColor = SystemColors.Highlight;
            btn_Exp.ForeColor = SystemColors.ButtonHighlight;
            btn_Exp.Location = new Point(1102, 73);
            btn_Exp.Name = "btn_Exp";
            btn_Exp.Size = new Size(150, 64);
            btn_Exp.TabIndex = 4;
            btn_Exp.Text = "导出打印";
            btn_Exp.UseVisualStyleBackColor = false;
            btn_Exp.Click += btn_Exp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 993);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "发票管家   http://www.darren.host";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem tsmi_about;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView2;
        private TreeView treeView1;
        private ToolStripMenuItem tsmi_setting;
        private ToolStripMenuItem tsmi_exit;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btn_OK;
        private Button btn_Rename;
        private DataGridViewTextBoxColumn clm_file;
        private DataGridViewTextBoxColumn clm_amount;
        private DataGridViewTextBoxColumn clm_day;
        private DataGridViewTextBoxColumn clm_md5;
        private DataGridViewCheckBoxColumn cml_finsh;
        private DataGridViewTextBoxColumn clm_fullName;
        private ToolStripMenuItem tsmi_help;
        private Button btn_Exp;
    }
}
