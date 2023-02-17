using Dapper;
using PortalDengue1.Config.V1;
using PortalDengue1.Models.V1;
using PortalDengue1.Repository.V1.Addresses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace PortalDengue1.Repository.V1.Denunciations
{
    public class DenunciationsRepository : IDenunciationsRepository
    {
        private string _conn;

        public DenunciationsRepository()
        {
            _conn = DatabaseConfiguration.Get();
        }

        public bool Add(Complaint complaint)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                complaint.AddressId = new AddressRepository().Add(complaint.Addresses);
                db.Execute(Complaint.INSERT, complaint);
                result = true;
            }
            return result;
        }
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (var db = new SqlConnection(_conn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                db.Open();
                var query = $"SELECT c.Id as 'ID Denuncia'," +
                    $" c.Comment as 'Comentário'," +
                    $" c.Photo as 'Arquivo'," +
                    $" a.ZipCode as 'CEP'," +
                    $" a.PublicPlace as 'Logradouro'," +
                    $" a.District as 'Bairro'," +
                    $" a.State as 'UF'," +
                    $" a.City as 'Cidade' from Complaint c,Addresses a WHERE c.StatusComplaint = 1 AND c.Addresses = a.Id;";
                dataAdapter = new SqlDataAdapter(query, _conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable GetAllValid()
        {
            DataTable dataTable = new DataTable();

            using (var db = new SqlConnection(_conn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                db.Open();
                var query = $"SELECT c.Id as 'ID Denuncia'," +
                    $" c.Comment as 'Comentário'," +
                    $" c.Photo as 'Arquivo'," +
                    $" a.ZipCode as 'CEP'," +
                    $" a.PublicPlace as 'Logradouro'," +
                    $" a.District as 'Bairro'," +
                    $" a.State as 'UF'," +
                    $" a.City as 'Cidade' from Complaint c,Addresses a WHERE c.StatusComplaint = 0 AND c.Addresses = a.Id;";
                dataAdapter = new SqlDataAdapter(query, _conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public bool Delete(string id)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var command = $"DELETE FROM Complaint WHERE Id = '{id}';";
                db.Execute(command, id);
                result = true;
            }
            return result;
        }

        public bool UpdateStatus(string id)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var command = $"UPDATE Complaint SET StatusComplaint = 0 WHERE Id = '{id}';";
                db.Execute(command, id);
                result = true;
            }
            return result;
        }
    }
}