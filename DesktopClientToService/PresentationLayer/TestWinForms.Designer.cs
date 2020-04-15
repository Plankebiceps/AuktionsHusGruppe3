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
            this.btnAuction = new System.Windows.Forms.Button();
            this.txtAuction_ID = new System.Windows.Forms.TextBox();
            this.txtAuction_TimeLeft = new System.Windows.Forms.TextBox();
            this.txtAuction_Result = new System.Windows.Forms.TextBox();
            this.radioBtnAuction = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAuction = new System.Windows.Forms.DateTimePicker();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAuction
            // 
            this.btnAuction.Location = new System.Drawing.Point(344, 310);
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
            this.txtAuction_ID.TextChanged += new System.EventHandler(this.txtAuction_ID_TextChanged);
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
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(12, 156);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(264, 20);
            this.txtProdName.TabIndex = 14;
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(12, 193);
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(264, 20);
            this.txtProdDescription.TabIndex = 15;
            // 
            // TestWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.dateTimePickerAuction);
            this.Controls.Add(this.radioBtnAuction);
            this.Controls.Add(this.txtAuction_Result);
            this.Controls.Add(this.txtAuction_TimeLeft);
            this.Controls.Add(this.txtAuction_ID);
            this.Controls.Add(this.btnAuction);
            this.Name = "TestWinForms";
            this.Text = "TestWinForms";
            this.Load += new System.EventHandler(this.TestWinForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAuction;
        private System.Windows.Forms.TextBox txtAuction_ID;
        private System.Windows.Forms.TextBox txtAuction_TimeLeft;
        private System.Windows.Forms.TextBox txtAuction_Result;
        private System.Windows.Forms.RadioButton radioBtnAuction;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuction;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdDescription;
    }
}