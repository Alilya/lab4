using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Configuration;

namespace lab4 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

        private void MainForm_Load(object sender, EventArgs e) {
            var data = dataBase.GetAll();
            foreach (Product s in data) {
                dataGrid.Rows.Add(s.GetStrings());
            }
        }
        private void ChangeGreeting(object sender, EventArgs e) {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["showHello"].Value = (!bool.Parse(ConfigurationManager.AppSettings["showHello"])).ToString();
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void ShowHello(object sender, EventArgs e) {
            if (bool.Parse(ConfigurationManager.AppSettings["showHello"])) {
                FormHello formHello = new FormHello();
                formHello.ShowDialog();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            FormChange form = new FormChange();
            form.ShowDialog();

            var list = form.Transfer();

            dataBase.Add(list);
            dataBase.GetAll();
            var data = dataBase.GetAll();
            dataGrid.Rows.Clear();
            foreach (Product s in data) {
                dataGrid.Rows.Add(s.GetStrings());
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            FormChange form = new FormChange();
            List<string> list = new List<string> { };
            Questions ok = new Questions();
            ok.ShowDialog();
            if (ok.Change() && dataGrid.CurrentCell.Value != null) {
                for (int i = 0; i < dataGrid.SelectedCells.Count; i++) {
                    list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[i].Value.ToString());
                }
                dataBase.GetAll();
                dataBase.Delete(list);

                dataGrid.Rows.Remove(dataGrid.CurrentRow);
            }
            else if (dataGrid.CurrentCell.Value == null) {
                MessageBox.Show("Невозможно удалить сущность, значение null");
                dataBase.GetAll();
            }
        }
        public int GetIndex() {
            return dataGrid.CurrentCellAddress.Y;
        }

        private void ButtonChange_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Действительно хотите изменить запись в БД?", "Изменение ячейки", MessageBoxButtons.YesNo);
            FormChange form = new FormChange();
            DataBase db = new DataBase();

            List<string> oldValue = new List<string> { };
            for (int i = 0; i < dataGrid.CurrentRow.Cells.Count; i++) {
                oldValue.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[i].Value.ToString());
            }
            form.ChangeText(oldValue);

            if (result == DialogResult.Yes) {
                form.ShowDialog();
                var textIndex = GetIndex();
                Product productNew = new Product();
                var arr = form.Transfer();
                productNew.Name = arr[0];
                productNew.Count = arr[1];
                productNew.Supplier = arr[2];
                productNew.Date = arr[3];
                productNew.Price = arr[4];

                db.Change(productNew, textIndex);

                var data = dataBase.GetAll();
                dataGrid.Rows.Clear();
                foreach (Product s in data) {
                    dataGrid.Rows.Add(s.GetStrings());
                }
                db.GetAll();

            }
            else {
                form.Close();
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e) {
            File file = new File();
            file.SaveData(DataBase.data);
        }

        private void showGreetingsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            ChangeGreeting(sender, e);
            showGreetingsToolStripMenuItem.Checked = bool.Parse(ConfigurationManager.AppSettings["showHello"]);
        }

        private void programSettingsToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }

}

