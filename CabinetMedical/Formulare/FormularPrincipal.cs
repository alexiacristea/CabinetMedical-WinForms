using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using CabinetMedical.AccesBD;
using CabinetMedical.Modele;

namespace CabinetMedical.Formulare
{
    public partial class FormularPrincipal : Form
    {
        private readonly RepositoryMedici repoMedici = new RepositoryMedici();
        private readonly RepositoryPacienti repoPacienti = new RepositoryPacienti();
        private readonly RepositoryConsultatii repoConsultatii = new RepositoryConsultatii();
        private readonly RepositoryRetete repoRetete = new RepositoryRetete();

        public FormularPrincipal()
        {
            InitializeComponent();

            btnAdaugaMedic.Click += (s, e) => DeschideFormularMedic(null);
            btnEditeazaMedic.Click += (s, e) => EditeazaMedic();
            btnStergeMedic.Click += (s, e) => StergeMedic();

            btnAdaugaPacient.Click += (s, e) => DeschideFormularPacient(null);
            btnEditeazaPacient.Click += (s, e) => EditeazaPacient();
            btnStergePacient.Click += (s, e) => StergePacient();

            btnAdaugaConsultatie.Click += (s, e) => DeschideFormularConsultatie(null);
            btnEditeazaConsultatie.Click += (s, e) => EditeazaConsultatie();
            btnStergeConsultatie.Click += (s, e) => StergeConsultatie();

            btnAdaugaReteta.Click += (s, e) => DeschideFormularReteta(null);
            btnEditeazaReteta.Click += (s, e) => EditeazaReteta();
            btnStergeReteta.Click += (s, e) => StergeReteta();
        }

