using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4 {
    public partial class ChangeForm : Form {
        public ChangeForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        public string textForm() {
            return textChange.Text;
        }
        private void textChange_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
