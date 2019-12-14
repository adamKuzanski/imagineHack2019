using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using backend_ImagineHack2019.Interfaces.Services;
using Microsoft.Extensions.Configuration;

namespace backend_ImagineHack2019.Services
{
    public class DatabaseService: IDatabaseService
    {
        public string connectionString = "";
        public SqlConnection cnn;



        public DatabaseService(IConfiguration configuration)
        {
            connectionString = configuration["Database:ConnectionString"];
            Console.WriteLine(connectionString);
        }

        public void CreateTables()
        {
            using (cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                var command = new SqlCommand(CreateUserTable, cnn);
                Console.WriteLine(CreateUserTable);
                var dataReader = command.ExecuteReader();
                Console.WriteLine(dataReader);
            }

        }
    }
}
