using System.Data;
using DotNetBatch14HZYK.ConsoleApp3.AdoDotNetExamples;
using DotNetBatch14HZYK.ConsoleApp3.DapperExamples;
using DotNetBatch14HZYK.ConsoleApp3.EFCoreExamples;
using Microsoft.Data.SqlClient;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Edit("0930A539-4BF4-4914-A558-EDA61FC2BCA1");
//adoDotNetExample.Edit("0930A539-4BF4-4914-A558-EDA61FC2BCA2");
//adoDotNetExample.Create("test1", "test2", "test3");
//adoDotNetExample.Delete("EAA03043-63E1-4797-BD7F-A83CAA4E1AFA");
//adoDotNetExample.Update("E9CF852B-52EC-4C3E-B6B1-CC0B6523D28C", "UpdatedBlogTitle", "UpdatedBlogAuthor", "UpdatedBlogContent");

//DapperExample dapperExample = new DapperExample();
//dapperExample.Read();
//dapperExample.Create("test1 2", "test2 3", "test3 4");
//dapperExample.Edit("47EC315B-96F9-48EA-95E0-6F8BC78434DD" );
//dapperExample.Edit("9400B1E5-2350-4876-B3DE-22DB602D0EA3");
//dapperExample.Update("E9CF852B-52EC-4C3E-B6B1-CC0B6523D28C", "11UpdatedBlogTitle", "22UpdatedBlogAuthor", "33UpdatedBlogContent");
//dapperExample.Delete("BA423130-34C9-406D-A0FB-D24D541B839A");

EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Read();
//eFCoreExample.Edit("AEBB2ED7-28B5-4AD7-8FC0-85D89C782995");
//eFCoreExample.Edit("AFA16229-EDA2-458E-86E2-75A457300064");
//eFCoreExample.Create("EFCtest1", "EFCtest2", "EFCtest3");
//eFCoreExample.Delete("e0fa7096-0b41-420b-bcd8-644303324205");
//eFCoreExample.Update("AEBB2ED7-28B5-4AD7-8FC0-85D89C782995", "11UpdatedBlogTitle", "22UpdatedBlogAuthor", "33UpdatedBlogContent");