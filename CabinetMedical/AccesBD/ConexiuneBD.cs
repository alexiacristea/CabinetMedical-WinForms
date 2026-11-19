using System;
using System.Globalization;
using System.IO;
using Microsoft.Data.Sqlite;

namespace CabinetMedical.AccesBD
{
    public static class ConexiuneBD
    {
        // Baza de date se creeaza langa executabil, indiferent de folderul curent.
        private static readonly string CaleFisier =
            Path.Combine(AppContext.BaseDirectory, "cabinet.db");

        // "Foreign Keys=True" activeaza verificarea cheilor straine.
        // SQLite le ignora implicit, deci fara asta s-ar putea sterge
        // un medic care inca are consultatii.
        private static string StringConexiune =>
            $"Data Source={CaleFisier};Foreign Keys=True";

        public const string FormatData = "yyyy-MM-dd";

        public static SqliteConnection Deschide()
        {
            var conexiune = new SqliteConnection(StringConexiune);
            conexiune.Open();
            return conexiune;
        }

        public static string DataInText(DateTime data) =>
            data.ToString(FormatData, CultureInfo.InvariantCulture);

        public static DateTime TextInData(string text) =>
            DateTime.ParseExact(text, FormatData, CultureInfo.InvariantCulture);

        public static void Initializeaza()
        {
            using (var conexiune = Deschide())
            using (var comanda = conexiune.CreateCommand())
            {
                comanda.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Medici (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nume TEXT NOT NULL,
                        Prenume TEXT NOT NULL,
                        Specializare TEXT NOT NULL,
                        Telefon TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Pacienti (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nume TEXT NOT NULL,
                        Prenume TEXT NOT NULL,
                        CNP TEXT,
                        Telefon TEXT,
                        DataNasterii TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Retete (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MedicId INTEGER NOT NULL,
                        PacientId INTEGER NOT NULL,
                        Medicamente TEXT NOT NULL,
                        DataEliberare TEXT NOT NULL,
                        FOREIGN KEY (MedicId) REFERENCES Medici(Id),
                        FOREIGN KEY (PacientId) REFERENCES Pacienti(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Consultatii (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MedicId INTEGER NOT NULL,
                        PacientId INTEGER NOT NULL,
                        Data TEXT NOT NULL,
                        Diagnostic TEXT NOT NULL,
                        Pret REAL NOT NULL,
                        FOREIGN KEY (MedicId) REFERENCES Medici(Id),
                        FOREIGN KEY (PacientId) REFERENCES Pacienti(Id)
                    );";
                comanda.ExecuteNonQuery();
            }
        }
    }
}
