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
            this.AuctionIdFinder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAuctionDate = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.lblFindById = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuction
            // 
            this.btnAuction.Location = new System.Drawing.Point(132, 194);
            this.btnAuction.Name = "btnAuction";
            this.btnAuction.Size = new System.Drawing.Size(102, 30);
            this.btnAuction.TabIndex = 1;
            this.btnAuction.Text = "Create";
            this.btnAuction.UseVisualStyleBackColor = true;
            this.btnAuction.Click += new System.EventHandler(this.btnAuction_Click);
            // 
            // txtAuction_TimeLeft
            // 
            this.txtAuction_TimeLeft.Location = new System.Drawing.Point(132, 38);
            this.txtAuction_TimeLeft.Name = "txtAuction_TimeLeft";
            this.txtAuction_TimeLeft.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_TimeLeft.TabIndex = 3;
            // 
            // txtAuction_Result
            // 
            this.txtAuction_Result.Location = new System.Drawing.Point(132, 90);
            this.txtAuction_Result.Name = "txtAuction_Result";
            this.txtAuction_Result.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_Result.TabIndex = 5;
            // 
            // radioBtnAuction
            // 
            this.radioBtnAuction.AutoSize = true;
            this.radioBtnAuction.Location = new System.Drawing.Point(132, 64);
            this.radioBtnAuction.Name = "radioBtnAuction";
            this.radioBtnAuction.Size = new System.Drawing.Size(55, 17);
            this.radioBtnAuction.TabIndex = 12;
            this.radioBtnAuction.TabStop = true;
            this.radioBtnAuction.Text = "Payed";
            this.radioBtnAuction.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAuction
            // 
            this.dateTimePickerAuction.Location = new System.Drawing.Point(132, 116);
            this.dateTimePickerAuction.Name = "dateTimePickerAuction";
            this.dateTimePickerAuction.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAuction.TabIndex = 13;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(132, 142);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(264, 20);
            this.txtProdName.TabIndex = 14;
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(132, 168);
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(264, 20);
            this.txtProdDescription.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuctionIdFinder
            // 
            this.AuctionIdFinder.Location = new System.Drawing.Point(132, 299);
            this.AuctionIdFinder.Name = "AuctionIdFinder";
            this.AuctionIdFinder.Size = new System.Drawing.Size(100, 20);
            this.AuctionIdFinder.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(129, 368);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(168, 60);
            this.productName.TabIndex = 1;
            this.productName.Text = "product will show up here";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(62, 38);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(30, 13);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.Text = "Time";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(62, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result";
            // 
            // lblAuctionDate
            // 
            this.lblAuctionDate.AutoSize = true;
            this.lblAuctionDate.Location = new System.Drawing.Point(62, 116);
            this.lblAuctionDate.Name = "lblAuctionDate";
            this.lblAuctionDate.Size = new System.Drawing.Size(30, 13);
            this.lblAuctionDate.TabIndex = 24;
            this.lblAuctionDate.Text = "Date";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(62, 142);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Location = new System.Drawing.Point(62, 168);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(60, 13);
            this.lblProdDesc.TabIndex = 26;
            this.lblProdDesc.Text = "Description";
            // 
            // lblFindById
            // 
            this.lblFindById.AutoSize = true;
            this.lblFindById.Location = new System.Drawing.Point(62, 299);
            this.lblFindById.Name = "lblFindById";
            this.lblFindById.Size = new System.Drawing.Size(55, 13);
            this.lblFindById.TabIndex = 27;
            this.lblFindById.Text = "Find by ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(678, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 30);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Return to Login";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFindById);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblAuctionDate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuctionIdFinder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.dateTimePickerAuction);
            this.Controls.Add(this.radioBtnAuction);
            this.Controls.Add(this.txtAuction_Result);
            this.Controls.Add(this.txtAuction_TimeLeft);
            this.Controls.Add(this.btnAuction);
            this.Name = "Main";
            this.Text = "TestWinForms";
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
        private System.Windows.Forms.TextBox AuctionIdFinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAuctionDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Label lblFindById;
        private System.Windows.Forms.Button btnExit;
    }
}