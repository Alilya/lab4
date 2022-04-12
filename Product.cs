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
            string[] vs = new string[5];
            vs[0] = Name;
            vs[1] = Count;
            vs[2] = Supplier;
            vs[3] = Date;
            vs[4] = Price;
            return vs;
        }
    }
}
