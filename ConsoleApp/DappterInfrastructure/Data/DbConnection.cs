using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DappterInfrastructure.Data
{
    internal class DbConnection
    {
        public SqlConnection GetConnection()
        {
            var connStr = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build()
                            .GetConnectionString("AprilBatchDb");

            return new SqlConnection(connStr);
        }
    }
}
