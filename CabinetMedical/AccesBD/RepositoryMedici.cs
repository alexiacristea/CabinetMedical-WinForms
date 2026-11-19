using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using CabinetMedical.Modele;

namespace CabinetMedical.AccesBD
{
    public class RepositoryMedici
    {
        public List<Medic> GetToti()
        {
            var lista = new List<Medic>();

            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "SELECT Id, Nume, Prenume, Specializare, Telefon FROM Medici ORDER BY Id",
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

        public void Adauga(Medic medic)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                INSERT INTO Medici (Nume, Prenume, Specializare, Telefon)
                VALUES (@nume, @prenume, @specializare, @telefon)", conexiune))
            {
                AdaugaParametri(comanda, medic);
                comanda.ExecuteNonQuery();
            }
        }

        public void Modifica(Medic medic)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                UPDATE Medici
                SET Nume=@nume, Prenume=@prenume,
                    Specializare=@specializare, Telefon=@telefon
                WHERE Id=@id", conexiune))
            {
                AdaugaParametri(comanda, medic);
                comanda.Parameters.AddWithValue("@id", medic.Id);
                comanda.ExecuteNonQuery();
            }
        }

        public void Sterge(int id)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "DELETE FROM Medici WHERE Id=@id", conexiune))
            {
                comanda.Parameters.AddWithValue("@id", id);
                comanda.ExecuteNonQuery();
            }
        }

        private static void AdaugaParametri(SqliteCommand comanda, Medic medic)
        {
            comanda.Parameters.AddWithValue("@nume", medic.Nume);
            comanda.Parameters.AddWithValue("@prenume", medic.Prenume);
            comanda.Parameters.AddWithValue("@specializare", medic.Specializare);
            comanda.Parameters.AddWithValue("@telefon", medic.Telefon ?? (object)DBNull.Value);
        }

        private static Medic CitesteRand(SqliteDataReader reader)
        {
            return new Medic
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nume = reader["Nume"].ToString(),
                Prenume = reader["Prenume"].ToString(),
                Specializare = reader["Specializare"].ToString(),
                Telefon = reader["Telefon"].ToString()
            };
        }
    }
}
