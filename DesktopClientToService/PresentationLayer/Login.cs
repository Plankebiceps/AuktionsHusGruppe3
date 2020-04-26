using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopClientToService.ControlLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.PresentationLayer {
    public partial class Login : Form {

        public static Customer CustomerActive { get; set; }

        public Login() {
            InitializeComponent();
        }

        // LOGIN - ADMIN & CUSTOMER
        private void button1_Click(object sender, EventArgs e) {

            if (rbutAdm.Checked == true) {
                if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text)) {

                    ControlAdmin ctrlAdmin = new ControlAdmin();
                    bool isMatched = ctrlAdmin.LoginAdmin(txtEmail.Text, txtPassword.Text);

                    if (isMatched == true) {
                        MessageBox.Show("Login succeeded!");
                        this.Hide();
                        Main mainForm = new Main();
                        mainForm.Show();

                    } else {
                        MessageBox.Show("Login failed!");
                    }
                }
            }
            if (rbutCust.Checked == true) {
                if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text)) {

                    ControlCustomer ctrlCustomer = new ControlCustomer();
                    bool isMatched = ctrlCustomer.LoginCustomer(txtEmail.Text, txtPassword.Text);  // Verificerer indtastede login-credentials gennem service.

                    if (isMatched == true) {

                        CustomerActive = ctrlCustomer.GetCustomerByEmail(txtEmail.Text); // Se fields. Customer-objekt til brug i Main.cs.

                        MessageBox.Show("Login succeeded!");
                        this.Hide();
                        Main mainForm = new Main();
                        mainForm.Show();

                    } else {
                        MessageBox.Show("Login failed!");
                    }
                }
            }
        }

        // CREATE ACCOUNT - ADMIN & CUSTOMER
        private void btnCreateAcc_Click(object sender, EventArgs e) {

            // Opret admin såfremt radiobutton (rbutAdm) er valgt
            if (rbutAdm.Checked == true) {

                string chosenAdminEmail = txtEmail.Text;
                string chosenAdminPassword = txtPassword.Text;
            
                ControlAdmin ctrlAdmin = new ControlAdmin();
                ctrlAdmin.CreateAdmin(chosenAdminEmail, chosenAdminPassword);

                MessageBox.Show("Admin created succesfully!");
            }

            // Opret customer såfremt radiobutton (rbutCust) er valgt
            if (rbutCust.Checked == true) {

                string chosenFirstName = CustomerCredentials.CcFirstName;
                string chosenLastName = CustomerCredentials.CcLastName;
                string chosenAddress = CustomerCredentials.CcAddress;

                string chosenCustEmail = txtEmail.Text;
                string chosenCustPassword = txtPassword.Text;

                ControlCustomer ctrlCustomer = new ControlCustomer();
                ctrlCustomer.AddCustomer(chosenAddress, chosenFirstName, chosenLastName, chosenCustEmail, chosenCustPassword);

                MessageBox.Show("Customer created succesfully!");
            }
        }
        
        // SKIP LOGIN BUTTON
        private void btnSkipLogin_Click(object sender, EventArgs e) {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        // TO DO : SKAL IKKE AKTIVERES VED KLIK PÅ ADMIN
        private void rbutCust_CheckedChanged(object sender, EventArgs e) {
            CustomerCredentials cc = new CustomerCredentials();
            cc.Show();
        }
    }
}

