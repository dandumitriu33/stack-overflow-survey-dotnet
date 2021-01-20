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

        public async Task<string[]> GetAllCountries()
        {
            var countries = await Task.Run(() => getCountriesAsync());
            return countries;
        }

        private string[] getCountriesAsync()
        {
            var countries = new string[]
            { 
              "United States", "India", "United Kingdom", "Germany", "Canada", "France", "Brazil", "Netherlands", "Poland", "Australia",
              "Spain", "Italy", "Russia", "Sweden", "Pakistan", "Turkey", "Israel", "Switzerland", "Bangladesh", "Romania",
              "Nigeria", "Mexico", "Austria", "Ukraine", "Czech Republic", "Indonesia", "South Africa", "Iran", "Belgium", "Ireland",
              "Philippines", "Denmark", "Argentina", "Greece", "Portugal", "Norway", "Hungary", "China", "Vietnam", "New Zealand",
              "Finland", "Bulgaria", "Serbia", "Japan", "Sri Lanka", "Colombia", "Egypt", "Kenya", "Nepal", "Malaysia",
              "Singapore", "South Korea", "Slovakia", "Croatia", "Chile", "Morocco", "Lithuania", "Taiwan", "Slovenia", "Thailand",
              "Estonia", "Belarus", "Tunisia", "United Arab Emirates", "Hong Kong", "Latvia", "Ghana", "Peru", "Uruguay", "Bosnia and Herzegovina",
              "Algeria", "Saudi Arabia", "Afghanistan", "Uganda", "Costa Rica", "Dominican Republic", "Lebanon", "Venezuela", "Georgia", "Armenia",
              "Kazakhstan", "Ethiopia", "Jordan", "Albania", "Iceland", "Myanmar", "Cyprus", "Cameroon", "Azerbaijan", "Moldova",
              "Guatemala", "Ecuador", "Malta", "Iraq", "Luxembourg"
            };
            return countries;
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
