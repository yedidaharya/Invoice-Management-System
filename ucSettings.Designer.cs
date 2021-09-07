namespace LoginandRegister
{
    partial class ucSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLoginAdmin = new System.Windows.Forms.Panel();
            this.pictureBoxLogoAdmin = new System.Windows.Forms.PictureBox();
            this.labelLoginAdmin = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsernameAdmin = new System.Windows.Forms.TextBox();
            this.panelLoginAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Gray;
            this.btnUsers.Location = new System.Drawing.Point(14, 14);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(106, 33);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelUsers.Location = new System.Drawing.Point(14, 53);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(106, 10);
            this.panelUsers.TabIndex = 1;
            this.panelUsers.Visible = false;
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelAddUser.Location = new System.Drawing.Point(126, 53);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(106, 10);
            this.panelAddUser.TabIndex = 3;
            this.panelAddUser.Visible = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Gray;
            this.btnAddUser.Location = new System.Drawing.Point(126, 14);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 33);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(14, 81);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(946, 439);
            this.panelMain.TabIndex = 4;
            // 
            // panelLoginAdmin
            // 
            this.panelLoginAdmin.Controls.Add(this.pictureBoxLogoAdmin);
            this.panelLoginAdmin.Controls.Add(this.labelLoginAdmin);
            this.panelLoginAdmin.Controls.Add(this.btnLoginAdmin);
            this.panelLoginAdmin.Controls.Add(this.txtPasswordAdmin);
            this.panelLoginAdmin.Controls.Add(this.labelPassword);
            this.panelLoginAdmin.Controls.Add(this.labelUsername);
            this.panelLoginAdmin.Controls.Add(this.txtUsernameAdmin);
            this.panelLoginAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLoginAdmin.Name = "panelLoginAdmin";
            this.panelLoginAdmin.Size = new System.Drawing.Size(1008, 588);
            this.panelLoginAdmin.TabIndex = 0;
            // 
            // pictureBoxLogoAdmin
            // 
            this.pictureBoxLogoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoAdmin.Image")));
            this.pictureBoxLogoAdmin.Location = new System.Drawing.Point(436, 37);
            this.pictureBoxLogoAdmin.Name = "pictureBoxLogoAdmin";
            this.pictureBoxLogoAdmin.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogoAdmin.TabIndex = 15;
            this.pictureBoxLogoAdmin.TabStop = false;
            // 
            // labelLoginAdmin
            // 
            this.labelLoginAdmin.AutoSize = true;
            this.labelLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAdmin.ForeColor = System.Drawing.Color.Black;
            this.labelLoginAdmin.Location = new System.Drawing.Point(432, 150);
            this.labelLoginAdmin.Name = "labelLoginAdmin";
            this.labelLoginAdmin.Size = new System.Drawing.Size(118, 21);
            this.labelLoginAdmin.TabIndex = 14;
            this.labelLoginAdmin.Text = "Login as Admin";
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAdmin.Location = new System.Drawing.Point(542, 342);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(102, 43);
            this.btnLoginAdmin.TabIndex = 13;
            this.btnLoginAdmin.Text = "LOGIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(364, 297);
            this.txtPasswordAdmin.Multiline = true;
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(280, 30);
            this.txtPasswordAdmin.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Gray;
            this.labelPassword.Location = new System.Drawing.Point(359, 269);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 25);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Gray;
            this.labelUsername.Location = new System.Drawing.Point(359, 197);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(98, 25);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username";
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameAdmin.Location = new System.Drawing.Point(364, 225);
            this.txtUsernameAdmin.Multiline = true;
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(280, 30);
            this.txtUsernameAdmin.TabIndex = 9;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelLoginAdmin);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.btnUsers);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1008, 588);
            this.panelLoginAdmin.ResumeLayout(false);
            this.panelLoginAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLoginAdmin;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsernameAdmin;
        private System.Windows.Forms.Label labelLoginAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogoAdmin;
    }
}
