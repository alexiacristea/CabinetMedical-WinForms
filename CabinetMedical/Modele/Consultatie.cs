using System;

namespace CabinetMedical.Modele
{
    public class Consultatie
    {
        public int Id { get; set; }
        public int MedicId { get; set; }
        public int PacientId { get; set; }
        public DateTime Data { get; set; }
        public string Diagnostic { get; set; }
        public decimal Pret { get; set; }
        public string NumeMedic { get; set; }
        public string NumePacient { get; set; }
    }
}