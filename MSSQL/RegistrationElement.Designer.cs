namespace MSSQL
{
    partial class FormRegistrationElement
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTechnics = new System.Windows.Forms.Button();
            this.buttonCartrige = new System.Windows.Forms.Button();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Добавление элемента";
            // 
            // buttonTechnics
            // 
            this.buttonTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTechnics.ForeColor = System.Drawing.Color.Silver;
            this.buttonTechnics.Location = new System.Drawing.Point(191, 57);
            this.buttonTechnics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTechnics.Name = "buttonTechnics";
            this.buttonTechnics.Size = new System.Drawing.Size(150, 35);
            this.buttonTechnics.TabIndex = 24;
            this.buttonTechnics.Text = "Техника";
            this.buttonTechnics.UseVisualStyleBackColor = true;
            this.buttonTechnics.Click += new System.EventHandler(this.buttonTechnics_Click);
            // 
            // buttonCartrige
            // 
            this.buttonCartrige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCartrige.Location = new System.Drawing.Point(21, 57);
            this.buttonCartrige.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCartrige.Name = "buttonCartrige";
            this.buttonCartrige.Size = new System.Drawing.Size(150, 35);
            this.buttonCartrige.TabIndex = 23;
            this.buttonCartrige.Text = "Картридж";
            this.buttonCartrige.UseVisualStyleBackColor = true;
            this.buttonCartrige.Click += new System.EventHandler(this.buttonCartrige_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Location = new System.Drawing.Point(1, 99);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(350, 250);
            this.panelFormLoader.TabIndex = 1;
            // 
            // FormRegistrationElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.buttonTechnics);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.buttonCartrige);
            this.Controls.Add(this.label4);
            this.Name = "FormRegistrationElement";
            this.Load += new System.EventHandler(this.FormRegistrationElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Button buttonTechnics;
        private System.Windows.Forms.Button buttonCartrige;
    }
}