using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using CabinetMedical.Modele;

namespace CabinetMedical.AccesBD
{
    public class RepositoryPacienti
    {
        public List<Pacient> GetToti()
        {
            var lista = new List<Pacient>();

            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "SELECT Id, Nume, Prenume, CNP, Telefon, DataNasterii FROM Pacienti ORDER BY Id",
                conexiune))
            using (var reader = comanda.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(CitesteRand(reader));
                }
            }

            return lista;
        }

        public void Adauga(Pacient pacient)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                INSERT INTO Pacienti (Nume, Prenume, CNP, Telefon, DataNasterii)
                VALUES (@nume, @prenume, @cnp, @telefon, @dataNasterii)", conexiune))
            {
                AdaugaParametri(comanda, pacient);
                comanda.ExecuteNonQuery();
            }
        }

        public void Modifica(Pacient pacient)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                UPDATE Pacienti
                SET Nume=@nume, Prenume=@prenume, CNP=@cnp,
                    Telefon=@telefon, DataNasterii=@dataNasterii
                WHERE Id=@id", conexiune))
            {
                AdaugaParametri(comanda, pacient);
                comanda.Parameters.AddWithValue("@id", pacient.Id);
                comanda.ExecuteNonQuery();
            }
        }

        public void Sterge(int id)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "DELETE FROM Pacienti WHERE Id=@id", conexiune))
            {
                comanda.Parameters.AddWithValue("@id", id);
                comanda.ExecuteNonQuery();
            }
        }

        private static void AdaugaParametri(SqliteCommand comanda, Pacient pacient)
        {
            comanda.Parameters.AddWithValue("@nume", pacient.Nume);
            comanda.Parameters.AddWithValue("@prenume", pacient.Prenume);
            comanda.Parameters.AddWithValue("@cnp", pacient.CNP ?? (object)DBNull.Value);
            comanda.Parameters.AddWithValue("@telefon", pacient.Telefon ?? (object)DBNull.Value);
            comanda.Parameters.AddWithValue("@dataNasterii", ConexiuneBD.DataInText(pacient.DataNasterii));
        }

        private static Pacient CitesteRand(SqliteDataReader reader)
        {
            return new Pacient
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nume = reader["Nume"].ToString(),
                Prenume = reader["Prenume"].ToString(),
                CNP = reader["CNP"].ToString(),
                Telefon = reader["Telefon"].ToString(),
                DataNasterii = ConexiuneBD.TextInData(reader["DataNasterii"].ToString())
            };
        }
    }
}
