namespace MSSQL
{
    partial class formAdminisrtationUsers
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonDeleteElement = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRefreshData = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewUsers.ColumnHeadersHeight = 30;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.ShowEditingIcon = false;
            this.dataGridViewUsers.Size = new System.Drawing.Size(944, 501);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonDeleteElement
            // 
            this.buttonDeleteElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteElement.AutoSize = true;
            this.buttonDeleteElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteElement.Location = new System.Drawing.Point(760, 57);
            this.buttonDeleteElement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteElement.Name = "buttonDeleteElement";
            this.buttonDeleteElement.Size = new System.Drawing.Size(180, 40);
            this.buttonDeleteElement.TabIndex = 1;
            this.buttonDeleteElement.Text = "Delete";
            this.buttonDeleteElement.UseVisualStyleBackColor = false;
            this.buttonDeleteElement.Click += new System.EventHandler(this.buttonDeleteElement_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.AutoSize = true;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Location = new System.Drawing.Point(760, 7);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(180, 40);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);

            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBoxRefreshData);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.buttonDeleteElement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 102);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxRefreshData
            // 
            this.pictureBoxRefreshData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxRefreshData.Location = new System.Drawing.Point(702, 7);
            this.pictureBoxRefreshData.Name = "pictureBoxRefreshData";
            this.pictureBoxRefreshData.Size = new System.Drawing.Size(41, 40);
            this.pictureBoxRefreshData.TabIndex = 3;
            this.pictureBoxRefreshData.TabStop = false;

            // 
            // formAdminisrtationUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formAdminisrtationUsers";
            this.ShowIcon = false;
            this.Text = "AdminisrtationUsers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminisrtationUsers_FormClosed);
            this.Load += new System.EventHandler(this.AdminisrtationUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonDeleteElement;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxRefreshData;
    }
}