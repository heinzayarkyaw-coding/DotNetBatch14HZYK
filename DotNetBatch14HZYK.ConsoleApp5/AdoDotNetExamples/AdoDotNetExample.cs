using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DotNetBatch14HZYK.ConsoleApp5.AdoDotNetExamples
{
    public class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "LAPTOP-MMRAUNPQ",
            InitialCatalog = "TextDb",
            UserID = "sa",
            Password = "Hlay1082001",
            TrustServerCertificate = true
        };

        public void Read()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            connection.Open();


            SqlCommand cmd = new SqlCommand("select * from tbl_blog", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["BlogId"]);
                Console.WriteLine(row["BlogTitle"]);
                Console.WriteLine(row["BlogAuthor"]);
                Console.WriteLine(row["BlogContent"]);
            }
        }


        public void Edit(string id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand($"select * from tbl_blog where BlogId = '{id}'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("No Data Found.");
                return;
            }

            DataRow row = dt.Rows[0];

            Console.WriteLine(row["BlogId"]);
            Console.WriteLine(row["BlogTitle"]);
            Console.WriteLine(row["BlogAuthor"]);
            Console.WriteLine(row["BlogContent"]);

        }

        public void Create(string Title, string Author, string Content)
        {
            string query = $@"INSERT INTO [dbo].[tbl_blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
        VALUES
              ('{Title}'
              ,'{Author}'
              ,'{Content}')";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

        public void Delete(string id)
        {
            string query = $"DELETE FROM tbl_blog WHERE BlogId = '{id}'";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? $"Deletion Successful for BlogId {id}" : $"Deletion Failed for BlogId {id}.";
            Console.WriteLine(message);
        }



        public void Update(string id, string newTitle, string newAuthor, string newContent)
        {
            string query = @"UPDATE [dbo].[tbl_blog]
                     SET BlogTitle = @Title,
                         BlogAuthor = @Author,
                         BlogContent = @Content
                     WHERE BlogId = @Id";

            using (SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Title", newTitle);
                    cmd.Parameters.AddWithValue("@Author", newAuthor);
                    cmd.Parameters.AddWithValue("@Content", newContent);

                    int result = cmd.ExecuteNonQuery();

                    string message = result > 0 ? $"Update Successful for BlogId {id}" : $"Update Failed for BlogId {id}.";
                    Console.WriteLine(message);
                }
            }
        }



    }
}
