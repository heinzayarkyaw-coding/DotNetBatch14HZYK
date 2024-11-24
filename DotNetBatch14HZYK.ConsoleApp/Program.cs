using Microsoft.Data.SqlClient;
using System.Data;

SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
connectionStringBuilder.DataSource = "LAPTOP-MMRAUNPQ"; //severname
connectionStringBuilder.InitialCatalog = "Textdb"; //database name
connectionStringBuilder.UserID = "sa";
connectionStringBuilder.Password = "Hlay1082001";
connectionStringBuilder.TrustServerCertificate = true;

SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString);
Console.WriteLine("Connecting Opening...");
connection.Open();
Console.WriteLine("Connecting Open.");

Console.WriteLine("Connecting Closing...");
connection.Close();
Console.WriteLine("Connecting Close.");

//Ctrl+.


Console.ReadLine();


string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
adapter.Fill(dt);

connection.Close();


//DataTable
//DataRow
//DataColumn

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine(dr["BlogID"]);
    Console.WriteLine(dr["BlogTitle"]);
    Console.WriteLine(dr["BlogAuthor"]);
    Console.WriteLine(dr["BlogContent"]);
}


Console.ReadLine();



//Blog

//ID
//Title

//Author
//Content




//MSSQL


Console.WriteLine("Hello World.");

