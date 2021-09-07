namespace LoginandRegister
{
    partial class ucAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAbout));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersionApp = new System.Windows.Forms.Label();
            this.labelNameApp = new System.Windows.Forms.Label();
            this.pictureBoxalogo = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelNameGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.Black;
            this.labelCopyright.Location = new System.Drawing.Point(234, 102);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(169, 21);
            this.labelCopyright.TabIndex = 15;
            this.labelCopyright.Text = "Copyright 2019 - 2020";
            // 
            // labelVersionApp
            // 
            this.labelVersionApp.AutoSize = true;
            this.labelVersionApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersionApp.ForeColor = System.Drawing.Color.Black;
            this.labelVersionApp.Location = new System.Drawing.Point(234, 69);
            this.labelVersionApp.Name = "labelVersionApp";
            this.labelVersionApp.Size = new System.Drawing.Size(87, 21);
            this.labelVersionApp.TabIndex = 16;
            this.labelVersionApp.Text = "Version 1.0";
            // 
            // labelNameApp
            // 
            this.labelNameApp.AutoSize = true;
            this.labelNameApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameApp.ForeColor = System.Drawing.Color.Black;
            this.labelNameApp.Location = new System.Drawing.Point(234, 38);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(216, 21);
            this.labelNameApp.TabIndex = 17;
            this.labelNameApp.Text = "Invoicer System Management";
            // 
            // pictureBoxalogo
            // 
            this.pictureBoxalogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxalogo.Image")));
            this.pictureBoxalogo.Location = new System.Drawing.Point(28, 17);
            this.pictureBoxalogo.Name = "pictureBoxalogo";
            this.pictureBoxalogo.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxalogo.TabIndex = 18;
            this.pictureBoxalogo.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.Black;
            this.labelname.Location = new System.Drawing.Point(28, 240);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(59, 21);
            this.labelname.TabIndex = 19;
            this.labelname.Text = "Name :";
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameGroup.ForeColor = System.Drawing.Color.Black;
            this.labelNameGroup.Location = new System.Drawing.Point(93, 240);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(101, 105);
            this.labelNameGroup.TabIndex = 20;
            this.labelNameGroup.Text = "Yedida Harya\r\nHarits\r\nAji\r\nArifin\r\nJul\r\n";
            // 
            // ucAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNameGroup);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.pictureBoxalogo);
            this.Controls.Add(this.labelNameApp);
            this.Controls.Add(this.labelVersionApp);
            this.Controls.Add(this.labelCopyright);
            this.Name = "ucAbout";
            this.Size = new System.Drawing.Size(922, 527);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersionApp;
        private System.Windows.Forms.Label labelNameApp;
        private System.Windows.Forms.PictureBox pictureBoxalogo;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelNameGroup;
    }
}
