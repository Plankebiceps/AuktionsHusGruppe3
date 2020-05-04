using DesktopClientToService.ControlLayer;
using DesktopClientToService.ModelLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopClientToService.PresentationLayer;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace DesktopClientToService.PresentationLayer
{
    public partial class Main : Form {

        ControlAuction auctionController = new ControlAuction();
        private Auction selectedAuction;
        private int selectedAuctionIndex;
        readonly int sleepMs = 4000;

        public Main() {
            InitializeComponent();
        }

        private void TestWinForms_Load(object sender, EventArgs e) {

        }

        //CREATE AUCTION
        private void btnAuction_Click(object sender, EventArgs e) {

            string result = cbResult.Text;
            string productName = txtProdName.Text;
            string productDescription = txtProdDescription.Text;
            bool payment = false;
            DateTime timeLeftDateAndTime = dtpDateTl.Value.Date.Add(dtpClockTl.Value.TimeOfDay);
            DateTime paymentDateAndTime = dtpDatePayD.Value.Date.Add(dtpClockPayD.Value.TimeOfDay);


            if (radioBtnAuction.Checked) {
                payment = true;
            } else if (rbutNotPayed.Checked) {
                payment = false;
            } else if (!radioBtnAuction.Checked && !rbutNotPayed.Checked) {
                MessageBox.Show("Please chose wheter it is payed!");
            }

            bool inputIsOk = (!string.IsNullOrEmpty(result)
                                && !string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(productDescription));

            if (inputIsOk) {
                ControlAuction ctrlAuction = new ControlAuction();
                ctrlAuction.AddAuction(timeLeftDateAndTime, payment, result, paymentDateAndTime, productName, productDescription);
                MessageBox.Show("Auction created!");
            } else {
              MessageBox.Show("Auction not created! Try again.");
            }
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

        // UPDATE AN AUCTION
        private void btnUpdateAuction_Click(object sender, EventArgs e) {
            string result = cbResult.Text;
            string productName = txtProdName.Text;
            string productDescription = txtProdDescription.Text;
            bool payment = false;
            DateTime timeLeftDateAndTime = dtpDateTl.Value.Date.Add(dtpClockTl.Value.TimeOfDay);
            DateTime paymentDateAndTime = dtpDatePayD.Value.Date.Add(dtpClockPayD.Value.TimeOfDay);


            int findAuctionId;
            int.TryParse(txtboxAuctionId.Text, out findAuctionId);

            if (radioBtnAuction.Checked) {
                payment = true;
            } else if (rbutNotPayed.Checked) {
                payment = false;
            } else if (!radioBtnAuction.Checked && !rbutNotPayed.Checked) {
                MessageBox.Show("Please chose wheter it is payed!");
            }

            ControlAuction ctrlAuction = new ControlAuction();
            ctrlAuction.UpdateAuction(findAuctionId, timeLeftDateAndTime, payment, result, paymentDateAndTime, productName, productDescription);
        }

        // LIST ALL AUCTIONS BUTTON
        private void btnAllAuctions_Click(object sender, EventArgs e) {
            listAllAuctions();
        }

        // LIST ALL AUCTIONS METHOD
        private void listAllAuctions() {
            ControlAuction ctrlAuction = new ControlAuction();
            List<Auction> allAuctions = ctrlAuction.GetAllAuctions();

            // CLEAR LIST
            listBoxAuctions.Items.Clear();

            // REFRESH LIST
            foreach (Auction auction in allAuctions) {
                listBoxAuctions.Items.Add(auction);
            }
        }

        // LISTBOX FUNKTIONALITET
        private void listBoxAuctions_SelectedIndexChanged(object sender, EventArgs e) {
            selectedAuction = listBoxAuctions.SelectedItem as Auction;
            selectedAuctionIndex = listBoxAuctions.SelectedIndex;
        }

        // PLACE BID (CUSTOMER)
        //private void btnPlaceBid_Click_1(object sender, EventArgs e) { 

        //    ControlBid ctrlBid = new ControlBid();

        //    int customerId = Login.CustomerActive.Id;
        //    decimal amountToBid;
        //    decimal.TryParse(txtBidAmount.Text, out amountToBid);
        //    bool inputIsOk = !(customerId <= 0 && selectedAuction.AuctionId <= 0 && amountToBid <= 0);  // Mangler ordentlig funktionalitet

        //    if (inputIsOk) {
        //        ctrlBid.PlaceBid(amountToBid, selectedAuction.AuctionId, customerId);
        //        MessageBox.Show("Bid placed on " + selectedAuction.ProductName);
        //    } else {
        //        MessageBox.Show("Something went wrong. Try again!");
        //    }
        //}


        // SHOW BIDS IN LISTBOX
        private void btnShowBids_Click_1(object sender, EventArgs e) {

            ControlBid ctrlBid = new ControlBid();
            List<Bid> allBids = ctrlBid.GetAllBids(selectedAuction.AuctionId);

            // CLEAR LIST
            listBoxBids.Items.Clear();

            // REFRESH LIST
            foreach (Bid bid in allBids) {
                listBoxBids.Items.Add(bid);
            }

        }

        // BUTTON - ASYNCHRONOUS FIND ALL AUCTIONS 
        private async void btnFindAllAucAsync_Click(object sender, EventArgs e) {
            // Display immediately
            this.lblAync2.Text = "Job processing!";
            // Do some work
            var resTask = DoWorkAsync();
            
            ListAllAuctionsAsync();

            var res = await resTask;
            this.lblAync2.Text = res;
        }

        // METHOD - ASYNCHRONOUS FIND ALL AUCTIONS   (OBS. INVOKERS)
        private async Task ListAllAuctionsAsync() {
            await Task.Run(() => {

                ControlAuction ctrlAuction = new ControlAuction();
                List<Auction> allAuctions = ctrlAuction.GetAllAuctions();

                //Clear list
                this.Invoke((MethodInvoker)(() => listBoxAuctions.Items.Clear()));

                // Update list
                foreach (Auction auction in allAuctions) {
                    this.Invoke((MethodInvoker)(() => listBoxAuctions.Items.Add(auction)));
                }          
            });
        }

        // TASK
        private async Task<string> DoWorkAsync() {

            return await Task.Run(() => {
                Thread.Sleep(sleepMs);
                return "Job done!";
            });

        }
    }
}
