using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace lab4 {
    public partial class FormChange : Form {
        public FormChange() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        public List<string> Transfer() {
            // textDateTime.CustomFormat = "MMMM dd, yy";
            var textData=textDateTime.Value.ToString("dd/MM/yyyy");
            if (!(textName.Text == "" || textCount.Text == "" || textSupplier.Text == "" || textData == "" || textPrice.Text == "" )){
                List<string> arr = new List<string> { textName.Text, textCount.Text, textSupplier.Text, textData, textPrice.Text };
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
            /* textDateTime.Format = DateTimePickerFormat.Custom;
             textDateTime.CustomFormat = "MMMM dd, yyyy - dddd";*/

          //  var dt = textDateTime.Value.ToString("#dd/MM/yyyy#");
          /*  var dt = textDateTime.Value.ToString();
            dt = value[3];*/

            //   textDateTime.CustomFormat=value[3];
            //textDateTime.Value.ToString() = value[3];

            string[] data = value[3].Split(new char[] { '.' });
            textDateTime.Value = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));
            textPrice.Text = value[4];
            List<string> arr = new List<string> { textName.Text, textCount.Text, textSupplier.Text, textDateTime.Text, textPrice.Text };
            return arr.ToString();
        }

/*        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            //Console.WriteLine(dateTimePicker1.Text);
            textDateTime.CustomFormat = "dd/MM/yyyy";

        }*/

        private void label5_Click(object sender, EventArgs e) {

        }

        private void textCount_TextChanged(object sender, EventArgs e) {
            string nowStr = textCount.Text;
            for (int i = 0; i < nowStr.Length; i++) {
                if (!(((nowStr.ElementAt(i) >= '0') && (nowStr.ElementAt(i) <= '9')) || (nowStr.ElementAt(i) == ' ') || (nowStr.ElementAt(i) == '-'))) {
                    textCount.Text = nowStr.Remove(i, 1);
                    return;
                }
            }
            while (nowStr.Contains("  ")) {
                nowStr = nowStr.Replace("  ", " ");
            }

            textCount.Text = nowStr;
            //dataGrid.Rows.Clear();
            return;
        }

        private void textPrice_TextChanged(object sender, EventArgs e) {
            string nowStr = textPrice.Text;
            for (int i = 0; i < nowStr.Length; i++) {
                if (!(((nowStr.ElementAt(i) >= '0') && (nowStr.ElementAt(i) <= '9')) || (nowStr.ElementAt(i) == ' ') || (nowStr.ElementAt(i) == '-'))) {
                    textPrice.Text = nowStr.Remove(i, 1);
                    return;
                }
            }
            while (nowStr.Contains("  ")) {
                nowStr = nowStr.Replace("  ", " ");
            }

            textPrice.Text = nowStr;
            //dataGrid.Rows.Clear();
            return;
        }
    }
}
