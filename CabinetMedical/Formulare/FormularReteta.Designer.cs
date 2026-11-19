namespace CabinetMedical.Formulare
{
    partial class FormularReteta
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
            this.lblMedic = new System.Windows.Forms.Label();
            this.lblPacient = new System.Windows.Forms.Label();
            this.lblMedicamente = new System.Windows.Forms.Label();
            this.lblDataEliberare = new System.Windows.Forms.Label();
            this.cmbMedic = new System.Windows.Forms.ComboBox();
            this.cmbPacient = new System.Windows.Forms.ComboBox();
            this.txtMedicamente = new System.Windows.Forms.TextBox();
            this.dtpDataEliberare = new System.Windows.Forms.DateTimePicker();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMedic
            // 
            this.lblMedic.AutoSize = true;
            this.lblMedic.Location = new System.Drawing.Point(44, 37);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(78, 25);
            this.lblMedic.TabIndex = 0;
            this.lblMedic.Text = "Medic*";
            // 
            // lblPacient
            // 
            this.lblPacient.AutoSize = true;
            this.lblPacient.Location = new System.Drawing.Point(44, 107);
            this.lblPacient.Name = "lblPacient";
            this.lblPacient.Size = new System.Drawing.Size(92, 25);
            this.lblPacient.TabIndex = 1;
            this.lblPacient.Text = "Pacient*";
            // 
            // lblMedicamente
            // 
            this.lblMedicamente.AutoSize = true;
            this.lblMedicamente.Location = new System.Drawing.Point(44, 172);
            this.lblMedicamente.Name = "lblMedicamente";
            this.lblMedicamente.Size = new System.Drawing.Size(149, 25);
            this.lblMedicamente.TabIndex = 2;
            this.lblMedicamente.Text = "Medicamente*";
            // 
            // lblDataEliberare
            // 
            this.lblDataEliberare.AutoSize = true;
            this.lblDataEliberare.Location = new System.Drawing.Point(44, 237);
            this.lblDataEliberare.Name = "lblDataEliberare";
            this.lblDataEliberare.Size = new System.Drawing.Size(147, 25);
            this.lblDataEliberare.TabIndex = 3;
            this.lblDataEliberare.Text = "Data eliberare";
            // 
            // cmbMedic
            // 
            this.cmbMedic.FormattingEnabled = true;
            this.cmbMedic.Location = new System.Drawing.Point(219, 34);
            this.cmbMedic.Name = "cmbMedic";
            this.cmbMedic.Size = new System.Drawing.Size(334, 33);
            this.cmbMedic.TabIndex = 4;
            // 
            // cmbPacient
            // 
            this.cmbPacient.FormattingEnabled = true;
            this.cmbPacient.Location = new System.Drawing.Point(219, 99);
            this.cmbPacient.Name = "cmbPacient";
            this.cmbPacient.Size = new System.Drawing.Size(334, 33);
            this.cmbPacient.TabIndex = 5;
            // 
            // txtMedicamente
            // 
            this.txtMedicamente.Location = new System.Drawing.Point(219, 169);
            this.txtMedicamente.Name = "txtMedicamente";
            this.txtMedicamente.Size = new System.Drawing.Size(334, 31);
            this.txtMedicamente.TabIndex = 6;
            // 
            // dtpDataEliberare
            // 
            this.dtpDataEliberare.Location = new System.Drawing.Point(219, 231);
            this.dtpDataEliberare.Name = "dtpDataEliberare";
            this.dtpDataEliberare.Size = new System.Drawing.Size(334, 31);
            this.dtpDataEliberare.TabIndex = 7;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(124, 332);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(188, 68);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(365, 332);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(188, 68);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // FormularReteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 487);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dtpDataEliberare);
            this.Controls.Add(this.txtMedicamente);
            this.Controls.Add(this.cmbPacient);
            this.Controls.Add(this.cmbMedic);
            this.Controls.Add(this.lblDataEliberare);
            this.Controls.Add(this.lblMedicamente);
            this.Controls.Add(this.lblPacient);
            this.Controls.Add(this.lblMedic);
            this.Name = "FormularReteta";
            this.Text = "Reteta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedic;
        private System.Windows.Forms.Label lblPacient;
        private System.Windows.Forms.Label lblMedicamente;
        private System.Windows.Forms.Label lblDataEliberare;
        private System.Windows.Forms.ComboBox cmbMedic;
        private System.Windows.Forms.ComboBox cmbPacient;
        private System.Windows.Forms.TextBox txtMedicamente;
        private System.Windows.Forms.DateTimePicker dtpDataEliberare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}