        private void FormularPrincipal_Load(object sender, EventArgs e)
        {
            IncarcaMedici();
            IncarcaPacienti();
            IncarcaConsultatii();
            IncarcaRetete();

            dgvConsultatii.Columns["MedicId"].Visible = false;
            dgvConsultatii.Columns["PacientId"].Visible = false;

            dgvRetete.Columns["MedicId"].Visible = false;
            dgvRetete.Columns["PacientId"].Visible = false;

            dgvMedici.Columns["NumeComplet"].Visible = false;
            dgvPacienti.Columns["NumeComplet"].Visible = false;

            dgvConsultatii.Columns["NumeMedic"].DisplayIndex = 1;
            dgvConsultatii.Columns["NumePacient"].DisplayIndex = 2;

            dgvRetete.Columns["NumeMedic"].DisplayIndex = 1;
            dgvRetete.Columns["NumePacient"].DisplayIndex = 2;

            dgvPacienti.Columns["DataNasterii"].HeaderText = "Data nasterii";
            dgvConsultatii.Columns["NumeMedic"].HeaderText = "Nume medic";
            dgvConsultatii.Columns["NumePacient"].HeaderText = "Nume pacient";

            dgvRetete.Columns["NumeMedic"].HeaderText = "Nume medic";
            dgvRetete.Columns["NumePacient"].HeaderText = "Nume pacient";
            dgvRetete.Columns["DataEliberare"].HeaderText = "Data eliberare";

            dgvConsultatii.Columns["Data"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvConsultatii.Columns["Pret"].DefaultCellStyle.Format = "N2";
            dgvPacienti.Columns["DataNasterii"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvRetete.Columns["DataEliberare"].DefaultCellStyle.Format = "dd.MM.yyyy";

            tabControlPrincipal.SelectedIndex = 0;
        }

        // Ruleaza o stergere si trateaza cazul in care baza de date o refuza
        // din cauza cheilor straine (inregistrarea e folosita in alt tabel).
        private static bool StergeSigur(Action stergere, string mesajDacaEsteFolosit)
        {
            const int SQLITE_CONSTRAINT = 19;
            try
            {
                stergere();
                return true;
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == SQLITE_CONSTRAINT)
            {
                MessageBox.Show(mesajDacaEsteFolosit, "Stergere imposibila",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void IncarcaMedici()
        {
            dgvMedici.DataSource = repoMedici.GetToti();
        }

        private void IncarcaPacienti()
        {
            dgvPacienti.DataSource = repoPacienti.GetToti();
        }

        private void IncarcaConsultatii()
        {
            dgvConsultatii.DataSource = repoConsultatii.GetToate();
        }

        private void IncarcaRetete()
        {
            dgvRetete.DataSource = repoRetete.GetToate();
        }

        private void DeschideFormularMedic(Medic medic)
        {
            var form = new FormularMedic(medic);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaMedici();
        }

        private void EditeazaMedic()
        {
            if (dgvMedici.CurrentRow == null) return;
            var medic = (Medic)dgvMedici.CurrentRow.DataBoundItem;
            DeschideFormularMedic(medic);
        }

        private void StergeMedic()
        {
            if (dgvMedici.CurrentRow == null) return;
            var medic = (Medic)dgvMedici.CurrentRow.DataBoundItem;
            var rezultat = MessageBox.Show(
                $"Esti sigur ca vrei sa stergi medicul {medic.Nume} {medic.Prenume}?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rezultat == DialogResult.Yes)
            {
                if (StergeSigur(() => repoMedici.Sterge(medic.Id),
                        "Medicul are consultatii sau retete inregistrate si nu poate fi sters."))
                    IncarcaMedici();
            }
        }

        private void DeschideFormularPacient(Pacient pacient)
        {
            var form = new FormularPacient(pacient);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaPacienti();
        }

        private void EditeazaPacient()
        {
            if (dgvPacienti.CurrentRow == null) return;
            var pacient = (Pacient)dgvPacienti.CurrentRow.DataBoundItem;
            DeschideFormularPacient(pacient);
        }

        private void StergePacient()
        {
            if (dgvPacienti.CurrentRow == null) return;
            var pacient = (Pacient)dgvPacienti.CurrentRow.DataBoundItem;
            var rezultat = MessageBox.Show(
                $"Esti sigur ca vrei sa stergi pacientul {pacient.Nume} {pacient.Prenume}?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rezultat == DialogResult.Yes)
            {
                if (StergeSigur(() => repoPacienti.Sterge(pacient.Id),
                        "Pacientul are consultatii sau retete inregistrate si nu poate fi sters."))
                    IncarcaPacienti();
            }
        }

        private void DeschideFormularConsultatie(Consultatie consultatie)
        {
            var form = new FormularConsultatie(consultatie);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaConsultatii();
        }

        private void EditeazaConsultatie()
        {
            if (dgvConsultatii.CurrentRow == null) return;
            var consultatie = (Consultatie)dgvConsultatii.CurrentRow.DataBoundItem;
            DeschideFormularConsultatie(consultatie);
        }

        private void StergeConsultatie()
        {
            if (dgvConsultatii.CurrentRow == null) return;
            var consultatie = (Consultatie)dgvConsultatii.CurrentRow.DataBoundItem;
            var rezultat = MessageBox.Show(
                $"Esti sigur ca vrei sa stergi consultatia din {consultatie.Data.ToShortDateString()}?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rezultat == DialogResult.Yes)
            {
                repoConsultatii.Sterge(consultatie.Id);
                IncarcaConsultatii();
            }
        }

        private void DeschideFormularReteta(Reteta reteta)
        {
            var form = new FormularReteta(reteta);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaRetete();
        }

        private void EditeazaReteta()
        {
            if (dgvRetete.CurrentRow == null) return;
            var reteta = (Reteta)dgvRetete.CurrentRow.DataBoundItem;
            DeschideFormularReteta(reteta);
        }

        private void StergeReteta()
        {
            if (dgvRetete.CurrentRow == null) return;
            var reteta = (Reteta)dgvRetete.CurrentRow.DataBoundItem;
            var rezultat = MessageBox.Show(
                $"Esti sigur ca vrei sa stergi reteta din {reteta.DataEliberare.ToShortDateString()}?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rezultat == DialogResult.Yes)
            {
                repoRetete.Sterge(reteta.Id);
                IncarcaRetete();
            }
        }
    }
}