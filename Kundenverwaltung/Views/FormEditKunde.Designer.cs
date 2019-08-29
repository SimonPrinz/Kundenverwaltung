using Kundenverwaltung.Components;

namespace Kundenverwaltung.Views
{
    partial class FormEditKunde
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
            this.txbId = new System.Windows.Forms.TextBox();
            this.grbBasisdaten = new System.Windows.Forms.GroupBox();
            this.txbOrt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPLZ = new NumberBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAnsprechpartner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFirmenname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbBasisdaten.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(10, 11);
            this.txbId.Margin = new System.Windows.Forms.Padding(2);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(148, 20);
            this.txbId.TabIndex = 0;
            // 
            // grbBasisdaten
            // 
            this.grbBasisdaten.Controls.Add(this.txbOrt);
            this.grbBasisdaten.Controls.Add(this.label4);
            this.grbBasisdaten.Controls.Add(this.txbPLZ);
            this.grbBasisdaten.Controls.Add(this.label3);
            this.grbBasisdaten.Controls.Add(this.txbAnsprechpartner);
            this.grbBasisdaten.Controls.Add(this.label2);
            this.grbBasisdaten.Controls.Add(this.txbFirmenname);
            this.grbBasisdaten.Controls.Add(this.label1);
            this.grbBasisdaten.Location = new System.Drawing.Point(10, 41);
            this.grbBasisdaten.Margin = new System.Windows.Forms.Padding(2);
            this.grbBasisdaten.Name = "grbBasisdaten";
            this.grbBasisdaten.Padding = new System.Windows.Forms.Padding(2);
            this.grbBasisdaten.Size = new System.Drawing.Size(372, 141);
            this.grbBasisdaten.TabIndex = 1;
            this.grbBasisdaten.TabStop = false;
            this.grbBasisdaten.Text = "Basisdaten";
            // 
            // txbOrt
            // 
            this.txbOrt.Location = new System.Drawing.Point(141, 98);
            this.txbOrt.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrt.Name = "txbOrt";
            this.txbOrt.Size = new System.Drawing.Size(215, 20);
            this.txbOrt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ort";
            // 
            // txbPLZ
            // 
            this.txbPLZ.Location = new System.Drawing.Point(141, 75);
            this.txbPLZ.Margin = new System.Windows.Forms.Padding(2);
            this.txbPLZ.Name = "txbPLZ";
            this.txbPLZ.Size = new System.Drawing.Size(215, 20);
            this.txbPLZ.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PLZ";
            // 
            // txbAnsprechpartner
            // 
            this.txbAnsprechpartner.Location = new System.Drawing.Point(142, 51);
            this.txbAnsprechpartner.Margin = new System.Windows.Forms.Padding(2);
            this.txbAnsprechpartner.Name = "txbAnsprechpartner";
            this.txbAnsprechpartner.Size = new System.Drawing.Size(215, 20);
            this.txbAnsprechpartner.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ansprechpartner";
            // 
            // txbFirmenname
            // 
            this.txbFirmenname.Location = new System.Drawing.Point(142, 28);
            this.txbFirmenname.Margin = new System.Windows.Forms.Padding(2);
            this.txbFirmenname.Name = "txbFirmenname";
            this.txbFirmenname.Size = new System.Drawing.Size(215, 20);
            this.txbFirmenname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmenname";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 188);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(203, 188);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(11, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormEditKunde
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(398, 230);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbBasisdaten);
            this.Controls.Add(this.txbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditKunde";
            this.Text = "s";
            this.TopMost = true;
            this.grbBasisdaten.ResumeLayout(false);
            this.grbBasisdaten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.GroupBox grbBasisdaten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOrt;
        private System.Windows.Forms.Label label4;
        private NumberBox txbPLZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAnsprechpartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFirmenname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}