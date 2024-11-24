// See https://aka.ms/new-console-template for more information
using System.Data;
using DotNetBatch14HZYK.ConsoleApp2.AdoDotNetExamples;
using DotNetBatch14HZYK.ConsoleApp2.DapperExamples;
using DotNetBatch14HZYK.ConsoleApp2.EFCoreExamples;
using Microsoft.Data.SqlClient;


Console.WriteLine("Hello, World!");

// N Layer Architecture


// ADO.NET
// Dapper (ORM)
// EFCore (ORM)

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
//{
//    DataSource = ".",
//    InitialCatalog = "TestDb",
//    UserID = "sa",
//    Password = "sasa@123"
//};
//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
//connection.Open();

//SqlCommand cmd = new SqlCommand("select * from tbl_blog", connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);

//connection.Close();

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Edit("0930A539-4BF4-4914-A558-EDA61FC2BCA1");
//adoDotNetExample.Edit("0930A539-4BF4-4914-A558-EDA61FC2BCA2");
//adoDotNetExample.Create("test1", "test2", "test3");
//adoDotNetExample.Delete("AE71EAC4-6F23-46DE-A0FE-7E3A60CB06F4");
//adoDotNetExample.Update("AE71EAC4-6F23-46DE-A0FE-7E3A60CB06F4", "1UpdatedBlogTitle", "2UpdatedBlogAuthor", "3UpdatedBlogContent");

//DapperExample dapperExample = new DapperExample();
//dapperExample.Read();
//dapperExample.Create("test112", "test223", "test334");
//dapperExample.Edit("47EC315B-96F9-48EA-95E0-6F8BC78434DD" );
//dapperExample.Edit("9400B1E5-2350-4876-B3DE-22DB602D0EA3");
//dapperExample.Update("E9CF852B-52EC-4C3E-B6B1-CC0B6523D28C", "11UpdatedBlogTitle", "22UpdatedBlogAuthor", "33UpdatedBlogContent");
//dapperExample.Delete("BA423130-34C9-406D-A0FB-D24D541B839A");


EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Read();
eFCoreExample.Create("EFtest1", "EFtest2", "EFtest3");
eFCoreExample.Update("A9B45D8C-BCC4-4119-9C33-A40BBD579DAC", "11UpdatedBlogTitle", "22UpdatedBlogAuthor", "33UpdatedBlogContent");
eFCoreExample.Delete("B37E6982-7483-4C3C-8A8A-8C7F4CA48344");