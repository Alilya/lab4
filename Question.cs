using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace lab4 {
    public partial class Question : Form {
        public Question() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        public List<string> Transfer() {
            if(!(textName.Text == "" || textCount.Text == "" || textSupplier.Text == "" || textDate.Text == "" || textPrice.Text == "" )){
                List<string> arr = new List<string> { textName.Text, textCount.Text, textSupplier.Text, textDate.Text, textPrice.Text };
                return arr;
            }
            return null;
        }
        private void buttonOk_Click(object sender, EventArgs e) {
            Transfer();
            Close();
        }

        private void textName_TextChanged(object sender, EventArgs e) {
                    
        }
        public string ChangeText(List<string> value) {
            textName.Text = value[0];
            textCount.Text = value[1];
            textSupplier.Text = value[2];
            textDate.Text = value[3];       
            textPrice.Text = value[4];
            List<string> arr = new List<string> { textName.Text, textCount.Text, textSupplier.Text, textDate.Text, textPrice.Text };
            return arr.ToString();
        }

    }
}
