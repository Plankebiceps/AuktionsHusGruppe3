using DesktopClientToService.ControlLayer;
using DesktopClientToService.ModelLayer;
using System;
using System.Windows.Forms;

namespace DesktopClientToService.PresentationLayer
{
    public partial class Main : Form
    { 
        ControlAuction auctionController = new ControlAuction();
        public Main()
        {
            InitializeComponent();
        }

        private void TestWinForms_Load(object sender, EventArgs e)
        {

        }

        // CREATE AUCTION
        private void btnAuction_Click(object sender, EventArgs e)
        {
            //Lokal variabler
            DateTime dateTime = dateTimePickerAuction.Value; 
            string result = txtAuction_Result.Text;
            string productName = txtProdName.Text;
            string productDescription = txtProdDescription.Text;
            bool payment = false;
            decimal timeLeft;
            decimal.TryParse(txtAuction_TimeLeft.Text, out timeLeft);

            if(radioBtnAuction.Checked)
            {
                payment = true;
            }
            //----------



            //Funktion
            ControlAuction ctrlAuction = new ControlAuction();
            ctrlAuction.CreateAuction(timeLeft, payment, result, dateTime, productName, productDescription);
        }


        // FIND AUCTION BY ID
        private void button1_Click(object sender, EventArgs e) {

            int findAuctionId;
            int.TryParse(txtboxAuctionId.Text, out findAuctionId);

            Auction foundAuction = auctionController.GetAuctionById(findAuctionId);
            lblProductName.Text = foundAuction.ProductName;
        }


        // DELETE AUCTION
        private void btnDeleteAuction_Click(object sender, EventArgs e) {

            int auctionIdToDelete;
            int.TryParse(txtboxAuctionId.Text, out auctionIdToDelete);
            bool allIsGood = !(auctionIdToDelete <= 0);

            if (allIsGood) {
                ControlAuction ctrlAuction = new ControlAuction();
                ctrlAuction.DeleteAuction(auctionIdToDelete);

                MessageBox.Show("Auction with ID: #" + auctionIdToDelete + " was removed from database!");
            } else {
                MessageBox.Show("The ID was not found - try again!");
            }        
        }


        // RETURN TO LOGIN
        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }


    }
}
