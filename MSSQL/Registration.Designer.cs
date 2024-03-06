namespace MSSQL
{
    partial class formRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.checkBoxRoleAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxRoleUser = new System.Windows.Forms.CheckBox();
            this.checkBoxUserActive = new System.Windows.Forms.CheckBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(252, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 42);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(176, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(257, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(176, 87);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(257, 20);
            this.textBoxLogin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(176, 142);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(257, 20);
            this.textBoxPasswordConfirm.TabIndex = 13;
            // 
            // checkBoxRoleAdmin
            // 
            this.checkBoxRoleAdmin.AutoSize = true;
            this.checkBoxRoleAdmin.Location = new System.Drawing.Point(176, 202);
            this.checkBoxRoleAdmin.Name = "checkBoxRoleAdmin";
            this.checkBoxRoleAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxRoleAdmin.TabIndex = 15;
            this.checkBoxRoleAdmin.Text = "Admin";
            this.checkBoxRoleAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoleUser
            // 
            this.checkBoxRoleUser.AutoSize = true;
            this.checkBoxRoleUser.Location = new System.Drawing.Point(176, 225);
            this.checkBoxRoleUser.Name = "checkBoxRoleUser";
            this.checkBoxRoleUser.Size = new System.Drawing.Size(48, 17);
            this.checkBoxRoleUser.TabIndex = 16;
            this.checkBoxRoleUser.Text = "User";
            this.checkBoxRoleUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserActive
            // 
            this.checkBoxUserActive.AutoSize = true;
            this.checkBoxUserActive.Location = new System.Drawing.Point(340, 202);
            this.checkBoxUserActive.Name = "checkBoxUserActive";
            this.checkBoxUserActive.Size = new System.Drawing.Size(56, 17);
            this.checkBoxUserActive.TabIndex = 17;
            this.checkBoxUserActive.Text = "Active";
            this.checkBoxUserActive.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(115, 61);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 20;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(176, 61);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(257, 20);
            this.textBoxUsername.TabIndex = 19;
            // 
            // formRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 349);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.checkBoxUserActive);
            this.Controls.Add(this.checkBoxRoleUser);
            this.Controls.Add(this.checkBoxRoleAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "formRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.CheckBox checkBoxRoleAdmin;
        private System.Windows.Forms.CheckBox checkBoxRoleUser;
        private System.Windows.Forms.CheckBox checkBoxUserActive;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}