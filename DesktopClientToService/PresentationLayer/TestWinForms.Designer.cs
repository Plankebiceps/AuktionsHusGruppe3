namespace DesktopClientToService.PresentationLayer
{
    partial class TestWinForms
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnAuction = new System.Windows.Forms.Button();
            this.txtAuction_ID = new System.Windows.Forms.TextBox();
            this.txtAuction_TimeLeft = new System.Windows.Forms.TextBox();
            this.txtAuction_Result = new System.Windows.Forms.TextBox();
            this.txtProduct__ID = new System.Windows.Forms.TextBox();
            this.txtProduct__Name = new System.Windows.Forms.TextBox();
            this.txtProduct__Description = new System.Windows.Forms.TextBox();
            this.txtProduct__AuctionID = new System.Windows.Forms.TextBox();
            this.radioBtnAuction = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAuction = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(607, 221);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(102, 30);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "button1";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnAuction
            // 
            this.btnAuction.Location = new System.Drawing.Point(73, 221);
            this.btnAuction.Name = "btnAuction";
            this.btnAuction.Size = new System.Drawing.Size(102, 30);
            this.btnAuction.TabIndex = 1;
            this.btnAuction.Text = "button2";
            this.btnAuction.UseVisualStyleBackColor = true;
            this.btnAuction.Click += new System.EventHandler(this.btnAuction_Click);
            // 
            // txtAuction_ID
            // 
            this.txtAuction_ID.Location = new System.Drawing.Point(12, 12);
            this.txtAuction_ID.Name = "txtAuction_ID";
            this.txtAuction_ID.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_ID.TabIndex = 2;
            // 
            // txtAuction_TimeLeft
            // 
            this.txtAuction_TimeLeft.Location = new System.Drawing.Point(12, 38);
            this.txtAuction_TimeLeft.Name = "txtAuction_TimeLeft";
            this.txtAuction_TimeLeft.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_TimeLeft.TabIndex = 3;
            // 
            // txtAuction_Result
            // 
            this.txtAuction_Result.Location = new System.Drawing.Point(12, 90);
            this.txtAuction_Result.Name = "txtAuction_Result";
            this.txtAuction_Result.Size = new System.Drawing.Size(264, 20);
            this.txtAuction_Result.TabIndex = 5;
            // 
            // txtProduct__ID
            // 
            this.txtProduct__ID.Location = new System.Drawing.Point(524, 12);
            this.txtProduct__ID.Name = "txtProduct__ID";
            this.txtProduct__ID.Size = new System.Drawing.Size(264, 20);
            this.txtProduct__ID.TabIndex = 8;
            // 
            // txtProduct__Name
            // 
            this.txtProduct__Name.Location = new System.Drawing.Point(524, 38);
            this.txtProduct__Name.Name = "txtProduct__Name";
            this.txtProduct__Name.Size = new System.Drawing.Size(264, 20);
            this.txtProduct__Name.TabIndex = 9;
            // 
            // txtProduct__Description
            // 
            this.txtProduct__Description.Location = new System.Drawing.Point(524, 64);
            this.txtProduct__Description.Name = "txtProduct__Description";
            this.txtProduct__Description.Size = new System.Drawing.Size(264, 20);
            this.txtProduct__Description.TabIndex = 10;
            // 
            // txtProduct__AuctionID
            // 
            this.txtProduct__AuctionID.Location = new System.Drawing.Point(524, 90);
            this.txtProduct__AuctionID.Name = "txtProduct__AuctionID";
            this.txtProduct__AuctionID.Size = new System.Drawing.Size(264, 20);
            this.txtProduct__AuctionID.TabIndex = 11;
            // 
            // radioBtnAuction
            // 
            this.radioBtnAuction.AutoSize = true;
            this.radioBtnAuction.Location = new System.Drawing.Point(12, 64);
            this.radioBtnAuction.Name = "radioBtnAuction";
            this.radioBtnAuction.Size = new System.Drawing.Size(52, 17);
            this.radioBtnAuction.TabIndex = 12;
            this.radioBtnAuction.TabStop = true;
            this.radioBtnAuction.Text = "Betalt";
            this.radioBtnAuction.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAuction
            // 
            this.dateTimePickerAuction.Location = new System.Drawing.Point(12, 116);
            this.dateTimePickerAuction.Name = "dateTimePickerAuction";
            this.dateTimePickerAuction.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAuction.TabIndex = 13;
            // 
            // TestWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerAuction);
            this.Controls.Add(this.radioBtnAuction);
            this.Controls.Add(this.txtProduct__AuctionID);
            this.Controls.Add(this.txtProduct__Description);
            this.Controls.Add(this.txtProduct__Name);
            this.Controls.Add(this.txtProduct__ID);
            this.Controls.Add(this.txtAuction_Result);
            this.Controls.Add(this.txtAuction_TimeLeft);
            this.Controls.Add(this.txtAuction_ID);
            this.Controls.Add(this.btnAuction);
            this.Controls.Add(this.btnProduct);
            this.Name = "TestWinForms";
            this.Text = "TestWinForms";
            this.Load += new System.EventHandler(this.TestWinForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnAuction;
        private System.Windows.Forms.TextBox txtAuction_ID;
        private System.Windows.Forms.TextBox txtAuction_TimeLeft;
        private System.Windows.Forms.TextBox txtAuction_Result;
        private System.Windows.Forms.TextBox txtProduct__ID;
        private System.Windows.Forms.TextBox txtProduct__Name;
        private System.Windows.Forms.TextBox txtProduct__Description;
        private System.Windows.Forms.TextBox txtProduct__AuctionID;
        private System.Windows.Forms.RadioButton radioBtnAuction;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuction;
    }
}