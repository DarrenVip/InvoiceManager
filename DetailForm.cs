using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class DetailForm : Form
    {
        public string FilePath { get; set; }
        public string FileMd5 { get; set; }
        public DetailForm()
        {
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.FilePath)) { 
                
            }
        }
    }
}
