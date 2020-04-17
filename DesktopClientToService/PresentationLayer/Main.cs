﻿using DesktopClientToService.ControlLayer;
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



        private void button1_Click(object sender, EventArgs e) {

            int findAuctionId;
            int.TryParse(AuctionIdFinder.Text, out findAuctionId);

            Auction foundAuction = auctionController.GetAuctionById(findAuctionId);
            productName.Text = foundAuction.ProductName;
        }

    }
}