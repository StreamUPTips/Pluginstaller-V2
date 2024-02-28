using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streamup_Pluginstall_V2 {
    public partial class TermsAndConditions : Form {
        public TermsAndConditions() {
            InitializeComponent();
        }

        private void buttonAgree_Click(object sender, EventArgs e) {
            if (checkBoxDontShowAgain.Checked ) {
                Properties.Settings.Default["agreedDontShowAgain"] = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
