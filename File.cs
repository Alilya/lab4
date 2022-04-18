using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab4 {
    internal class File {
        public void SaveData(string[] text) {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл

            for (int i = 0; i < text.Length; i++) {
                System.IO.File.WriteAllText(fileName, text[i]);
            }
           // System.IO.File.WriteAllText(fileName, text);

            MessageBox.Show("Файл сохранен");


        }

    }
}
