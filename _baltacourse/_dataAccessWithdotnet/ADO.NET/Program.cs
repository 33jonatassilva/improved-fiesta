﻿using System;
using Microsoft.Data.SqlClient;

namespace ADO.NET
{
    class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True";
        
        using(var connection = new SqlConnection(connectionString))
        {
            System.Console.WriteLine("Conectado");
            connection.Open();
            using(var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                var reader = command.ExecuteReader();

                while(reader.Read())
                {
                    System.Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }
            }
        }



    }
}
}
