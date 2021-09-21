using CRUD.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CRUD.Database
{
    public static class DatabaseAPI
    {
        public static string DatabaseConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "solstarserver.database.windows.net";
            builder.UserID = "azureuser";
            builder.Password = "Password123";
            builder.InitialCatalog = "MyServer";

            return builder.ConnectionString;            
        }

        public static void Add(Aluno aluno)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {

                String sql = "INSERT INTO Aluno VALUES(";
                sql += "'" + aluno.Name.Trim() + "',";
                sql += "'" + aluno.Birthday.Month + "/" + aluno.Birthday.Day + "/" + aluno.Birthday.Year + "',";
                sql += "'" + aluno.Address.Trim() + "',";
                sql += "'" + aluno.UpdateDate.Month + "/" + aluno.UpdateDate.Day + "/" + aluno.UpdateDate.Year + "')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static Aluno GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {

                String sql = "SELECT * FROM Aluno WHERE Id = ";
                sql += id;

                Aluno aluno = new Aluno();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            aluno.Name = reader.GetString(1);
                            aluno.Birthday = reader.GetDateTime(2);
                            aluno.Address = reader.GetString(3);
                            aluno.UpdateDate = reader.GetDateTime(4);
                        }                        
                    }
                    connection.Close();
                }
                return aluno;
            }
        }

        public static List<Aluno> Get(ref List<int> ids)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {

                String sql = "SELECT * FROM Aluno";

                List<Aluno> alunos = new List<Aluno>();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aluno aluno = new Aluno();
                            aluno.Name = reader.GetString(1);
                            aluno.Birthday = reader.GetDateTime(2);
                            aluno.Address = reader.GetString(3);
                            aluno.UpdateDate = reader.GetDateTime(4);

                            ids.Add(reader.GetInt32(0));
                            alunos.Add(aluno);
                        }
                    }
                    connection.Close();
                }
                return alunos;
            }
        }

        public static void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {

                String sql = "DELETE FROM Aluno WHERE Id = ";
                sql += id;

                Aluno aluno = new Aluno();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
