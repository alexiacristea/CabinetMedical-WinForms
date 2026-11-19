namespace CabinetMedical.Formulare
{
    partial class FormularPrincipal
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabMedici = new System.Windows.Forms.TabPage();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.panelMedici = new System.Windows.Forms.Panel();
            this.btnStergeMedic = new System.Windows.Forms.Button();
            this.btnEditeazaMedic = new System.Windows.Forms.Button();
            this.btnAdaugaMedic = new System.Windows.Forms.Button();
            this.tabPacienti = new System.Windows.Forms.TabPage();
            this.dgvPacienti = new System.Windows.Forms.DataGridView();
            this.panelPacienti = new System.Windows.Forms.Panel();
            this.btnStergePacient = new System.Windows.Forms.Button();
            this.btnEditeazaPacient = new System.Windows.Forms.Button();
            this.btnAdaugaPacient = new System.Windows.Forms.Button();
            this.tabConsultatii = new System.Windows.Forms.TabPage();
            this.dgvConsultatii = new System.Windows.Forms.DataGridView();
            this.panelConsultatii = new System.Windows.Forms.Panel();
            this.btnStergeConsultatie = new System.Windows.Forms.Button();
            this.btnEditeazaConsultatie = new System.Windows.Forms.Button();
            this.btnAdaugaConsultatie = new System.Windows.Forms.Button();
            this.tabRetete = new System.Windows.Forms.TabPage();
            this.dgvRetete = new System.Windows.Forms.DataGridView();
            this.panelRetete = new System.Windows.Forms.Panel();
            this.btnStergeReteta = new System.Windows.Forms.Button();
            this.btnEditeazaReteta = new System.Windows.Forms.Button();
            this.btnAdaugaReteta = new System.Windows.Forms.Button();
            this.tabControlPrincipal.SuspendLayout();
            this.tabMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.panelMedici.SuspendLayout();
            this.tabPacienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).BeginInit();
            this.panelPacienti.SuspendLayout();
            this.tabConsultatii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultatii)).BeginInit();
            this.panelConsultatii.SuspendLayout();
            this.tabRetete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).BeginInit();
            this.panelRetete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabMedici);
            this.tabControlPrincipal.Controls.Add(this.tabPacienti);
            this.tabControlPrincipal.Controls.Add(this.tabConsultatii);
            this.tabControlPrincipal.Controls.Add(this.tabRetete);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1229, 755);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabMedici
            // 
            this.tabMedici.Controls.Add(this.dgvMedici);
            this.tabMedici.Controls.Add(this.panelMedici);
            this.tabMedici.Location = new System.Drawing.Point(8, 39);
            this.tabMedici.Name = "tabMedici";
            this.tabMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedici.Size = new System.Drawing.Size(1213, 708);
            this.tabMedici.TabIndex = 0;
            this.tabMedici.Text = "Medici";
            this.tabMedici.UseVisualStyleBackColor = true;
            // 
            // dgvMedici
            // 
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(3, 83);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 82;
            this.dgvMedici.RowTemplate.Height = 33;
            this.dgvMedici.Size = new System.Drawing.Size(1207, 622);
            this.dgvMedici.TabIndex = 1;
            // 
            // panelMedici
            // 
            this.panelMedici.Controls.Add(this.btnStergeMedic);
            this.panelMedici.Controls.Add(this.btnEditeazaMedic);
            this.panelMedici.Controls.Add(this.btnAdaugaMedic);
            this.panelMedici.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedici.Location = new System.Drawing.Point(3, 3);
            this.panelMedici.Name = "panelMedici";
            this.panelMedici.Size = new System.Drawing.Size(1207, 80);
            this.panelMedici.TabIndex = 0;
            // 
            // btnAdaugaMedic
            // 
            this.btnAdaugaMedic.Location = new System.Drawing.Point(3, 12);
            this.btnAdaugaMedic.Name = "btnAdaugaMedic";
            this.btnAdaugaMedic.Size = new System.Drawing.Size(188, 68);
            this.btnAdaugaMedic.TabIndex = 0;
            this.btnAdaugaMedic.Text = "Adauga";
            this.btnAdaugaMedic.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaMedic
            // 
            this.btnEditeazaMedic.Location = new System.Drawing.Point(197, 12);
            this.btnEditeazaMedic.Name = "btnEditeazaMedic";
            this.btnEditeazaMedic.Size = new System.Drawing.Size(188, 68);
            this.btnEditeazaMedic.TabIndex = 1;
            this.btnEditeazaMedic.Text = "Editeaza";
            this.btnEditeazaMedic.UseVisualStyleBackColor = true;
            // 
            // btnStergeMedic
            // 
            this.btnStergeMedic.Location = new System.Drawing.Point(391, 12);
            this.btnStergeMedic.Name = "btnStergeMedic";
            this.btnStergeMedic.Size = new System.Drawing.Size(188, 68);
            this.btnStergeMedic.TabIndex = 2;
            this.btnStergeMedic.Text = "Sterge";
            this.btnStergeMedic.UseVisualStyleBackColor = true;
            // 
            // tabPacienti
            // 
            this.tabPacienti.Controls.Add(this.dgvPacienti);
            this.tabPacienti.Controls.Add(this.panelPacienti);
            this.tabPacienti.Location = new System.Drawing.Point(8, 39);
            this.tabPacienti.Name = "tabPacienti";
            this.tabPacienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacienti.Size = new System.Drawing.Size(1213, 708);
            this.tabPacienti.TabIndex = 1;
            this.tabPacienti.Text = "Pacienti";
            this.tabPacienti.UseVisualStyleBackColor = true;
            // 
            // dgvPacienti
            // 
            this.dgvPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacienti.Location = new System.Drawing.Point(3, 83);
            this.dgvPacienti.Name = "dgvPacienti";
            this.dgvPacienti.RowHeadersWidth = 82;
            this.dgvPacienti.RowTemplate.Height = 33;
            this.dgvPacienti.Size = new System.Drawing.Size(1207, 622);
            this.dgvPacienti.TabIndex = 1;
            // 
            // panelPacienti
            // 
            this.panelPacienti.Controls.Add(this.btnStergePacient);
            this.panelPacienti.Controls.Add(this.btnEditeazaPacient);
            this.panelPacienti.Controls.Add(this.btnAdaugaPacient);
            this.panelPacienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacienti.Location = new System.Drawing.Point(3, 3);
            this.panelPacienti.Name = "panelPacienti";
            this.panelPacienti.Size = new System.Drawing.Size(1207, 80);
            this.panelPacienti.TabIndex = 0;
            // 
            // btnAdaugaPacient
            // 
            this.btnAdaugaPacient.Location = new System.Drawing.Point(1, 12);
            this.btnAdaugaPacient.Name = "btnAdaugaPacient";
            this.btnAdaugaPacient.Size = new System.Drawing.Size(188, 68);
            this.btnAdaugaPacient.TabIndex = 0;
            this.btnAdaugaPacient.Text = "Adauga";
            this.btnAdaugaPacient.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaPacient
            // 
            this.btnEditeazaPacient.Location = new System.Drawing.Point(195, 12);
            this.btnEditeazaPacient.Name = "btnEditeazaPacient";
            this.btnEditeazaPacient.Size = new System.Drawing.Size(188, 68);
            this.btnEditeazaPacient.TabIndex = 1;
            this.btnEditeazaPacient.Text = "Editeaza";
            this.btnEditeazaPacient.UseVisualStyleBackColor = true;
            // 
            // btnStergePacient
            // 
            this.btnStergePacient.Location = new System.Drawing.Point(389, 12);
            this.btnStergePacient.Name = "btnStergePacient";
            this.btnStergePacient.Size = new System.Drawing.Size(188, 68);
            this.btnStergePacient.TabIndex = 2;
            this.btnStergePacient.Text = "Sterge";
            this.btnStergePacient.UseVisualStyleBackColor = true;
            // 
            // tabConsultatii
            // 
            this.tabConsultatii.Controls.Add(this.dgvConsultatii);
            this.tabConsultatii.Controls.Add(this.panelConsultatii);
            this.tabConsultatii.Location = new System.Drawing.Point(8, 39);
            this.tabConsultatii.Name = "tabConsultatii";
            this.tabConsultatii.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultatii.Size = new System.Drawing.Size(1213, 708);
            this.tabConsultatii.TabIndex = 2;
            this.tabConsultatii.Text = "Consultatii";
            this.tabConsultatii.UseVisualStyleBackColor = true;
            // 
            // dgvConsultatii
            // 
            this.dgvConsultatii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultatii.Location = new System.Drawing.Point(3, 83);
            this.dgvConsultatii.Name = "dgvConsultatii";
            this.dgvConsultatii.RowHeadersWidth = 82;
            this.dgvConsultatii.RowTemplate.Height = 33;
            this.dgvConsultatii.Size = new System.Drawing.Size(1207, 622);
            this.dgvConsultatii.TabIndex = 1;
            // 
            // panelConsultatii
            // 
            this.panelConsultatii.Controls.Add(this.btnStergeConsultatie);
            this.panelConsultatii.Controls.Add(this.btnEditeazaConsultatie);
            this.panelConsultatii.Controls.Add(this.btnAdaugaConsultatie);
            this.panelConsultatii.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsultatii.Location = new System.Drawing.Point(3, 3);
            this.panelConsultatii.Name = "panelConsultatii";
            this.panelConsultatii.Size = new System.Drawing.Size(1207, 80);
            this.panelConsultatii.TabIndex = 0;
            // 
            // btnAdaugaConsultatie
            // 
            this.btnAdaugaConsultatie.Location = new System.Drawing.Point(3, 12);
            this.btnAdaugaConsultatie.Name = "btnAdaugaConsultatie";
            this.btnAdaugaConsultatie.Size = new System.Drawing.Size(188, 68);
            this.btnAdaugaConsultatie.TabIndex = 0;
            this.btnAdaugaConsultatie.Text = "Adauga";
            this.btnAdaugaConsultatie.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaConsultatie
            // 
            this.btnEditeazaConsultatie.Location = new System.Drawing.Point(197, 12);
            this.btnEditeazaConsultatie.Name = "btnEditeazaConsultatie";
            this.btnEditeazaConsultatie.Size = new System.Drawing.Size(188, 68);
            this.btnEditeazaConsultatie.TabIndex = 1;
            this.btnEditeazaConsultatie.Text = "Editeaza";
            this.btnEditeazaConsultatie.UseVisualStyleBackColor = true;
            // 
            // btnStergeConsultatie
            // 
            this.btnStergeConsultatie.Location = new System.Drawing.Point(391, 12);
            this.btnStergeConsultatie.Name = "btnStergeConsultatie";
            this.btnStergeConsultatie.Size = new System.Drawing.Size(188, 68);
            this.btnStergeConsultatie.TabIndex = 2;
            this.btnStergeConsultatie.Text = "Sterge";
            this.btnStergeConsultatie.UseVisualStyleBackColor = true;
            // 
            // tabRetete
            // 
            this.tabRetete.Controls.Add(this.dgvRetete);
            this.tabRetete.Controls.Add(this.panelRetete);
            this.tabRetete.Location = new System.Drawing.Point(8, 39);
            this.tabRetete.Name = "tabRetete";
            this.tabRetete.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetete.Size = new System.Drawing.Size(1213, 708);
            this.tabRetete.TabIndex = 3;
            this.tabRetete.Text = "Retete";
            this.tabRetete.UseVisualStyleBackColor = true;
            // 
            // dgvRetete
            // 
            this.dgvRetete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRetete.Location = new System.Drawing.Point(3, 83);
            this.dgvRetete.Name = "dgvRetete";
            this.dgvRetete.RowHeadersWidth = 82;
            this.dgvRetete.RowTemplate.Height = 33;
            this.dgvRetete.Size = new System.Drawing.Size(1207, 622);
            this.dgvRetete.TabIndex = 1;
            // 
            // panelRetete
            // 
            this.panelRetete.Controls.Add(this.btnStergeReteta);
            this.panelRetete.Controls.Add(this.btnEditeazaReteta);
            this.panelRetete.Controls.Add(this.btnAdaugaReteta);
            this.panelRetete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRetete.Location = new System.Drawing.Point(3, 3);
            this.panelRetete.Name = "panelRetete";
            this.panelRetete.Size = new System.Drawing.Size(1207, 80);
            this.panelRetete.TabIndex = 0;
            // 
            // btnAdaugaReteta
            // 
            this.btnAdaugaReteta.Location = new System.Drawing.Point(3, 12);
            this.btnAdaugaReteta.Name = "btnAdaugaReteta";
            this.btnAdaugaReteta.Size = new System.Drawing.Size(188, 68);
            this.btnAdaugaReteta.TabIndex = 0;
            this.btnAdaugaReteta.Text = "Adauga";
            this.btnAdaugaReteta.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaReteta
            // 
            this.btnEditeazaReteta.Location = new System.Drawing.Point(197, 12);
            this.btnEditeazaReteta.Name = "btnEditeazaReteta";
            this.btnEditeazaReteta.Size = new System.Drawing.Size(188, 68);
            this.btnEditeazaReteta.TabIndex = 1;
            this.btnEditeazaReteta.Text = "Editeaza";
            this.btnEditeazaReteta.UseVisualStyleBackColor = true;
            // 
            // btnStergeReteta
            // 
            this.btnStergeReteta.Location = new System.Drawing.Point(391, 12);
            this.btnStergeReteta.Name = "btnStergeReteta";
            this.btnStergeReteta.Size = new System.Drawing.Size(188, 68);
            this.btnStergeReteta.TabIndex = 2;
            this.btnStergeReteta.Text = "Sterge";
            this.btnStergeReteta.UseVisualStyleBackColor = true;
            // 
            // FormularPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 755);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "FormularPrincipal";
            this.Text = "Cabinet Medical";
            this.Load += new System.EventHandler(this.FormularPrincipal_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.panelMedici.ResumeLayout(false);
            this.tabPacienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).EndInit();
            this.panelPacienti.ResumeLayout(false);
            this.tabConsultatii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultatii)).EndInit();
            this.panelConsultatii.ResumeLayout(false);
            this.tabRetete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).EndInit();
            this.panelRetete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabMedici;
        private System.Windows.Forms.TabPage tabPacienti;
        private System.Windows.Forms.TabPage tabConsultatii;
        private System.Windows.Forms.TabPage tabRetete;
        private System.Windows.Forms.Panel panelMedici;
        private System.Windows.Forms.Button btnAdaugaMedic;
        private System.Windows.Forms.Button btnStergeMedic;
        private System.Windows.Forms.Button btnEditeazaMedic;
        private System.Windows.Forms.DataGridView dgvMedici;
        private System.Windows.Forms.Panel panelPacienti;
        private System.Windows.Forms.Button btnAdaugaPacient;
        private System.Windows.Forms.Button btnStergePacient;
        private System.Windows.Forms.Button btnEditeazaPacient;
        private System.Windows.Forms.DataGridView dgvPacienti;
        private System.Windows.Forms.Panel panelConsultatii;
        private System.Windows.Forms.Button btnStergeConsultatie;
        private System.Windows.Forms.Button btnEditeazaConsultatie;
        private System.Windows.Forms.Button btnAdaugaConsultatie;
        private System.Windows.Forms.DataGridView dgvConsultatii;
        private System.Windows.Forms.Panel panelRetete;
        private System.Windows.Forms.Button btnStergeReteta;
        private System.Windows.Forms.Button btnEditeazaReteta;
        private System.Windows.Forms.Button btnAdaugaReteta;
        private System.Windows.Forms.DataGridView dgvRetete;
    }
}