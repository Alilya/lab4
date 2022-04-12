using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace lab4 {
    public partial class MainForm : System.Windows.Forms.Form {
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
            Form form = new Form();
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

        private void button2_Click(object sender, EventArgs e) {
            Form form = new Form();
            form.ShowDialog();
            // DataBase dataBase = new DataBase();
            var list = form.Transfer();
            dataBase.Delete(list[1]);
            dataBase.GetAll();
            var data = dataBase.GetAll();
            dataGrid.Rows.Clear();
            foreach (Product s in data) {
                dataGrid.Rows.Add(s.GetStrings());
            }

        }
        private void Highlight() {
            Int32 selectedCellCount = dataGrid.GetCellCount(DataGridViewElementStates.Selected);
            Form form = new Form();
            form.ShowDialog();
            // DataBase dataBase = new DataBase();
            var list = form.Transfer();

            if (selectedCellCount > 0) {
                if (dataGrid.AreAllCellsSelected(true)) {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else {
                    for (int i = 0; i < selectedCellCount; i++) {
                        for (int j = 0; j < selectedCellCount; j++) {
                            //dataGridView1.Rows.RemoveAt(5);
                            //dataGridView1.Rows.Insert(5, ВашDataGridViewRow);
                            //  sb.Append("Row: ");

                            dataGrid.Rows.RemoveAt(dataGrid.SelectedCells[i].RowIndex);
                            dataGrid.Rows.Insert(dataGrid.SelectedCells[i].RowIndex, list[i]);

                            // sb.Append(dataGrid.SelectedCells[i].RowIndex.ToString());
                            // sb.Append(", Column: ");
                            /* dataGrid.Rows.RemoveAt(dataGrid.SelectedCells[j].ColumnIndex);
                             dataGrid.Rows.Insert(dataGrid.SelectedCells[j].ColumnIndex, textBox1.Text);*/

                            // sb.Append(dataGrid.SelectedCells[j].ColumnIndex.ToString());
                            // sb.Append(Environment.NewLine);
                        }
                    }

                    // sb.Append("Total: " + selectedCellCount.ToString());
                    // MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            Highlight();

        }
    }

}

