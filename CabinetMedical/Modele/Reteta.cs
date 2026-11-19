using System;

namespace CabinetMedical.Modele
{
    public class Reteta
    {
        public int Id { get; set; }
        public int MedicId { get; set; }
        public int PacientId { get; set; }
        public string Medicamente { get; set; }
        public DateTime DataEliberare { get; set; }
        public string NumeMedic { get; set; }
        public string NumePacient { get; set; }
    }
}