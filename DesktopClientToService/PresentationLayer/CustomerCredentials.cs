using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClientToService.PresentationLayer {
    public partial class CustomerCredentials : Form {

        public static string CcFirstName { get; set; }
        public static string CcLastName { get; set; }
        public static string CcAddress { get; set; }

        public CustomerCredentials() {
            InitializeComponent();
        }

        // ASSIGNER INDTASTEDE CREDENTIALS TIL FIELD
        private void btnCcOk_Click(object sender, EventArgs e) {

            CcFirstName = txtCcFirstName.Text;
            CcLastName = txtCcLastName.Text;
            CcAddress = txtCcAddress.Text;

            this.Hide();
        }
    }
}
