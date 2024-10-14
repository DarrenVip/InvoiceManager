using InvoiceManager.Core;
using System.Collections;
using System.IO;
using System.Runtime;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text;
using System.Text.Json.Nodes;

namespace InvoiceManager
{

    public partial class MainForm : Form
    {
        public static Config config = new Config();

        public static Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

        private string selectedPath = string.Empty;
        public MainForm()
        {
            InitializeComponent();


        }

        private void MainForm_Load(object sender, EventArgs e)
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
                config.BasePath = "D:\\SynologyDrive\\Premin\\发票相关";
                ConfigForm configForm = new ConfigForm();
                DialogResult dialogResult = configForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {

                    MessageBox.Show("设置完成，重新打开软件进入");
                    Application.Exit();
                }
            }

            this.AddFolder(config.BasePath);



        }

        public void AddFolder(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            TreeNode rootNode = treeView1.Nodes.Add(dirInfo.Name);
            AddSubFolders(dirInfo, rootNode);
        }

        private void AddSubFolders(DirectoryInfo parentDir, TreeNode treeNode)
        {
            DirectoryInfo[] subDirs = parentDir.GetDirectories();
            foreach (DirectoryInfo dirInfo in subDirs)
            {
                FileInfo[] files = dirInfo.GetFiles();
                TreeNode node = treeNode.Nodes.Add(string.Format("{0}  ({1})", dirInfo.Name, files.Length));
                node.Tag = dirInfo.FullName;
                AddSubFolders(dirInfo, node);
            }
            AddFinishMap(parentDir);


        }

        private void AddFinishMap(DirectoryInfo path)
        {

            if (path.FullName.IndexOf("已报销") < 0)
            {
                return;
            }

            FileInfo[] files2 = path.GetFiles();
            foreach (FileInfo file in files2)
            {
                string md5 = GetFileMD5(file.FullName);
                if (keyValuePairs.ContainsKey(md5))
                {
                    List<string> list = keyValuePairs[md5];
                    list.Add(file.FullName);
                    keyValuePairs[md5] = list;
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(file.FullName);
                    keyValuePairs.Add(md5, list);
                }

            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {


        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }
            selectedPath = e.Node.Tag.ToString();
            LoadNodeData(selectedPath);
        }


        public void LoadNodeData(string path)
        {
            double total = 0;
            int count = 0;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            dataGridView2.Rows.Clear();
            foreach (FileInfo file in files)
            {
                string md5 = GetFileMD5(file.FullName);
                string jsonFile = Path.Combine(getWorkspase(), md5 + ".json");
                string amount = file.Name.Split("_")[0];
                double number = -1;
                string dateTime = string.Empty;
                if (File.Exists(jsonFile))
                {
                    Hashtable hashtable = getFileData(md5);
                    if (hashtable != null)
                    {
                        amount = "" + hashtable["发票金额"];
                        dateTime = "" + hashtable["开票日期"];
                        number = Double.Parse(amount);
                    }
                }
                else if (Double.TryParse(amount, out number))
                {
                    total += number;
                    count++;
                }


                dataGridView2.Rows.Add(new string[] { file.Name, number > 0 ? amount : "", dateTime, md5, keyValuePairs.ContainsKey(md5).ToString(), file.FullName });


            }


            this.label1.Text = "未报销：" + total;
            this.label2.Text = "发票张数：" + count;

        }

        public string GetFileMD5(string filePath)
        {

            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        byte[] hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLower();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("读取文件失败：" + filePath);
            }
            return string.Empty;

        }

        private void tsmi_setting_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            DialogResult dialogResult = configForm.ShowDialog();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private string getWorkspase()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), ".workspase");
        }

        private Hashtable getFileData(string md5)
        {


            string filePath = Path.Combine(getWorkspase(), md5 + ".json");
            string json = File.ReadAllText(filePath);

            JsonNode jsonNode = JsonObject.Parse(json);
            JsonNode dataNode = jsonNode["data"];
            if (dataNode != null)
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("开票日期", dataNode["开票日期"]);
                hashtable.Add("发票金额", dataNode["发票金额"]);
                hashtable.Add("销售方名称", dataNode["销售方名称"]);
                return hashtable;
            }

            return null;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.btn_OK.Enabled = false;
            if (this.dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewSelectedRowCollection selectedRowCollection = this.dataGridView2.SelectedRows;

                foreach (DataGridViewRow row in selectedRowCollection)
                {
                    try
                    {

                        string md5 = this.dataGridView2.SelectedRows[0].Cells[this.dataGridView2.ColumnCount - 3].Value.ToString();
                        string filePath = this.dataGridView2.SelectedRows[0].Cells[this.dataGridView2.ColumnCount - 1].Value.ToString();

                        string result = new InvoiceAPI(config.AppCode).ORC(filePath);


                        string savePath = getWorkspase();
                        string saveFile = Path.Combine(savePath, md5 + ".json");
                        if (!Directory.Exists(savePath))
                        {
                            Directory.CreateDirectory(savePath);
                        }
                        File.WriteAllText(saveFile, result, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }
                }

                this.LoadNodeData(selectedPath);

            }
            this.btn_OK.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = this.dataGridView2.SelectedRows;

            foreach (DataGridViewRow row in selectedRowCollection)
            {

            }

            this.LoadNodeData(selectedPath);
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("版本：1.0");
            sb.Append(Environment.NewLine);
            sb.Append("作者：").Append("darren.x");
            sb.Append(Environment.NewLine);
            sb.Append("网站：").Append("http://www.darren.host");
            MessageBox.Show(sb.ToString());
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
