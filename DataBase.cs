using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace lab4 {
    public class DataBase {

        private SQLiteConnection connection;
        public DataBase() { }
        SQLiteCommand command;
        static public List<Product> data;
        public void Add(List<string> list) {
            MakeConnaction();
            if (list != null) {
                command = new SQLiteCommand($"INSERT INTO [ProductList] ('Name','Count','Supplier','Date','Price') " +
                    $"VALUES (@Name,@Count,@Supplier,@Date,@Price)", connection);
                command.Parameters.AddWithValue("Name", list[0]);
                command.Parameters.AddWithValue("Count", list[1]);
                command.Parameters.AddWithValue("Supplier", list[2]);
                command.Parameters.AddWithValue("Date", list[3]);
                command.Parameters.AddWithValue("Price", list[4]);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void Change(Product products,/* List<string> oldStr,*/ int index) {
            MakeConnaction();
            command = new SQLiteCommand("Update ProductList Set Name = @Name, Count = @Count, Supplier = @Supplier, Date = @Date, Price = @Price Where Id =@Id", connection);
            command.Parameters.AddWithValue("Id", data[index].Id);
            command.Parameters.AddWithValue("Name", products.Name);
            command.Parameters.AddWithValue("Count", products.Count);
            command.Parameters.AddWithValue("Supplier", products.Supplier);
            command.Parameters.AddWithValue("Date", products.Date);
            command.Parameters.AddWithValue("Price", products.Price);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(List<string> list) {
            MakeConnaction();
            string sql = string.Format("Delete from ProductList where Name = @Name");

            command = new SQLiteCommand("Delete from ProductList where Name = @Name", connection);

            command.Parameters.AddWithValue("Name", list[0]);

            try {
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex) {
                Exception error = new Exception("К сожалению, удалить этот продукт нельзя", ex);
                throw error;
            }

            connection.Close();
        }

        public List<Product> GetAll() {
            MakeConnaction();
            SQLiteCommand command =
              new SQLiteCommand("select * from ProductList;", connection);

            SQLiteDataReader reader = command.ExecuteReader();
            data = new List<Product>();
            while (reader.Read()) {
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
            }
            connection.Close();
            return data;
        }
        public void MakeConnaction() {
            string databaseName = Directory.GetCurrentDirectory().ToString() + "\\DataBase.db";
            connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
        }
    }
}
