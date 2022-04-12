using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace lab4 {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        public List<string> Transfer() {
            List<string> arr = new List<string> { textName.Text, textCount.Text, textSupplier.Text, textDate.Text, textPrise.Text };
            return arr;
        }
        private void buttonOk_Click(object sender, EventArgs e) {
            Transfer();
            Close();
        }


    }
}
