namespace CabinetMedical.Formulare
{
    partial class FormularConsultatie
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.cmbMedic = new System.Windows.Forms.ComboBox();
            this.cmbPacient = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMedic
            // 
            this.lblMedic.AutoSize = true;
            this.lblMedic.Location = new System.Drawing.Point(36, 31);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(78, 25);
            this.lblMedic.TabIndex = 0;
            this.lblMedic.Text = "Medic*";
            // 
            // lblPacient
            // 
            this.lblPacient.AutoSize = true;
            this.lblPacient.Location = new System.Drawing.Point(36, 91);
            this.lblPacient.Name = "lblPacient";
            this.lblPacient.Size = new System.Drawing.Size(92, 25);
            this.lblPacient.TabIndex = 1;
            this.lblPacient.Text = "Pacient*";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(36, 148);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Location = new System.Drawing.Point(36, 200);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(113, 25);
            this.lblDiagnostic.TabIndex = 3;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(36, 254);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(51, 25);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "Pret";
            // 
            // cmbMedic
            // 
            this.cmbMedic.FormattingEnabled = true;
            this.cmbMedic.Location = new System.Drawing.Point(169, 35);
            this.cmbMedic.Name = "cmbMedic";
            this.cmbMedic.Size = new System.Drawing.Size(334, 33);
            this.cmbMedic.TabIndex = 5;
            // 
            // cmbPacient
            // 
            this.cmbPacient.FormattingEnabled = true;
            this.cmbPacient.Location = new System.Drawing.Point(169, 83);
            this.cmbPacient.Name = "cmbPacient";
            this.cmbPacient.Size = new System.Drawing.Size(334, 33);
            this.cmbPacient.TabIndex = 6;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(169, 142);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(334, 31);
            this.dtpData.TabIndex = 7;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(169, 194);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(334, 31);
            this.txtDiagnostic.TabIndex = 8;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(169, 248);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(334, 31);
            this.txtPret.TabIndex = 9;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(80, 340);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(188, 68);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(315, 340);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(188, 68);
            this.btnAnuleaza.TabIndex = 11;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // FormularConsultatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 487);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbPacient);
            this.Controls.Add(this.cmbMedic);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblDiagnostic);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPacient);
            this.Controls.Add(this.lblMedic);
            this.Name = "FormularConsultatie";
            this.Text = "Consultatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedic;
        private System.Windows.Forms.Label lblPacient;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.ComboBox cmbMedic;
        private System.Windows.Forms.ComboBox cmbPacient;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}