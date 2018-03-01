using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt {
    public partial class FormaRadniNalog : Form {

        public FormaRadniNalog() {
            InitializeComponent();
        }

        public FormaRadniNalog(string text) {
            InitializeComponent();
            this.richTextBox1.Text = text;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.DeselectAll();
        }

        private void FormaRadniNalog_Load(object sender, EventArgs e)
        {

        }
    }
}
