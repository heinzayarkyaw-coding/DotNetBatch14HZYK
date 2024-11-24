using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DotNetBatch14HZYK.ConsoleApp4.Dtos;
using DotNetBatch14HZYK.ConsoleApp4;
using Microsoft.Data.SqlClient;

namespace DotNetBatch14HZYK.ConsoleApp4.DapperExamples;
public class DapperExample
{

    private readonly string _connectionString = AppSettings.SqlConnectionStringBuilder.ConnectionString;

    public void Read()
    {
        using IDbConnection connection = new SqlConnection(_connectionString);

        List<BlogDto> lst = connection
             .Query<BlogDto>("select * from tbl_blog")
             .ToList();

        foreach (BlogDto item in lst)
        {
            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogContent);
        }
    }

    public void Edit(string id)
    {
        using IDbConnection connection = new SqlConnection(_connectionString);

        var item = connection
             .Query<BlogDto>($"select * from tbl_blog where BlogId = '{id}'")
             .FirstOrDefault();

        //if(item == null)
        if (item is null)
        {
            Console.WriteLine("No data found.");
            return;
        }

        Console.WriteLine(item.BlogId);
        Console.WriteLine(item.BlogTitle);
        Console.WriteLine(item.BlogAuthor);
        Console.WriteLine(item.BlogContent);
    }

    public void Create(string title, string author, string content)
    {
        string query = $@"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
     VALUES
           ('{title}'
           ,'{author}'
           ,'{content}')";

        using IDbConnection connection = new SqlConnection(_connectionString);
        var result = connection.Execute(query);

        string message = result > 0 ? "Saving Successful." : "Saving Failed.";
        Console.WriteLine(message);
    }

    public void Update(string id, string newTitle, string newAuthor, string newContent)
    {
        string query = @"UPDATE [dbo].[Tbl_Blog]
                             SET BlogTitle = @Title,
                                 BlogAuthor = @Author,
                                 BlogContent = @Content
                             WHERE BlogId = @Id";

        using IDbConnection connection = new SqlConnection(_connectionString);
        var result = connection.Execute(query, new { Id = id, Title = newTitle, Author = newAuthor, Content = newContent });

        string message = result > 0 ? $"Update Successful for BlogId {id}" : $"Update Failed for BlogId {id}.";
        Console.WriteLine(message);
    }

    public void Delete(string id)
    {
        string query = @"DELETE FROM [dbo].[Tbl_Blog]
                             WHERE BlogId = @Id";

        using IDbConnection connection = new SqlConnection(_connectionString);
        var result = connection.Execute(query, new { Id = id });

        string message = result > 0 ? $"Deletion Successful for BlogId {id}" : $"Deletion Failed for BlogId {id}.";
        Console.WriteLine(message);
    }
}