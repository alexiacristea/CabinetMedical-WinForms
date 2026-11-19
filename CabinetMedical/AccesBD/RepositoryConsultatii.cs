using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using CabinetMedical.Modele;

namespace CabinetMedical.AccesBD
{
    public class RepositoryConsultatii
    {
        public List<Consultatie> GetToate()
        {
            var lista = new List<Consultatie>();

            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                SELECT c.Id, c.MedicId, c.PacientId, c.Data, c.Diagnostic, c.Pret,
                       m.Nume || ' ' || m.Prenume AS NumeMedic,
                       p.Nume || ' ' || p.Prenume AS NumePacient
                FROM Consultatii c
                JOIN Medici m ON c.MedicId = m.Id
                JOIN Pacienti p ON c.PacientId = p.Id
                ORDER BY c.Id", conexiune))
            using (var reader = comanda.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(CitesteRand(reader));
                }
            }

            return lista;
        }

        public void Adauga(Consultatie consultatie)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                INSERT INTO Consultatii (MedicId, PacientId, Data, Diagnostic, Pret)
                VALUES (@medicId, @pacientId, @data, @diagnostic, @pret)", conexiune))
            {
                AdaugaParametri(comanda, consultatie);
                comanda.ExecuteNonQuery();
            }
        }

        public void Modifica(Consultatie consultatie)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                UPDATE Consultatii
                SET MedicId=@medicId, PacientId=@pacientId, Data=@data,
                    Diagnostic=@diagnostic, Pret=@pret
                WHERE Id=@id", conexiune))
            {
                AdaugaParametri(comanda, consultatie);
                comanda.Parameters.AddWithValue("@id", consultatie.Id);
                comanda.ExecuteNonQuery();
            }
        }

        public void Sterge(int id)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "DELETE FROM Consultatii WHERE Id=@id", conexiune))
            {
                comanda.Parameters.AddWithValue("@id", id);
                comanda.ExecuteNonQuery();
            }
        }

        private static void AdaugaParametri(SqliteCommand comanda, Consultatie consultatie)
        {
            comanda.Parameters.AddWithValue("@medicId", consultatie.MedicId);
            comanda.Parameters.AddWithValue("@pacientId", consultatie.PacientId);
            comanda.Parameters.AddWithValue("@data", ConexiuneBD.DataInText(consultatie.Data));
            comanda.Parameters.AddWithValue("@diagnostic", consultatie.Diagnostic);
            comanda.Parameters.AddWithValue("@pret", (double)consultatie.Pret);
        }

        private static Consultatie CitesteRand(SqliteDataReader reader)
        {
            return new Consultatie
            {
                Id = Convert.ToInt32(reader["Id"]),
                MedicId = Convert.ToInt32(reader["MedicId"]),
                PacientId = Convert.ToInt32(reader["PacientId"]),
                Data = ConexiuneBD.TextInData(reader["Data"].ToString()),
                Diagnostic = reader["Diagnostic"].ToString(),
                Pret = Convert.ToDecimal(reader["Pret"]),
                NumeMedic = reader["NumeMedic"].ToString(),
                NumePacient = reader["NumePacient"].ToString()
            };
        }
    }
}
