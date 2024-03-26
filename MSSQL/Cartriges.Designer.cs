namespace MSSQL
{
    partial class formCartriges
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
            this.textBoxEnterBarcode = new System.Windows.Forms.TextBox();
            this.dataGridViewCartriges = new System.Windows.Forms.DataGridView();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxOnRepair = new System.Windows.Forms.TextBox();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.textBoxModDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDirection
            // 
            this.checkBoxDirection.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDirection.BackColor = System.Drawing.Color.Red;
            this.checkBoxDirection.FlatAppearance.BorderSize = 0;
            this.checkBoxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDirection.Location = new System.Drawing.Point(12, 12);
            this.checkBoxDirection.Name = "checkBoxDirection";
            this.checkBoxDirection.Size = new System.Drawing.Size(776, 30);
            this.checkBoxDirection.TabIndex = 1;
            this.checkBoxDirection.Text = "Отпуск картриджей";
            this.checkBoxDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDirection.UseVisualStyleBackColor = false;
            this.checkBoxDirection.CheckedChanged += new System.EventHandler(this.checkBoxDirection_CheckedChanged);
            // 
            // textBoxEnterBarcode
            // 
            this.textBoxEnterBarcode.Location = new System.Drawing.Point(272, 259);
            this.textBoxEnterBarcode.Multiline = true;
            this.textBoxEnterBarcode.Name = "textBoxEnterBarcode";
            this.textBoxEnterBarcode.Size = new System.Drawing.Size(516, 59);
            this.textBoxEnterBarcode.TabIndex = 2;
            this.textBoxEnterBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridViewCartriges
            // 
            this.dataGridViewCartriges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartriges.Location = new System.Drawing.Point(272, 48);
            this.dataGridViewCartriges.Name = "dataGridViewCartriges";
            this.dataGridViewCartriges.Size = new System.Drawing.Size(516, 205);
            this.dataGridViewCartriges.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 259);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(254, 59);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 48);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(254, 29);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 83);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(254, 29);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(12, 118);
            this.textBoxBarcode.Multiline = true;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(254, 29);
            this.textBoxBarcode.TabIndex = 7;
            // 
            // textBoxOnRepair
            // 
            this.textBoxOnRepair.Location = new System.Drawing.Point(12, 153);
            this.textBoxOnRepair.Multiline = true;
            this.textBoxOnRepair.Name = "textBoxOnRepair";
            this.textBoxOnRepair.Size = new System.Drawing.Size(254, 29);
            this.textBoxOnRepair.TabIndex = 8;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(12, 188);
            this.textBoxOrganization.Multiline = true;
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(254, 29);
            this.textBoxOrganization.TabIndex = 9;
            // 
            // textBoxModDate
            // 
            this.textBoxModDate.Location = new System.Drawing.Point(12, 224);
            this.textBoxModDate.Multiline = true;
            this.textBoxModDate.Name = "textBoxModDate";
            this.textBoxModDate.Size = new System.Drawing.Size(254, 29);
            this.textBoxModDate.TabIndex = 10;
            // 
            // formCartriges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxModDate);
            this.Controls.Add(this.textBoxOrganization);
            this.Controls.Add(this.textBoxOnRepair);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.dataGridViewCartriges);
            this.Controls.Add(this.textBoxEnterBarcode);
            this.Controls.Add(this.checkBoxDirection);
            this.Name = "formCartriges";
            this.Text = "Cartriges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDirection;
        private System.Windows.Forms.TextBox textBoxEnterBarcode;
        private System.Windows.Forms.DataGridView dataGridViewCartriges;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxOnRepair;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.TextBox textBoxModDate;
    }
}