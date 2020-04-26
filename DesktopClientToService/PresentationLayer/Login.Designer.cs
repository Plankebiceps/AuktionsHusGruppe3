namespace DesktopClientToService.PresentationLayer
{
    partial class Login
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.rbutAdm = new System.Windows.Forms.RadioButton();
            this.rbutCust = new System.Windows.Forms.RadioButton();
            this.btnSkipLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(109, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(109, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(217, 164);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(182, 28);
            this.btnCreateAcc.TabIndex = 6;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // rbutAdm
            // 
            this.rbutAdm.AutoSize = true;
            this.rbutAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutAdm.Location = new System.Drawing.Point(109, 135);
            this.rbutAdm.Name = "rbutAdm";
            this.rbutAdm.Size = new System.Drawing.Size(64, 20);
            this.rbutAdm.TabIndex = 7;
            this.rbutAdm.TabStop = true;
            this.rbutAdm.Text = "Admin";
            this.rbutAdm.UseVisualStyleBackColor = true;
            // 
            // rbutCust
            // 
            this.rbutCust.AutoSize = true;
            this.rbutCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutCust.Location = new System.Drawing.Point(179, 135);
            this.rbutCust.Name = "rbutCust";
            this.rbutCust.Size = new System.Drawing.Size(83, 20);
            this.rbutCust.TabIndex = 8;
            this.rbutCust.TabStop = true;
            this.rbutCust.Text = "Customer";
            this.rbutCust.UseVisualStyleBackColor = true;
            this.rbutCust.CheckedChanged += new System.EventHandler(this.rbutCust_CheckedChanged);
            // 
            // btnSkipLogin
            // 
            this.btnSkipLogin.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSkipLogin.Location = new System.Drawing.Point(195, 226);
            this.btnSkipLogin.Name = "btnSkipLogin";
            this.btnSkipLogin.Size = new System.Drawing.Size(290, 48);
            this.btnSkipLogin.TabIndex = 9;
            this.btnSkipLogin.Text = "sKiP lOgiN";
            this.btnSkipLogin.UseVisualStyleBackColor = true;
            this.btnSkipLogin.Click += new System.EventHandler(this.btnSkipLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.btnSkipLogin);
            this.Controls.Add(this.rbutCust);
            this.Controls.Add(this.rbutAdm);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "Login";
            this.Text = "Sign In - Auctioneer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.RadioButton rbutAdm;
        private System.Windows.Forms.RadioButton rbutCust;
        private System.Windows.Forms.Button btnSkipLogin;
    }
}