using System;

namespace CabinetMedical.Modele
{
    public class Pacient
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumeComplet => $"{Nume} {Prenume}";
        public string CNP { get; set; }
        public string Telefon { get; set; }
        public DateTime DataNasterii { get; set; }
    }
}
