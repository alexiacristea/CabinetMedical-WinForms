using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using CabinetMedical.Modele;

namespace CabinetMedical.AccesBD
{
    public class RepositoryRetete
    {
        public List<Reteta> GetToate()
        {
            var lista = new List<Reteta>();

            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                SELECT r.Id, r.MedicId, r.PacientId, r.Medicamente, r.DataEliberare,
                       m.Nume || ' ' || m.Prenume AS NumeMedic,
                       p.Nume || ' ' || p.Prenume AS NumePacient
                FROM Retete r
                JOIN Medici m ON r.MedicId = m.Id
                JOIN Pacienti p ON r.PacientId = p.Id
                ORDER BY r.Id", conexiune))
            using (var reader = comanda.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(CitesteRand(reader));
                }
            }

            return lista;
        }

        public void Adauga(Reteta reteta)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                INSERT INTO Retete (MedicId, PacientId, Medicamente, DataEliberare)
                VALUES (@medicId, @pacientId, @medicamente, @dataEliberare)", conexiune))
            {
                AdaugaParametri(comanda, reteta);
                comanda.ExecuteNonQuery();
            }
        }

        public void Modifica(Reteta reteta)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(@"
                UPDATE Retete
                SET MedicId=@medicId, PacientId=@pacientId,
                    Medicamente=@medicamente, DataEliberare=@dataEliberare
                WHERE Id=@id", conexiune))
            {
                AdaugaParametri(comanda, reteta);
                comanda.Parameters.AddWithValue("@id", reteta.Id);
                comanda.ExecuteNonQuery();
            }
        }

        public void Sterge(int id)
        {
            using (var conexiune = ConexiuneBD.Deschide())
            using (var comanda = new SqliteCommand(
                "DELETE FROM Retete WHERE Id=@id", conexiune))
            {
                comanda.Parameters.AddWithValue("@id", id);
                comanda.ExecuteNonQuery();
            }
        }

        private static void AdaugaParametri(SqliteCommand comanda, Reteta reteta)
        {
            comanda.Parameters.AddWithValue("@medicId", reteta.MedicId);
            comanda.Parameters.AddWithValue("@pacientId", reteta.PacientId);
            comanda.Parameters.AddWithValue("@medicamente", reteta.Medicamente);
            comanda.Parameters.AddWithValue("@dataEliberare", ConexiuneBD.DataInText(reteta.DataEliberare));
        }

        private static Reteta CitesteRand(SqliteDataReader reader)
        {
            return new Reteta
            {
                Id = Convert.ToInt32(reader["Id"]),
                MedicId = Convert.ToInt32(reader["MedicId"]),
                PacientId = Convert.ToInt32(reader["PacientId"]),
                Medicamente = reader["Medicamente"].ToString(),
                DataEliberare = ConexiuneBD.TextInData(reader["DataEliberare"].ToString()),
                NumeMedic = reader["NumeMedic"].ToString(),
                NumePacient = reader["NumePacient"].ToString()
            };
        }
    }
}
