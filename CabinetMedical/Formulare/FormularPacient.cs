using System;
using System.Windows.Forms;
using CabinetMedical.AccesBD;
using CabinetMedical.Modele;

namespace CabinetMedical.Formulare
{
    public partial class FormularPacient : Form
    {
        private readonly RepositoryPacienti repoPacienti = new RepositoryPacienti();
        private Pacient pacientCurent;

        public FormularPacient(Pacient pacient = null)
        {
            InitializeComponent();
            pacientCurent = pacient;

            if (pacientCurent != null)
            {
                txtNume.Text = pacientCurent.Nume;
                txtPrenume.Text = pacientCurent.Prenume;
                txtCNP.Text = pacientCurent.CNP;
                txtTelefon.Text = pacientCurent.Telefon;
                dtpDataNasterii.Value = pacientCurent.DataNasterii;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                MessageBox.Show("Completati campurile obligatorii: Nume, Prenume.",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pacientCurent == null)
            {
                var pacientNou = new Pacient
                {
                    Nume = txtNume.Text.Trim(),
                    Prenume = txtPrenume.Text.Trim(),
                    CNP = txtCNP.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    DataNasterii = dtpDataNasterii.Value
                };
                repoPacienti.Adauga(pacientNou);
            }
            else
            {
                pacientCurent.Nume = txtNume.Text.Trim();
                pacientCurent.Prenume = txtPrenume.Text.Trim();
                pacientCurent.CNP = txtCNP.Text.Trim();
                pacientCurent.Telefon = txtTelefon.Text.Trim();
                pacientCurent.DataNasterii = dtpDataNasterii.Value;
                repoPacienti.Modifica(pacientCurent);
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