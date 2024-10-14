using InvoiceManager.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class ConfigForm : Form
    {

        private Config config;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            if (File.Exists(Path.Combine(currentDirectory, "config.json")))
            {
                string json = File.ReadAllText(Path.Combine(currentDirectory, "config.json"), Encoding.UTF8);
                config = JsonSerializer.Deserialize<Config>(json);
            }
            else
            {
                config = new Config();
            }
            this.textBox1.Text = config.BasePath;
            this.textBox2.Text = config.AppCode;
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                config.BasePath = folderBrowserDialog1.SelectedPath;
                this.textBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            config.BasePath = this.textBox1.Text.Trim();
            config.AppCode = this.textBox2.Text.Trim();

            string currentDirectory = Directory.GetCurrentDirectory();
            string jsonString = JsonSerializer.Serialize(config);

            File.WriteAllText(Path.Combine(currentDirectory, "config.json"), jsonString);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
