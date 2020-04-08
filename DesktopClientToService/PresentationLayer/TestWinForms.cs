using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopClientToService.ControlLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.PresentationLayer
{
    public partial class TestWinForms : Form
    {
        ControlAuction auctionController = new ControlAuction();
        public TestWinForms()
        {
            InitializeComponent();
        }

        private void TestWinForms_Load(object sender, EventArgs e)
        {

        }

        private void btnAuction_Click(object sender, EventArgs e)
        {
            string name = txtProduct__Name.Text;
            string description = txtProduct__Description.Text;
            DateTime dateTime = dateTimePickerAuction.Value; 
            string result = txtAuction_Result.Text;
            bool payment = false;
            decimal timeLeft = -1;
            decimal.TryParse(txtAuction_TimeLeft.Text, out timeLeft);


            if(radioBtnAuction.Checked)
            {
                payment = true;
            }

            //DesktopClientToService.ServiceRefAuction.Product product = new DesktopClientToService.ServiceRefAuction.Product(name, description);            
            //ControlProduct ctrlProduct = new ControlProduct();
            //ctrlProduct.CreateProduct(name, description);


            ControlAuction ctrlAuction = new ControlAuction();
            ctrlAuction.CreateAuction(timeLeft, payment, result, dateTime, product);

        }

    }
}
