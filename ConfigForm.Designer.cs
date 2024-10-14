namespace InvoiceManager
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_browser = new Button();
            btn_ok = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 56);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "工作目录：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 2;
            // 
            // btn_browser
            // 
            btn_browser.Location = new Point(604, 50);
            btn_browser.Name = "btn_browser";
            btn_browser.Size = new Size(98, 34);
            btn_browser.TabIndex = 3;
            btn_browser.Text = "浏览";
            btn_browser.UseVisualStyleBackColor = true;
            btn_browser.Click += btn_browser_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(579, 521);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(163, 53);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "确定";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 134);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 5;
            label2.Text = "ORC密匙：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btn_browser);
            groupBox1.Location = new Point(34, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 225);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "基本设置";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 30);
            textBox2.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(43, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 177);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "ORC 密匙获取";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(687, 125);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "【阿里官方】增值税发票OCR文字识别\n\n  https://market.aliyun.com/apimarket/detail/cmapi027758";
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_ok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfigForm";
            Text = "设置";
            Load += ConfigForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private TextBox textBox1;
        private Button btn_browser;
        private Button btn_ok;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
    }
}