namespace MSSQL
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelUserStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAccouting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRepair = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemReportRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonStatistics = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelUserStatus,
            this.toolStripButtonAccouting,
            this.toolStripButtonRepair,
            this.toolStripDropDownButtonReports,
            this.toolStripButtonStatistics,
            this.toolStripButtonUsers,
            this.toolStripButtonSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelUserStatus
            // 
            this.toolStripLabelUserStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUserStatus.Name = "toolStripLabelUserStatus";
            this.toolStripLabelUserStatus.Size = new System.Drawing.Size(87, 24);
            this.toolStripLabelUserStatus.Text = "userStatus";
            this.toolStripLabelUserStatus.Click += new System.EventHandler(this.toolStripLabelUserStatus_Click);
            // 
            // toolStripButtonAccouting
            // 
            this.toolStripButtonAccouting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAccouting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAccouting.Name = "toolStripButtonAccouting";
            this.toolStripButtonAccouting.Size = new System.Drawing.Size(50, 24);
            this.toolStripButtonAccouting.Text = "Учет";
            this.toolStripButtonAccouting.Click += new System.EventHandler(this.toolStripButtonAccouting_Click);
            // 
            // toolStripButtonRepair
            // 
            this.toolStripButtonRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRepair.Name = "toolStripButtonRepair";
            this.toolStripButtonRepair.Size = new System.Drawing.Size(134, 24);
            this.toolStripButtonRepair.Text = "Ремонт техники";
            this.toolStripButtonRepair.Click += new System.EventHandler(this.toolStripButtonRepair_Click);
            // 
            // toolStripDropDownButtonReports
            // 
            this.toolStripDropDownButtonReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReportRegister});
            this.toolStripDropDownButtonReports.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReports.Image")));
            this.toolStripDropDownButtonReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonReports.Name = "toolStripDropDownButtonReports";
            this.toolStripDropDownButtonReports.Size = new System.Drawing.Size(81, 24);
            this.toolStripDropDownButtonReports.Text = "Отчеты";
            // 
            // toolStripMenuItemReportRegister
            // 
            this.toolStripMenuItemReportRegister.Name = "toolStripMenuItemReportRegister";
            this.toolStripMenuItemReportRegister.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItemReportRegister.Text = "Регистр";
            this.toolStripMenuItemReportRegister.Click += new System.EventHandler(this.toolStripMenuItemReportRegister_Click);
            // 
            // toolStripButtonStatistics
            // 
            this.toolStripButtonStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStatistics.Image")));
            this.toolStripButtonStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStatistics.Name = "toolStripButtonStatistics";
            this.toolStripButtonStatistics.Size = new System.Drawing.Size(103, 24);
            this.toolStripButtonStatistics.Text = "Статистика";
            this.toolStripButtonStatistics.Click += new System.EventHandler(this.toolStripButtonStatistics_Click);
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(125, 24);
            this.toolStripButtonUsers.Text = "Пользователи";
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonUsers_Click);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetting.Image")));
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(95, 24);
            this.toolStripButtonSetting.Text = "Настройки";
            this.toolStripButtonSetting.Click += new System.EventHandler(this.toolStripButtonSetting_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(0, 27);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(944, 474);
            this.panelFormLoader.TabIndex = 1;
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.formMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserStatus;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetting;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.ToolStripButton toolStripButtonRepair;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReportRegister;
        private System.Windows.Forms.ToolStripButton toolStripButtonStatistics;
        private System.Windows.Forms.ToolStripButton toolStripButtonAccouting;
    }
}