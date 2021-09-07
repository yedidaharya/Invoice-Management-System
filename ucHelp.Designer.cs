namespace LoginandRegister
{
    partial class ucHelp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.labelInformationClients = new System.Windows.Forms.Label();
            this.labelInformationInvoices = new System.Windows.Forms.Label();
            this.labelInformationCompany = new System.Windows.Forms.Label();
            this.labelInformationSettings = new System.Windows.Forms.Label();
            this.labelInformationAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Get started";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(37, 67);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(198, 447);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMenu.TabIndex = 10;
            this.pictureBoxMenu.TabStop = false;
            // 
            // labelInformationClients
            // 
            this.labelInformationClients.AutoSize = true;
            this.labelInformationClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationClients.ForeColor = System.Drawing.Color.Black;
            this.labelInformationClients.Location = new System.Drawing.Point(241, 80);
            this.labelInformationClients.Name = "labelInformationClients";
            this.labelInformationClients.Size = new System.Drawing.Size(319, 21);
            this.labelInformationClients.TabIndex = 18;
            this.labelInformationClients.Text = "--> Set clients information and their invoices";
            // 
            // labelInformationInvoices
            // 
            this.labelInformationInvoices.AutoSize = true;
            this.labelInformationInvoices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationInvoices.ForeColor = System.Drawing.Color.Black;
            this.labelInformationInvoices.Location = new System.Drawing.Point(241, 147);
            this.labelInformationInvoices.Name = "labelInformationInvoices";
            this.labelInformationInvoices.Size = new System.Drawing.Size(340, 21);
            this.labelInformationInvoices.TabIndex = 19;
            this.labelInformationInvoices.Text = "--> Create,Read,Update,Input,and delete invoice";
            // 
            // labelInformationCompany
            // 
            this.labelInformationCompany.AutoSize = true;
            this.labelInformationCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationCompany.ForeColor = System.Drawing.Color.Black;
            this.labelInformationCompany.Location = new System.Drawing.Point(241, 214);
            this.labelInformationCompany.Name = "labelInformationCompany";
            this.labelInformationCompany.Size = new System.Drawing.Size(243, 21);
            this.labelInformationCompany.TabIndex = 20;
            this.labelInformationCompany.Text = "--> Set the company information ";
            // 
            // labelInformationSettings
            // 
            this.labelInformationSettings.AutoSize = true;
            this.labelInformationSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationSettings.ForeColor = System.Drawing.Color.Black;
            this.labelInformationSettings.Location = new System.Drawing.Point(241, 413);
            this.labelInformationSettings.Name = "labelInformationSettings";
            this.labelInformationSettings.Size = new System.Drawing.Size(232, 21);
            this.labelInformationSettings.TabIndex = 21;
            this.labelInformationSettings.Text = "--> For admin to setup the user ";
            // 
            // labelInformationAbout
            // 
            this.labelInformationAbout.AutoSize = true;
            this.labelInformationAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationAbout.ForeColor = System.Drawing.Color.Black;
            this.labelInformationAbout.Location = new System.Drawing.Point(241, 473);
            this.labelInformationAbout.Name = "labelInformationAbout";
            this.labelInformationAbout.Size = new System.Drawing.Size(252, 21);
            this.labelInformationAbout.TabIndex = 22;
            this.labelInformationAbout.Text = "-->To see the program information";
            // 
            // ucHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInformationAbout);
            this.Controls.Add(this.labelInformationSettings);
            this.Controls.Add(this.labelInformationCompany);
            this.Controls.Add(this.labelInformationInvoices);
            this.Controls.Add(this.labelInformationClients);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.label1);
            this.Name = "ucHelp";
            this.Size = new System.Drawing.Size(922, 527);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Label labelInformationClients;
        private System.Windows.Forms.Label labelInformationInvoices;
        private System.Windows.Forms.Label labelInformationCompany;
        private System.Windows.Forms.Label labelInformationSettings;
        private System.Windows.Forms.Label labelInformationAbout;
    }
}
