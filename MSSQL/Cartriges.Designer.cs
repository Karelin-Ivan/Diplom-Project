namespace MSSQL
{
    partial class FormCartriges
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
            this.textBoxEnterBarcode = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.dataGridViewCartriges = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelAllPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOUT = new System.Windows.Forms.Button();
            this.buttonIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).BeginInit();
            this.tableLayoutPanelAllPage.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnterBarcode
            // 
            this.textBoxEnterBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxEnterBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnterBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnterBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterBarcode.Location = new System.Drawing.Point(238, 2);
            this.textBoxEnterBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterBarcode.Multiline = true;
            this.textBoxEnterBarcode.Name = "textBoxEnterBarcode";
            this.textBoxEnterBarcode.Size = new System.Drawing.Size(704, 47);
            this.textBoxEnterBarcode.TabIndex = 0;
            this.textBoxEnterBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterBarcode_KeyDown);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(2, 2);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(232, 47);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // dataGridViewCartriges
            // 
            this.dataGridViewCartriges.AllowUserToAddRows = false;
            this.dataGridViewCartriges.AllowUserToDeleteRows = false;
            this.dataGridViewCartriges.AllowUserToResizeColumns = false;
            this.dataGridViewCartriges.AllowUserToResizeRows = false;
            this.dataGridViewCartriges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCartriges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCartriges.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewCartriges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCartriges.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewCartriges.ColumnHeadersHeight = 30;
            this.dataGridViewCartriges.EnableHeadersVisualStyles = false;
            this.dataGridViewCartriges.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewCartriges.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCartriges.MultiSelect = false;
            this.dataGridViewCartriges.Name = "dataGridViewCartriges";
            this.dataGridViewCartriges.ReadOnly = true;
            this.dataGridViewCartriges.RowHeadersVisible = false;
            this.dataGridViewCartriges.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewCartriges.ShowEditingIcon = false;
            this.dataGridViewCartriges.Size = new System.Drawing.Size(944, 349);
            this.dataGridViewCartriges.TabIndex = 13;
            // 
            // tableLayoutPanelAllPage
            // 
            this.tableLayoutPanelAllPage.ColumnCount = 1;
            this.tableLayoutPanelAllPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAllPage.Controls.Add(this.tableLayoutPanelBottom, 0, 2);
            this.tableLayoutPanelAllPage.Controls.Add(this.dataGridViewCartriges, 0, 1);
            this.tableLayoutPanelAllPage.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelAllPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAllPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanelAllPage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAllPage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanelAllPage.Name = "tableLayoutPanelAllPage";
            this.tableLayoutPanelAllPage.RowCount = 3;
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanelAllPage.Size = new System.Drawing.Size(944, 474);
            this.tableLayoutPanelAllPage.TabIndex = 14;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelBottom.Controls.Add(this.textBoxEnterBarcode, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonEnter, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 423);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(944, 51);
            this.tableLayoutPanelBottom.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOUT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonIN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 70);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // buttonOUT
            // 
            this.buttonOUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOUT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOUT.ForeColor = System.Drawing.Color.Silver;
            this.buttonOUT.Location = new System.Drawing.Point(470, 0);
            this.buttonOUT.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOUT.Name = "buttonOUT";
            this.buttonOUT.Size = new System.Drawing.Size(470, 70);
            this.buttonOUT.TabIndex = 27;
            this.buttonOUT.Text = "Отпуск";
            this.buttonOUT.UseVisualStyleBackColor = true;
            this.buttonOUT.Click += new System.EventHandler(this.buttonOUT_Click);
            // 
            // buttonIN
            // 
            this.buttonIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIN.Location = new System.Drawing.Point(0, 0);
            this.buttonIN.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(470, 70);
            this.buttonIN.TabIndex = 26;
            this.buttonIN.Text = "Поступление";
            this.buttonIN.UseVisualStyleBackColor = true;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // FormCartriges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 474);
            this.Controls.Add(this.tableLayoutPanelAllPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormCartriges";
            this.Text = "Cartriges";
            this.Load += new System.EventHandler(this.formCartriges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).EndInit();
            this.tableLayoutPanelAllPage.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEnterBarcode;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.DataGridView dataGridViewCartriges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAllPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOUT;
        private System.Windows.Forms.Button buttonIN;
    }
}