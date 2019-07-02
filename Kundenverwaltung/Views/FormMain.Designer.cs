namespace Kundenverwaltung.Views
{
    partial class FormMain
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
            this.txbSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKunden = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSuche
            // 
            this.txbSuche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSuche.Location = new System.Drawing.Point(81, 6);
            this.txbSuche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSuche.Name = "txbSuche";
            this.txbSuche.Size = new System.Drawing.Size(966, 22);
            this.txbSuche.TabIndex = 0;
            this.txbSuche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbSuche_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suche";
            // 
            // dgvKunden
            // 
            this.dgvKunden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunden.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvKunden.Location = new System.Drawing.Point(12, 34);
            this.dgvKunden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKunden.MultiSelect = false;
            this.dgvKunden.Name = "dgvKunden";
            this.dgvKunden.ReadOnly = true;
            this.dgvKunden.RowTemplate.Height = 24;
            this.dgvKunden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKunden.Size = new System.Drawing.Size(1034, 519);
            this.dgvKunden.TabIndex = 2;
            this.dgvKunden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKunden_CellDoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(921, 559);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(125, 38);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Neuer Eintrag";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 608);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvKunden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSuche);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Kundenverwaltug";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKunden;
        private System.Windows.Forms.Button btnNew;
    }
}

