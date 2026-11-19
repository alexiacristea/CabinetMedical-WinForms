using System;
using System.Windows.Forms;
using CabinetMedical.AccesBD;
using CabinetMedical.Modele;

namespace CabinetMedical.Formulare
{
    public partial class FormularMedic : Form
    {
        private readonly RepositoryMedici repoMedici = new RepositoryMedici();
        private Medic medicCurent;

        public FormularMedic(Medic medic = null)
        {
            InitializeComponent();
            medicCurent = medic;

            if (medicCurent != null)
            {
                txtNume.Text = medicCurent.Nume;
                txtPrenume.Text = medicCurent.Prenume;
                txtSpecializare.Text = medicCurent.Specializare;
                txtTelefon.Text = medicCurent.Telefon;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtPrenume.Text) ||
                string.IsNullOrWhiteSpace(txtSpecializare.Text))
            {
                MessageBox.Show("Completati campurile obligatorii: Nume, Prenume, Specializare.",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (medicCurent == null)
            {
                var medicNou = new Medic
                {
                    Nume = txtNume.Text.Trim(),
                    Prenume = txtPrenume.Text.Trim(),
                    Specializare = txtSpecializare.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim()
                };
                repoMedici.Adauga(medicNou);
            }
            else
            {
                medicCurent.Nume = txtNume.Text.Trim();
                medicCurent.Prenume = txtPrenume.Text.Trim();
                medicCurent.Specializare = txtSpecializare.Text.Trim();
                medicCurent.Telefon = txtTelefon.Text.Trim();
                repoMedici.Modifica(medicCurent);
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