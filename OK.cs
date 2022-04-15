using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4 {
    public partial class OK : Form {
        public OK() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
        bool clickYes = false;
        bool clickNo = false;
        public bool Change() {
            if (clickNo == true) {
                return false;
            }
            else if (clickYes == true) {
                return true;
            }
            return false;
        }
        
        private void buttonYes_Click(object sender, EventArgs e) {
            clickYes = true;
            Change();
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e) {
            clickNo = true;
            Change();
            Close ();
        }
    }
}
