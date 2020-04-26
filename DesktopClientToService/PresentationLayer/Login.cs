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

        //public static string EmailToPassOn { get; set; }
        public static Customer CustomerActive { get; set; }

        public Login() {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{


        //    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Integrated Security = True"); //Laver en forbindelse.
        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + txtEmail.Text + "' AND password='" + txtPassword.Text + "'", con);

        //    //De øvre linjer i programmet vælger hele dataen fra tabellen og de sammenhørende med bruger navn og bruger kode som er lavet af brugeren.

        //    DataTable dt = new DataTable(); //Dette laver en virtual tabel.
        //    sda.Fill(dt);
        //    if (dt.Rows[0][0].ToString() == "1") {
        //        // Hvis koden er rigtig, burde login vinduet forsvinde, og et nyt vindue som hedder "TestWinForms" burde komme.
        //        this.Hide();
        //        Main loggedIn = new Main();
        //        loggedIn.Show();
        //    } else {
        //        MessageBox.Show("Invalid username and / or password");
        //    }

        //}


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
                    bool isMatched = ctrlCustomer.LoginCustomer(txtEmail.Text, txtPassword.Text);

                    if (isMatched == true) {
                        CustomerActive = ctrlCustomer.GetCustomerByEmail(txtEmail.Text);
                        //EmailToPassOn = txtEmail.Text;
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

                string chosenCustEmail = txtEmail.Text;
                string chosenCustPassword = txtPassword.Text;

                ControlCustomer ctrlCustomer = new ControlCustomer();
                ctrlCustomer.AddCustomer("testmand", "testersen", "testvej 1, 6666 testby", chosenCustEmail, chosenCustPassword);

                MessageBox.Show("Customer created succesfully!");
            }
        }
        

        private void btnSkipLogin_Click(object sender, EventArgs e) {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void rbutCust_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbutAdm_CheckedChanged(object sender, EventArgs e) {

        }
    }
}

