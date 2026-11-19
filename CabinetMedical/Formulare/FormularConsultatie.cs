using System;
using System.Windows.Forms;
using CabinetMedical.AccesBD;
using CabinetMedical.Modele;

namespace CabinetMedical.Formulare
{
    public partial class FormularConsultatie : Form
    {
        private readonly RepositoryConsultatii repoConsultatii = new RepositoryConsultatii();
        private readonly RepositoryMedici repoMedici = new RepositoryMedici();
        private readonly RepositoryPacienti repoPacienti = new RepositoryPacienti();
        private Consultatie consultatieCurenta;

        public FormularConsultatie(Consultatie consultatie = null)
        {
            InitializeComponent();
            consultatieCurenta = consultatie;
            IncarcaMedici();
            IncarcaPacienti();

            if (consultatieCurenta != null)
            {
                cmbMedic.SelectedValue = consultatieCurenta.MedicId;
                cmbPacient.SelectedValue = consultatieCurenta.PacientId;
                dtpData.Value = consultatieCurenta.Data;
                txtDiagnostic.Text = consultatieCurenta.Diagnostic;
                txtPret.Text = consultatieCurenta.Pret.ToString();
            }
        }

        private void IncarcaMedici()
        {
            var medici = repoMedici.GetToti();
            cmbMedic.DataSource = medici;
            cmbMedic.DisplayMember = "NumeComplet";
            cmbMedic.ValueMember = "Id";
        }

        private void IncarcaPacienti()
        {
            var pacienti = repoPacienti.GetToti();
            cmbPacient.DataSource = pacienti;
            cmbPacient.DisplayMember = "NumeComplet";
            cmbPacient.ValueMember = "Id";
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (cmbMedic.SelectedValue == null || cmbPacient.SelectedValue == null)
            {
                MessageBox.Show("Selectati medicul si pacientul.",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPret.Text, out decimal pret))
            {
                MessageBox.Show("Pretul trebuie sa fie un numar valid.",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (consultatieCurenta == null)
            {
                var consultatieNoua = new Consultatie
                {
                    MedicId = (int)cmbMedic.SelectedValue,
                    PacientId = (int)cmbPacient.SelectedValue,
                    Data = dtpData.Value,
                    Diagnostic = txtDiagnostic.Text.Trim(),
                    Pret = pret
                };
                repoConsultatii.Adauga(consultatieNoua);
            }
            else
            {
                consultatieCurenta.MedicId = (int)cmbMedic.SelectedValue;
                consultatieCurenta.PacientId = (int)cmbPacient.SelectedValue;
                consultatieCurenta.Data = dtpData.Value;
                consultatieCurenta.Diagnostic = txtDiagnostic.Text.Trim();
                consultatieCurenta.Pret = pret;
                repoConsultatii.Modifica(consultatieCurenta);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}