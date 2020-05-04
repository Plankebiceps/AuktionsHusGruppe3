namespace DesktopClientToService.PresentationLayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAuction = new System.Windows.Forms.Button();
            this.radioBtnAuction = new System.Windows.Forms.RadioButton();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxAuctionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteAuction = new System.Windows.Forms.Button();
            this.rbutNotPayed = new System.Windows.Forms.RadioButton();
            this.btnUpdateAuction = new System.Windows.Forms.Button();
            this.listBoxAuctions = new System.Windows.Forms.ListBox();
            this.btnAllAuctions = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.listBoxBids = new System.Windows.Forms.ListBox();
            this.btnShowBids = new System.Windows.Forms.Button();
            this.lblAuctionId = new System.Windows.Forms.Label();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.btnFindAllAucAsync = new System.Windows.Forms.Button();
            this.lblAync2 = new System.Windows.Forms.Label();
            this.dtpDateTl = new System.Windows.Forms.DateTimePicker();
            this.dtpClockTl = new System.Windows.Forms.DateTimePicker();
            this.dtpClockPayD = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePayD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAuction
            // 
            this.btnAuction.Location = new System.Drawing.Point(96, 202);
            this.btnAuction.Name = "btnAuction";
            this.btnAuction.Size = new System.Drawing.Size(127, 23);
            this.btnAuction.TabIndex = 1;
            this.btnAuction.Text = "Create";
            this.btnAuction.UseVisualStyleBackColor = true;
            this.btnAuction.Click += new System.EventHandler(this.btnAuction_Click);
            // 
            // radioBtnAuction
            // 
            this.radioBtnAuction.AutoSize = true;
            this.radioBtnAuction.Location = new System.Drawing.Point(96, 75);
            this.radioBtnAuction.Name = "radioBtnAuction";
            this.radioBtnAuction.Size = new System.Drawing.Size(55, 17);
            this.radioBtnAuction.TabIndex = 12;
            this.radioBtnAuction.TabStop = true;
            this.radioBtnAuction.Text = "Payed";
            this.radioBtnAuction.UseVisualStyleBackColor = true;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(96, 150);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(264, 20);
            this.txtProdName.TabIndex = 14;
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(96, 176);
            this.txtProdDescription.MaxLength = 100;
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(264, 20);
            this.txtProdDescription.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxAuctionId
            // 
            this.txtboxAuctionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAuctionId.Location = new System.Drawing.Point(96, 23);
            this.txtboxAuctionId.Name = "txtboxAuctionId";
            this.txtboxAuctionId.Size = new System.Drawing.Size(160, 20);
            this.txtboxAuctionId.TabIndex = 19;
            this.txtboxAuctionId.Text = "(leave blank upon creation)";
            this.txtboxAuctionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(95, 236);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(264, 33);
            this.lblProductName.TabIndex = 1;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(24, 52);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(57, 13);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.Text = "Total Time";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 101);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(24, 125);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(71, 13);
            this.lblPaymentDate.TabIndex = 24;
            this.lblPaymentDate.Text = "PaymentDate";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(24, 151);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Location = new System.Drawing.Point(24, 179);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(60, 13);
            this.lblProdDesc.TabIndex = 26;
            this.lblProdDesc.Text = "Description";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(969, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAuction
            // 
            this.btnDeleteAuction.Location = new System.Drawing.Point(314, 23);
            this.btnDeleteAuction.Name = "btnDeleteAuction";
            this.btnDeleteAuction.Size = new System.Drawing.Size(46, 21);
            this.btnDeleteAuction.TabIndex = 29;
            this.btnDeleteAuction.Text = "Delete";
            this.btnDeleteAuction.UseVisualStyleBackColor = true;
            this.btnDeleteAuction.Click += new System.EventHandler(this.btnDeleteAuction_Click);
            // 
            // rbutNotPayed
            // 
            this.rbutNotPayed.AutoSize = true;
            this.rbutNotPayed.Location = new System.Drawing.Point(157, 75);
            this.rbutNotPayed.Name = "rbutNotPayed";
            this.rbutNotPayed.Size = new System.Drawing.Size(75, 17);
            this.rbutNotPayed.TabIndex = 30;
            this.rbutNotPayed.TabStop = true;
            this.rbutNotPayed.Text = "Not Payed";
            this.rbutNotPayed.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAuction
            // 
            this.btnUpdateAuction.Location = new System.Drawing.Point(233, 202);
            this.btnUpdateAuction.Name = "btnUpdateAuction";
            this.btnUpdateAuction.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateAuction.TabIndex = 31;
            this.btnUpdateAuction.Text = "Update";
            this.btnUpdateAuction.UseVisualStyleBackColor = true;
            this.btnUpdateAuction.Click += new System.EventHandler(this.btnUpdateAuction_Click);
            // 
            // listBoxAuctions
            // 
            this.listBoxAuctions.FormattingEnabled = true;
            this.listBoxAuctions.Location = new System.Drawing.Point(410, 23);
            this.listBoxAuctions.Name = "listBoxAuctions";
            this.listBoxAuctions.Size = new System.Drawing.Size(310, 173);
            this.listBoxAuctions.TabIndex = 32;
            this.listBoxAuctions.SelectedIndexChanged += new System.EventHandler(this.listBoxAuctions_SelectedIndexChanged);
            // 
            // btnAllAuctions
            // 
            this.btnAllAuctions.Location = new System.Drawing.Point(410, 202);
            this.btnAllAuctions.Name = "btnAllAuctions";
            this.btnAllAuctions.Size = new System.Drawing.Size(174, 23);
            this.btnAllAuctions.TabIndex = 33;
            this.btnAllAuctions.Text = "Find All Auctions";
            this.btnAllAuctions.UseVisualStyleBackColor = true;
            this.btnAllAuctions.Click += new System.EventHandler(this.btnAllAuctions_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(24, 77);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(48, 13);
            this.lblPayment.TabIndex = 37;
            this.lblPayment.Text = "Payment";
            // 
            // listBoxBids
            // 
            this.listBoxBids.FormattingEnabled = true;
            this.listBoxBids.Location = new System.Drawing.Point(738, 23);
            this.listBoxBids.Name = "listBoxBids";
            this.listBoxBids.Size = new System.Drawing.Size(310, 173);
            this.listBoxBids.TabIndex = 38;
            // 
            // btnShowBids
            // 
            this.btnShowBids.Location = new System.Drawing.Point(738, 202);
            this.btnShowBids.Name = "btnShowBids";
            this.btnShowBids.Size = new System.Drawing.Size(174, 23);
            this.btnShowBids.TabIndex = 39;
            this.btnShowBids.Text = "Show Bids";
            this.btnShowBids.UseVisualStyleBackColor = true;
            this.btnShowBids.Click += new System.EventHandler(this.btnShowBids_Click_1);
            // 
            // lblAuctionId
            // 
            this.lblAuctionId.AutoSize = true;
            this.lblAuctionId.Location = new System.Drawing.Point(27, 27);
            this.lblAuctionId.Name = "lblAuctionId";
            this.lblAuctionId.Size = new System.Drawing.Size(18, 13);
            this.lblAuctionId.TabIndex = 40;
            this.lblAuctionId.Text = "ID";
            // 
            // cbResult
            // 
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cbResult.Location = new System.Drawing.Point(96, 98);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(264, 21);
            this.cbResult.TabIndex = 41;
            // 
            // btnFindAllAucAsync
            // 
            this.btnFindAllAucAsync.Location = new System.Drawing.Point(410, 231);
            this.btnFindAllAucAsync.Name = "btnFindAllAucAsync";
            this.btnFindAllAucAsync.Size = new System.Drawing.Size(174, 23);
            this.btnFindAllAucAsync.TabIndex = 42;
            this.btnFindAllAucAsync.Text = "Find All Auctions (Async)";
            this.btnFindAllAucAsync.UseVisualStyleBackColor = true;
            this.btnFindAllAucAsync.Click += new System.EventHandler(this.btnFindAllAucAsync_Click);
            // 
            // lblAync2
            // 
            this.lblAync2.Location = new System.Drawing.Point(410, 261);
            this.lblAync2.Name = "lblAync2";
            this.lblAync2.Size = new System.Drawing.Size(264, 23);
            this.lblAync2.TabIndex = 44;
            // 
            // dtpDateTl
            // 
            this.dtpDateTl.Location = new System.Drawing.Point(95, 50);
            this.dtpDateTl.Name = "dtpDateTl";
            this.dtpDateTl.Size = new System.Drawing.Size(128, 20);
            this.dtpDateTl.TabIndex = 45;
            // 
            // dtpClockTl
            // 
            this.dtpClockTl.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockTl.Location = new System.Drawing.Point(233, 50);
            this.dtpClockTl.Name = "dtpClockTl";
            this.dtpClockTl.Size = new System.Drawing.Size(128, 20);
            this.dtpClockTl.TabIndex = 46;
            // 
            // dtpClockPayD
            // 
            this.dtpClockPayD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockPayD.Location = new System.Drawing.Point(233, 125);
            this.dtpClockPayD.Name = "dtpClockPayD";
            this.dtpClockPayD.Size = new System.Drawing.Size(128, 20);
            this.dtpClockPayD.TabIndex = 48;
            // 
            // dtpDatePayD
            // 
            this.dtpDatePayD.Location = new System.Drawing.Point(95, 125);
            this.dtpDatePayD.Name = "dtpDatePayD";
            this.dtpDatePayD.Size = new System.Drawing.Size(128, 20);
            this.dtpDatePayD.TabIndex = 47;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 313);
            this.Controls.Add(this.dtpClockPayD);
            this.Controls.Add(this.dtpDatePayD);
            this.Controls.Add(this.dtpClockTl);
            this.Controls.Add(this.dtpDateTl);
            this.Controls.Add(this.lblAync2);
            this.Controls.Add(this.btnFindAllAucAsync);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.lblAuctionId);
            this.Controls.Add(this.btnShowBids);
            this.Controls.Add(this.listBoxBids);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnAllAuctions);
            this.Controls.Add(this.listBoxAuctions);
            this.Controls.Add(this.btnUpdateAuction);
            this.Controls.Add(this.rbutNotPayed);
            this.Controls.Add(this.btnDeleteAuction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAuctionId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.radioBtnAuction);
            this.Controls.Add(this.btnAuction);
            this.Name = "Main";
            this.Text = "Auctioneer";
            this.Load += new System.EventHandler(this.TestWinForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAuction;
        private System.Windows.Forms.RadioButton radioBtnAuction;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxAuctionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteAuction;
        private System.Windows.Forms.RadioButton rbutNotPayed;
        private System.Windows.Forms.Button btnUpdateAuction;
        private System.Windows.Forms.ListBox listBoxAuctions;
        private System.Windows.Forms.Button btnAllAuctions;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ListBox listBoxBids;
        private System.Windows.Forms.Button btnShowBids;
        private System.Windows.Forms.Label lblAuctionId;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.Button btnFindAllAucAsync;
        private System.Windows.Forms.Label lblAync2;
        private System.Windows.Forms.DateTimePicker dtpDateTl;
        private System.Windows.Forms.DateTimePicker dtpClockTl;
        private System.Windows.Forms.DateTimePicker dtpClockPayD;
        private System.Windows.Forms.DateTimePicker dtpDatePayD;
    }
}