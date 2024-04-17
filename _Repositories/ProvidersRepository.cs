using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using supermarkett_mvp.Models;
using System.Data;
using supermarkett_mvp.Models;

namespace supermarkett_mvp._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {
        public ProvidersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProvidersModel providersModel)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providersModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProvidersModel providersModel)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers 
                                        SET Provider_Name = @name, 
                                        Provider_Observation = @observation 
                                        WHERE Provider_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providersModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providersList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["Provider_Id"];
                        providersModel.Name = reader["Provider_Name"].ToString();
                        providersModel.Observation = reader["Provider_Observation"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersList = new List<ProvidersModel>();
            int providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers 
                                        WHERE Provider_Id=@id or Provider_Name LIKE @name+ '%'
                                        ORDER BY Provider_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["Provider_Id"];
                        providersModel.Name = reader["Provider_Name"].ToString();
                        providersModel.Observation = reader["Provider_Observation"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }

            return providersList;
        }
    }
}
