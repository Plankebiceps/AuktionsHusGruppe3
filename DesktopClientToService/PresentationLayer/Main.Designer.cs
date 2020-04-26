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
            this.txtAuction_TimeLeft = new System.Windows.Forms.TextBox();
            this.txtAuction_Result = new System.Windows.Forms.TextBox();
            this.radioBtnAuction = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAuction = new System.Windows.Forms.DateTimePicker();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxAuctionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAuctionDate = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteAuction = new System.Windows.Forms.Button();
            this.rbutNotPayed = new System.Windows.Forms.RadioButton();
            this.btnUpdateAuction = new System.Windows.Forms.Button();
            this.listBoxAuctions = new System.Windows.Forms.ListBox();
            this.btnAllAuctions = new System.Windows.Forms.Button();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAuction
            // 
            this.btnAuction.Location = new System.Drawing.Point(96, 202);
            this.btnAuction.Name = "btnAuction";
            this.btnAuction.Size = new System.Drawing.Size(131, 23);
            this.btnAuction.TabIndex = 1;
            this.btnAuction.Text = "Create";
            this.btnAuction.UseVisualStyleBackColor = true;
            this.btnAuction.Click += new System.EventHandler(this.btnAuction_Click);
            // 
            // txtAuction_TimeLeft
            // 
            this.txtAuction_TimeLeft.Location = new System.Drawing.Point(96, 49);
            this.txtAuction_TimeLeft.Name = "txtAuction_TimeLeft";
            this.txtAuction_TimeLeft.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_TimeLeft.TabIndex = 3;
            // 
            // txtAuction_Result
            // 
            this.txtAuction_Result.Location = new System.Drawing.Point(96, 98);
            this.txtAuction_Result.MaxLength = 6;
            this.txtAuction_Result.Name = "txtAuction_Result";
            this.txtAuction_Result.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_Result.TabIndex = 5;
            this.txtAuction_Result.Text = "Open/Closed";
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
            // dateTimePickerAuction
            // 
            this.dateTimePickerAuction.Location = new System.Drawing.Point(96, 124);
            this.dateTimePickerAuction.Name = "dateTimePickerAuction";
            this.dateTimePickerAuction.Size = new System.Drawing.Size(264, 20);
            this.dateTimePickerAuction.TabIndex = 13;
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
            this.button1.Location = new System.Drawing.Point(96, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxAuctionId
            // 
            this.txtboxAuctionId.Location = new System.Drawing.Point(96, 251);
            this.txtboxAuctionId.Name = "txtboxAuctionId";
            this.txtboxAuctionId.Size = new System.Drawing.Size(100, 20);
            this.txtboxAuctionId.TabIndex = 19;
            this.txtboxAuctionId.Text = "Auction ID";
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
            this.lblProductName.Location = new System.Drawing.Point(93, 310);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(267, 33);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "product will show up here";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(26, 52);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(57, 13);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.Text = "Total Time";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(26, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result";
            // 
            // lblAuctionDate
            // 
            this.lblAuctionDate.AutoSize = true;
            this.lblAuctionDate.Location = new System.Drawing.Point(26, 105);
            this.lblAuctionDate.Name = "lblAuctionDate";
            this.lblAuctionDate.Size = new System.Drawing.Size(55, 13);
            this.lblAuctionDate.TabIndex = 24;
            this.lblAuctionDate.Text = "Start Date";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(26, 132);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Location = new System.Drawing.Point(26, 158);
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
            this.btnExit.Location = new System.Drawing.Point(724, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 21);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAuction
            // 
            this.btnDeleteAuction.Location = new System.Drawing.Point(139, 277);
            this.btnDeleteAuction.Name = "btnDeleteAuction";
            this.btnDeleteAuction.Size = new System.Drawing.Size(57, 21);
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
            this.btnUpdateAuction.Location = new System.Drawing.Point(229, 202);
            this.btnUpdateAuction.Name = "btnUpdateAuction";
            this.btnUpdateAuction.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateAuction.TabIndex = 31;
            this.btnUpdateAuction.Text = "Update";
            this.btnUpdateAuction.UseVisualStyleBackColor = true;
            this.btnUpdateAuction.Click += new System.EventHandler(this.btnUpdateAuction_Click);
            // 
            // listBoxAuctions
            // 
            this.listBoxAuctions.FormattingEnabled = true;
            this.listBoxAuctions.Location = new System.Drawing.Point(437, 49);
            this.listBoxAuctions.Name = "listBoxAuctions";
            this.listBoxAuctions.Size = new System.Drawing.Size(310, 186);
            this.listBoxAuctions.TabIndex = 32;
            this.listBoxAuctions.SelectedIndexChanged += new System.EventHandler(this.listBoxAuctions_SelectedIndexChanged);
            // 
            // btnAllAuctions
            // 
            this.btnAllAuctions.Location = new System.Drawing.Point(437, 241);
            this.btnAllAuctions.Name = "btnAllAuctions";
            this.btnAllAuctions.Size = new System.Drawing.Size(174, 23);
            this.btnAllAuctions.TabIndex = 33;
            this.btnAllAuctions.Text = "Find All Auctions";
            this.btnAllAuctions.UseVisualStyleBackColor = true;
            this.btnAllAuctions.Click += new System.EventHandler(this.btnAllAuctions_Click);
            // 
            // btnPlaceBid
            // 
            this.btnPlaceBid.Location = new System.Drawing.Point(617, 269);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(130, 23);
            this.btnPlaceBid.TabIndex = 35;
            this.btnPlaceBid.Text = "Place Bid";
            this.btnPlaceBid.UseVisualStyleBackColor = true;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click_1);
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(617, 243);
            this.txtBidAmount.MaxLength = 18;
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(130, 20);
            this.txtBidAmount.TabIndex = 36;
            this.txtBidAmount.Text = "Amount";
            this.txtBidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 357);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.btnPlaceBid);
            this.Controls.Add(this.btnAllAuctions);
            this.Controls.Add(this.listBoxAuctions);
            this.Controls.Add(this.btnUpdateAuction);
            this.Controls.Add(this.rbutNotPayed);
            this.Controls.Add(this.btnDeleteAuction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblAuctionDate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAuctionId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.dateTimePickerAuction);
            this.Controls.Add(this.radioBtnAuction);
            this.Controls.Add(this.txtAuction_Result);
            this.Controls.Add(this.txtAuction_TimeLeft);
            this.Controls.Add(this.btnAuction);
            this.Name = "Main";
            this.Text = "Auctioneer";
            this.Load += new System.EventHandler(this.TestWinForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAuction;
        private System.Windows.Forms.TextBox txtAuction_TimeLeft;
        private System.Windows.Forms.TextBox txtAuction_Result;
        private System.Windows.Forms.RadioButton radioBtnAuction;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuction;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxAuctionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAuctionDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteAuction;
        private System.Windows.Forms.RadioButton rbutNotPayed;
        private System.Windows.Forms.Button btnUpdateAuction;
        private System.Windows.Forms.ListBox listBoxAuctions;
        private System.Windows.Forms.Button btnAllAuctions;
        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.TextBox txtBidAmount;
    }
}