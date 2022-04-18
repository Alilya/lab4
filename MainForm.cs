using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Windows.Documents;


namespace lab4 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

        }
        DataBase dataBase = new DataBase();
        //List<Product> data = new List<Product>();

        private void MainForm_Load(object sender, EventArgs e) {
            var data = dataBase.GetAll();
            foreach (Product s in data) {
                dataGrid.Rows.Add(s.GetStrings());
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            Question form = new Question();
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
            Question form = new Question();
            List<string> list = new List<string> { };
            OK ok = new OK();
            ok.ShowDialog();
            if (ok.Change() && dataGrid.CurrentCell.Value != null) {
                for (int i = 0; i < dataGrid.SelectedCells.Count; i++) {
                    list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[i].Value.ToString());
                    /*list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                    list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                    list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                    list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[4].Value.ToString());*/
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
        public string GetCullumnName() {
            return dataGrid.Columns[dataGrid.CurrentCell.ColumnIndex].HeaderText.ToString();
        }

        private void ButtonChange_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Действительно хотите изменить запись в БД?", "Изменение ячейки", MessageBoxButtons.YesNo);
            ChangeForm form = new ChangeForm();
            DataBase db = new DataBase();
            if (result == DialogResult.Yes) {
                form.ShowDialog();
                var textIndex = GetIndex();
                if (form.textForm() != "") {
                    db.Change(form.textForm(), textIndex, GetCullumnName());
                    var data = dataBase.GetAll();
                    dataGrid.Rows.Clear();
                    foreach (Product s in data) {
                        dataGrid.Rows.Add(s.GetStrings());
                    }
                    db.GetAll();
                }
            }
            else {
                form.Close();
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e) {
           
        }
    }

}

