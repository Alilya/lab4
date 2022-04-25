using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public string Supplier { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }
        public  string[]  GetStrings() {
            string[] arr = new string[5];
            arr[0] = Name;
            arr[1] = Count;
            arr[2] = Supplier;
            arr[3] = Date;
            arr[4] = Price;
            return arr;
        }
    }
}
