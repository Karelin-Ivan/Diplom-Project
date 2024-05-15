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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxDirection = new System.Windows.Forms.CheckBox();
            this.textBoxEnterBarcode = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.dataGridViewCartriges = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelAllPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).BeginInit();
            this.tableLayoutPanelAllPage.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
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
            this.checkBoxDirection.Size = new System.Drawing.Size(946, 71);
            this.checkBoxDirection.TabIndex = 1;
            this.checkBoxDirection.Text = "Отпуск картриджей";
            this.checkBoxDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDirection.UseVisualStyleBackColor = false;
            this.checkBoxDirection.CheckedChanged += new System.EventHandler(this.checkBoxDirection_CheckedChanged);
            // 
            // textBoxEnterBarcode
            // 
            this.textBoxEnterBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxEnterBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnterBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnterBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterBarcode.Location = new System.Drawing.Point(237, 1);
            this.textBoxEnterBarcode.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxEnterBarcode.Multiline = true;
            this.textBoxEnterBarcode.Name = "textBoxEnterBarcode";
            this.textBoxEnterBarcode.Size = new System.Drawing.Size(708, 46);
            this.textBoxEnterBarcode.TabIndex = 0;
            this.textBoxEnterBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterBarcode_KeyDown);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(1, 1);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(234, 46);
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
            this.dataGridViewCartriges.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCartriges.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewCartriges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCartriges.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCartriges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCartriges.ColumnHeadersHeight = 30;
            this.dataGridViewCartriges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCartriges.Location = new System.Drawing.Point(0, 71);
            this.dataGridViewCartriges.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCartriges.MultiSelect = false;
            this.dataGridViewCartriges.Name = "dataGridViewCartriges";
            this.dataGridViewCartriges.ReadOnly = true;
            this.dataGridViewCartriges.RowHeadersVisible = false;
            this.dataGridViewCartriges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCartriges.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewCartriges.ShowEditingIcon = false;
            this.dataGridViewCartriges.Size = new System.Drawing.Size(946, 331);
            this.dataGridViewCartriges.TabIndex = 13;
            // 
            // tableLayoutPanelAllPage
            // 
            this.tableLayoutPanelAllPage.ColumnCount = 1;
            this.tableLayoutPanelAllPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAllPage.Controls.Add(this.tableLayoutPanelBottom, 0, 2);
            this.tableLayoutPanelAllPage.Controls.Add(this.checkBoxDirection, 0, 0);
            this.tableLayoutPanelAllPage.Controls.Add(this.dataGridViewCartriges, 0, 1);
            this.tableLayoutPanelAllPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAllPage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAllPage.Name = "tableLayoutPanelAllPage";
            this.tableLayoutPanelAllPage.RowCount = 3;
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanelAllPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanelAllPage.Size = new System.Drawing.Size(946, 450);
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
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 402);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(946, 48);
            this.tableLayoutPanelBottom.TabIndex = 14;
            // 
            // FormCartriges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.tableLayoutPanelAllPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCartriges";
            this.Text = "Cartriges";
            this.Load += new System.EventHandler(this.formCartriges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartriges)).EndInit();
            this.tableLayoutPanelAllPage.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDirection;
        private System.Windows.Forms.TextBox textBoxEnterBarcode;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.DataGridView dataGridViewCartriges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAllPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
    }
}