namespace MSSQL
{
    partial class FormSettings
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
            this.checkBoxDirection = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeInputPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxInputPath = new System.Windows.Forms.TextBox();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.buttonChangeOutputPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDirection
            // 
            this.checkBoxDirection.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDirection.BackColor = System.Drawing.Color.White;
            this.checkBoxDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxDirection.FlatAppearance.BorderSize = 0;
            this.checkBoxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDirection.Location = new System.Drawing.Point(0, 0);
            this.checkBoxDirection.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDirection.Name = "checkBoxDirection";
            this.checkBoxDirection.Size = new System.Drawing.Size(685, 60);
            this.checkBoxDirection.TabIndex = 2;
            this.checkBoxDirection.Text = "Настройки";
            this.checkBoxDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDirection.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь к папке с шаблонами";
            // 
            // buttonChangeInputPath
            // 
            this.buttonChangeInputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeInputPath.Location = new System.Drawing.Point(555, 31);
            this.buttonChangeInputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChangeInputPath.Name = "buttonChangeInputPath";
            this.buttonChangeInputPath.Size = new System.Drawing.Size(112, 35);
            this.buttonChangeInputPath.TabIndex = 4;
            this.buttonChangeInputPath.Text = "Изменить";
            this.buttonChangeInputPath.UseVisualStyleBackColor = true;
            this.buttonChangeInputPath.Click += new System.EventHandler(this.buttonChangeInputPath_Click);
            // 
            // textBoxInputPath
            // 
            this.textBoxInputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputPath.Location = new System.Drawing.Point(13, 35);
            this.textBoxInputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInputPath.Name = "textBoxInputPath";
            this.textBoxInputPath.ReadOnly = true;
            this.textBoxInputPath.Size = new System.Drawing.Size(534, 26);
            this.textBoxInputPath.TabIndex = 5;
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputPath.Location = new System.Drawing.Point(13, 95);
            this.textBoxOutputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.ReadOnly = true;
            this.textBoxOutputPath.Size = new System.Drawing.Size(534, 26);
            this.textBoxOutputPath.TabIndex = 8;
            // 
            // buttonChangeOutputPath
            // 
            this.buttonChangeOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeOutputPath.Location = new System.Drawing.Point(555, 91);
            this.buttonChangeOutputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChangeOutputPath.Name = "buttonChangeOutputPath";
            this.buttonChangeOutputPath.Size = new System.Drawing.Size(112, 35);
            this.buttonChangeOutputPath.TabIndex = 7;
            this.buttonChangeOutputPath.Text = "Изменить";
            this.buttonChangeOutputPath.UseVisualStyleBackColor = true;
            this.buttonChangeOutputPath.Click += new System.EventHandler(this.buttonChangeOutputPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь сохранения шаблонов";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(462, 153);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(204, 66);
            this.buttonSaveChanges.TabIndex = 9;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxDirection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 301);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveChanges);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxOutputPath);
            this.panel1.Controls.Add(this.buttonChangeInputPath);
            this.panel1.Controls.Add(this.buttonChangeOutputPath);
            this.panel1.Controls.Add(this.textBoxInputPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 235);
            this.panel1.TabIndex = 0;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.formSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeInputPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxInputPath;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.Button buttonChangeOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}