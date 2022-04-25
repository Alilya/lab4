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
    public partial class FormHello : Form {
        public FormHello() {
            InitializeComponent();
        }

        private void FormHello_Load(object sender, EventArgs e) {

        }
        bool hideFormHello = false;

        private void label1_Click(object sender, EventArgs e) {

        }
        private void CheckBoxHello_CheckedChanged(object sender, EventArgs e) {
            hideFormHello = true;
            Close();
        }

        private void CheckBoxHello_Load(object sender, EventArgs e) {
            if (hideFormHello)
                Close();
        }
    }
}
