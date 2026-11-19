using System;
using System.Windows.Forms;
using CabinetMedical.AccesBD;
using CabinetMedical.Modele;

namespace CabinetMedical.Formulare
{
    public partial class FormularReteta : Form
    {
        private readonly RepositoryRetete repoRetete = new RepositoryRetete();
        private readonly RepositoryMedici repoMedici = new RepositoryMedici();
        private readonly RepositoryPacienti repoPacienti = new RepositoryPacienti();
        private Reteta retetaCurenta;

        public FormularReteta(Reteta reteta = null)
        {
            InitializeComponent();
            retetaCurenta = reteta;
            IncarcaMedici();
            IncarcaPacienti();

            if (retetaCurenta != null)
            {
                cmbMedic.SelectedValue = retetaCurenta.MedicId;
                cmbPacient.SelectedValue = retetaCurenta.PacientId;
                txtMedicamente.Text = retetaCurenta.Medicamente;
                dtpDataEliberare.Value = retetaCurenta.DataEliberare;
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

            if (string.IsNullOrWhiteSpace(txtMedicamente.Text))
            {
                MessageBox.Show("Completati campul Medicamente.",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (retetaCurenta == null)
            {
                var retetaNoua = new Reteta
                {
                    MedicId = (int)cmbMedic.SelectedValue,
                    PacientId = (int)cmbPacient.SelectedValue,
                    Medicamente = txtMedicamente.Text.Trim(),
                    DataEliberare = dtpDataEliberare.Value
                };
                repoRetete.Adauga(retetaNoua);
            }
            else
            {
                retetaCurenta.MedicId = (int)cmbMedic.SelectedValue;
                retetaCurenta.PacientId = (int)cmbPacient.SelectedValue;
                retetaCurenta.Medicamente = txtMedicamente.Text.Trim();
                retetaCurenta.DataEliberare = dtpDataEliberare.Value;
                repoRetete.Modifica(retetaCurenta);
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