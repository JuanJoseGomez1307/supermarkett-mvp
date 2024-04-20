using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using supermarkett_mvp.Models;

namespace supermarkett_mvp._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoriesModel categoriesModel)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
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
                command.CommandText = "DELETE FROM Categories WHERE Categorie_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories 
                                        SET Categorie_Name = @name, 
                                        Categorie_Observation = @observation 
                                        WHERE Categorie_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            //throw new NotImplementedException();
            var categoriesList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Categorie_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categorie_Id"];
                        categoriesModel.Name = reader["Categorie_Name"].ToString();
                        categoriesModel.Observation = reader["Categorie_Observation"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }
            return categoriesList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            //throw new NotImplementedException();
            var categoriesList = new List<CategoriesModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories 
                                        WHERE Categorie_Id=@id or Categorie_Name LIKE @name+ '%'
                                        ORDER BY Categorie_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categorie_Id"];
                        categoriesModel.Name = reader["Categorie_Name"].ToString();
                        categoriesModel.Observation = reader["Categorie_Observation"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }

            return categoriesList;
        }
    }
}
