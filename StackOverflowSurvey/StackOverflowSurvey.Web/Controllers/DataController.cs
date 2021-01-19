using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StackOverflowSurvey.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    public class DataController : Controller
    {
        private readonly IAsyncRepository _repository;
        private readonly IConfiguration _configuration;

        public DataController(IAsyncRepository repository,
                              IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        // GET
        public async Task<IActionResult> TransferCount2020()
        {
            // EF Core way
            //var requests = await _repository.Get2020Count();

            // Manual connection way - PRACTICE SQL
            string sqlQuery = "SELECT count(*) FROM SurveyResponses2020";
            var requests = manualConnectionGetCount2020(sqlQuery);
            return View(requests);
        }

        private int manualConnectionGetCount2020(string sqlQuery)
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
