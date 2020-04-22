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
using DesktopClientToService.Utilities.Security;

namespace DesktopClientToService.PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
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

                    Admin loginAdmin = null;

                    ControlAdmin ctrlAdmin = new ControlAdmin();
                    loginAdmin = ctrlAdmin.GetAdminByEmail(txtEmail.Text);

                    bool isPasswordMatched = Cryptography.VerifyPassword(txtPassword.Text, loginAdmin.Hash, loginAdmin.Salt);

                    if (isPasswordMatched == true) {
                        MessageBox.Show("Login Succeeded!");
                    } else {
                        MessageBox.Show("Try Again!");
                   
                    }
                }
            }
        }


        private void btnCreateAcc_Click(object sender, EventArgs e) {

            // Opret admin såfremt radiobutton (rbutAdm) er valgt
            if (rbutAdm.Checked == true) {

                string tempEmail = txtEmail.Text;
                string tempPassword = txtPassword.Text;
            
                ControlAdmin ctrlAdmin = new ControlAdmin();
                ctrlAdmin.CreateAdmin(tempEmail, tempPassword);
            
            }
            MessageBox.Show("Admin created succesfully!");

            // Opret customer såfremt radiobutton (rbutCust) er valgt
            if (rbutCust.Checked == true) {

            }

        }
    }
}
