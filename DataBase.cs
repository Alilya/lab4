using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace lab4 {
    public class DataBase {

        private SQLiteConnection connection;
        public DataBase() { }
        SQLiteCommand command;
        public void Add(List<string> list) {
            MakeConnaction();
            //SQLiteCommand command = new SQLiteCommand($"INSERT INTO [ProductList] ('Name','Count','Supplier','Date','Prise') VALUES ({name},{count},{suplier},{date},{prise})", connection);
            command = new SQLiteCommand($"INSERT INTO [ProductList] ('Name','Count','Supplier','Date','Prise') " +
                $"VALUES (@Name,@Count,@Supplier,@Date,@Prise)", connection);

            //SQLiteCommand command = new SQLiteCommand($"INSERT INTO [ProductList] ('Name','Count','Supplier','Date','Prise') VALUES ({textName.Text},{textCount.Text},{textSupplier.Text},{textDate.Text},{textPrise.Text})", connection);
            command.Parameters.AddWithValue("Name", list[0]);
            command.Parameters.AddWithValue("Count", list[1]);
            command.Parameters.AddWithValue("Supplier", list[2]);
            command.Parameters.AddWithValue("Date", list[3]);
            command.Parameters.AddWithValue("Prise", list[4]);

            command.ExecuteNonQuery();
            // GetAll();
            // Change(name,count);
            connection.Close();
        }

        public void Delete(string name) {
            MakeConnaction();
            command = new SQLiteCommand($" DELETE FROM ProductList WHERE Name={name}", connection);
            command.ExecuteNonQuery();
            //GetAll();
            connection.Close();
        }
        public void Change(string newStr, string oldStr) {
           // string queryString = string.Format("UPDATE f SET name = '{0}' WHERE name = '{1}'", newStr, oldStr);
        }
        public List<Product> GetAll() {
            MakeConnaction();
            SQLiteCommand command =
              new SQLiteCommand("select * from ProductList;", connection);
            // connection.Open();

            SQLiteDataReader reader = command.ExecuteReader();
            List<Product> data = new List<Product>();
            while (reader.Read()) {
                // data.Add(new string[reader.FieldCount]); 
                
                for (int i = 0; i < reader.FieldCount; i++) {
                    data.Add(new Product() {
                        Id = reader.GetInt32(i++),
                        Name = reader[i++].ToString(),
                        Count = reader[i++].ToString(),
                        Supplier = reader[i++].ToString(),
                        Date = reader[i++].ToString(),
                        Price = reader[i++].ToString()
                    });
                }

                /*for (int i = 0; i < reader.FieldCount; i++) {
                    data[data.Count - 1][i] = reader[i].ToString();
                }*/

            }

            connection.Close();
            return data;
        }
        private void MakeConnaction() {
            //string databaseName = @"C:\Users\Alina\Desktop\СПБГТИ(ТУ)\4 семестр\РПС\lab4\бд\DataBase.db";
            string databaseName = Directory.GetCurrentDirectory().ToString() + "\\DataBase.db";
            connection =
                new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
        }
    }
}
