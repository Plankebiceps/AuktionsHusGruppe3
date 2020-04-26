namespace DesktopClientToService.PresentationLayer {
    partial class CustomerCredentials {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCcFirstName = new System.Windows.Forms.Label();
            this.txtCcFirstName = new System.Windows.Forms.TextBox();
            this.btnCcOk = new System.Windows.Forms.Button();
            this.lblCcLastName = new System.Windows.Forms.Label();
            this.txtCcLastName = new System.Windows.Forms.TextBox();
            this.lblCcAddress = new System.Windows.Forms.Label();
            this.txtCcAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCcFirstName
            // 
            this.lblCcFirstName.AutoSize = true;
            this.lblCcFirstName.Location = new System.Drawing.Point(46, 64);
            this.lblCcFirstName.Name = "lblCcFirstName";
            this.lblCcFirstName.Size = new System.Drawing.Size(52, 13);
            this.lblCcFirstName.TabIndex = 25;
            this.lblCcFirstName.Text = "Firstname";
            // 
            // txtCcFirstName
            // 
            this.txtCcFirstName.Location = new System.Drawing.Point(116, 61);
            this.txtCcFirstName.Name = "txtCcFirstName";
            this.txtCcFirstName.Size = new System.Drawing.Size(264, 20);
            this.txtCcFirstName.TabIndex = 24;
            // 
            // btnCcOk
            // 
            this.btnCcOk.Location = new System.Drawing.Point(153, 153);
            this.btnCcOk.Name = "btnCcOk";
            this.btnCcOk.Size = new System.Drawing.Size(131, 23);
            this.btnCcOk.TabIndex = 23;
            this.btnCcOk.Text = "OK";
            this.btnCcOk.UseVisualStyleBackColor = true;
            this.btnCcOk.Click += new System.EventHandler(this.btnCcOk_Click);
            // 
            // lblCcLastName
            // 
            this.lblCcLastName.AutoSize = true;
            this.lblCcLastName.Location = new System.Drawing.Point(46, 90);
            this.lblCcLastName.Name = "lblCcLastName";
            this.lblCcLastName.Size = new System.Drawing.Size(53, 13);
            this.lblCcLastName.TabIndex = 27;
            this.lblCcLastName.Text = "Lastname";
            // 
            // txtCcLastName
            // 
            this.txtCcLastName.Location = new System.Drawing.Point(116, 87);
            this.txtCcLastName.Name = "txtCcLastName";
            this.txtCcLastName.Size = new System.Drawing.Size(264, 20);
            this.txtCcLastName.TabIndex = 26;
            // 
            // lblCcAddress
            // 
            this.lblCcAddress.AutoSize = true;
            this.lblCcAddress.Location = new System.Drawing.Point(46, 116);
            this.lblCcAddress.Name = "lblCcAddress";
            this.lblCcAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCcAddress.TabIndex = 29;
            this.lblCcAddress.Text = "Address";
            // 
            // txtCcAddress
            // 
            this.txtCcAddress.Location = new System.Drawing.Point(116, 113);
            this.txtCcAddress.Name = "txtCcAddress";
            this.txtCcAddress.Size = new System.Drawing.Size(264, 20);
            this.txtCcAddress.TabIndex = 28;
            // 
            // CustomerCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 235);
            this.Controls.Add(this.lblCcAddress);
            this.Controls.Add(this.txtCcAddress);
            this.Controls.Add(this.lblCcLastName);
            this.Controls.Add(this.txtCcLastName);
            this.Controls.Add(this.lblCcFirstName);
            this.Controls.Add(this.txtCcFirstName);
            this.Controls.Add(this.btnCcOk);
            this.Name = "CustomerCredentials";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCcFirstName;
        private System.Windows.Forms.TextBox txtCcFirstName;
        private System.Windows.Forms.Button btnCcOk;
        private System.Windows.Forms.Label lblCcLastName;
        private System.Windows.Forms.TextBox txtCcLastName;
        private System.Windows.Forms.Label lblCcAddress;
        private System.Windows.Forms.TextBox txtCcAddress;
    }
}