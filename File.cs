using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab4 {
    internal class File {
        public void SaveData(List<Product> text) {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog.FileName;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Count; i++) {
                sb.Append(text[i].Id + " ");
                sb.Append(text[i].Name + " ");
                sb.Append(text[i].Supplier + " ");
                sb.Append(text[i].Date + " ");
                sb.Append(text[i].Price + " ");
                sb.Append('\n');
            }
            System.IO.File.WriteAllText(fileName, sb.ToString());
            MessageBox.Show("Файл сохранен");
        }
    }
}
