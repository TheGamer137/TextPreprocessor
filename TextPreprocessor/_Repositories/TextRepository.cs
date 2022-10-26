using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using TextPreprocessor.Models;

namespace TextPreprocessor._Repositories
{
    public class TextRepository : BaseRepository, ITextRepository
    {
        public TextRepository(string connectionString) => this.connectionString = connectionString;
        public void CreateDatabase()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "CREATE DATABASE IF NOT EXISTS SvelTestDB" +
                                      "CREATE TABLE Text" +
                                      "(Id INT NOT NULL AUTOINCREMENT," +
                                      "Word STRING NOT NULL," +
                                      "PRIMARY KEY(Id)";
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfDatabaseExists()
        {
            bool isExists = false;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Text";
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isExists = reader.HasRows;
                    }
                }
            }
            return isExists;
        }

        public bool CheckEncoding(string filename)
        {
            bool isUTF8 = false;
            using (var reader = new StreamReader(filename, Encoding.Default, true))
            {
                if (reader.Peek() >= 0)
                    reader.Read(); 
                isUTF8 = true;
            }

            return isUTF8;
        }

        public void AddWordsToDictionary(Text text)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Text VALUE @word";
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = text.Word;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAllWords()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Text";
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Text> GetAllWords()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Text> GetWordByValue(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}