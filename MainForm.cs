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
        List<Product> data = new List<Product>();


        private void MainForm_Load(object sender, EventArgs e) {


            //  DataBase dataBase = new DataBase();
            data = dataBase.GetAll();

            foreach (Product s in data) {
                dataGrid.Rows.Add(s.GetStrings());
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            Question form = new Question();
            form.ShowDialog();

            var list = form.Transfer();
            if (list != null) {
                dataBase.Add(list);
                dataBase.GetAll();
                var data = dataBase.GetAll();
                dataGrid.Rows.Clear();
                foreach (Product s in data) {
                    dataGrid.Rows.Add(s.GetStrings());
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            Question form = new Question();
            List<string> list = new List<string> { };
            OK ok = new OK();
            ok.ShowDialog();
            if (ok.Change()) {

                //for (int i = 0; i < dataGrid.CurrentRow.Cells.Count; i++) {
                //list[i] = 
                //dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex];
                //var a = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex];



                list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                list.Add(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[4].Value.ToString());

                dataBase.GetAll();
                dataBase.Delete(list);

                dataGrid.Rows.Remove(dataGrid.CurrentRow);
            }
            else {
                dataBase.GetAll();
            }
            /*  var list = form.Transfer();
              dataBase.Delete(list[1]);
              dataBase.GetAll();
              var data = dataBase.GetAll();
              dataGrid.Rows.Clear();
              foreach (Product s in data) {
                  dataGrid.Rows.Add(s.GetStrings());
              }*/


            //entity1SetTableAdapter.Update(masterDataSet);


        }
        //private SQLiteConnection connection;
        public int GetIndex() {
            return dataGrid.CurrentCellAddress.Y;
        }
        public string GetCullumnName() {
            return dataGrid.Columns[dataGrid.CurrentCell.ColumnIndex].HeaderText.ToString();
        }
       
        private void button3_Click(object sender, EventArgs e) {
            var result=MessageBox.Show("Действительно хотите изменить запись в БД?", "Изменение ячейки", MessageBoxButtons.YesNo);
            ChangeForm form = new ChangeForm();
            DataBase db = new DataBase();
            if (result == DialogResult.Yes) {
                form.ShowDialog();
                var textIndex = GetIndex();
                if (!(form.textForm() == "" || textIndex == 0 || GetCullumnName() == "")) {
                    db.Change(form.textForm(), textIndex, GetCullumnName());
                    var data = dataBase.GetAll();
                    dataGrid.Rows.Clear();
                    foreach (Product s in data) {
                        dataGrid.Rows.Add(s.GetStrings());
                    }
                }
            }
            else {
                form.Close();
            } 
        }
    }

}

