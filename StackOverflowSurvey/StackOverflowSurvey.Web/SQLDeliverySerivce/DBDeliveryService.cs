using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.SQLDeliverySerivce
{
    public class DBDeliveryService : ISQLDeliveryService
    {
        private readonly IConfiguration _configuration;

        public DBDeliveryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> rowCount(string sqlQuery)
        {
            var rowCount = await Task.Run(() => rowCountQuery(sqlQuery));
            return rowCount;            
        }

        private int rowCountQuery(string sqlQuery)
        {
            int responses2020Count = 0;
            try
            {
                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                //builder.DataSource = "<your_server.database.windows.net>";
                //builder.UserID = "<your_username>";
                //builder.Password = "<your_password>";
                //builder.InitialCatalog = "<your_database>";

                string conString = ConfigurationExtensions.GetConnectionString(_configuration, "Default");

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                responses2020Count = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                responses2020Count = 123;
            }
            return responses2020Count;
        }
    }
}
