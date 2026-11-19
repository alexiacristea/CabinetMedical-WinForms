namespace CabinetMedical.Modele
{
    public class Medic
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumeComplet => $"{Nume} {Prenume}";
        public string Specializare { get; set; }
        public string Telefon { get; set; }
    }
}