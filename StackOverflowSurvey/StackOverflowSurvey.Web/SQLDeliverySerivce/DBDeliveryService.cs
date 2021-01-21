using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StackOverflowSurvey.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<List<DataResponseDTO>> GetDataForCountry(DataRequestDTO dataRequestDTO)
        {
            var data = await Task.Run(() => getDataForCountryFromDb(dataRequestDTO));
            return data;
        }

        private List<DataResponseDTO> getDataForCountryFromDb(DataRequestDTO dataRequestDTO)
        {
            List<DataResponseDTO> result = new List<DataResponseDTO>();
            string sqlQuery = buildDataRequestQuery(dataRequestDTO);
            try
            {
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
                                DataResponseDTO tempEntry = new DataResponseDTO
                                {
                                    CountryName = reader.GetString(0),
                                    Year = Convert.ToInt32(reader.GetString(1))
                                };
                                Dictionary<string, int> langsDictionary = new Dictionary<string, int>();
                                for (int i = 0; i < dataRequestDTO.Languages.Count; i++)
                                {
                                    langsDictionary.Add(dataRequestDTO.Languages[i], reader.GetInt32(i + 2));
                                };
                                tempEntry.LanguagesPercent = langsDictionary;
                                result.Add(tempEntry);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                result = new List<DataResponseDTO>();
            }
            return result;
        }

        private string buildDataRequestQuery(DataRequestDTO dataRequestDTO)
        {
            string countryName = dataRequestDTO.CountryName;
            string alternateCountryName = getAlternateCountryName(countryName);
            int[] years = { 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
            StringBuilder sb = new StringBuilder();            
            foreach (var year in years)
            {
                sb.Append("SELECT Country,");
                sb.Append($"'{year}' as SurveyYear,");
                for (int i = 0; i < dataRequestDTO.Languages.Count; i++)
                {
                    string language = dataRequestDTO.Languages[i];
                    if (language.Equals("CPlusPlus"))
                    {
                        sb.Append($@"(
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE (Country = '{countryName}' OR Country = '{alternateCountryName}') AND LanguagePro{language} = 'C++') * 100 /
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE Country = '{countryName}' OR Country = '{alternateCountryName}')
		                )
		                as '{language}_Percent'");
                    }
                    else if (language.Equals("CSharp"))
                    {
                        sb.Append($@"(
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE (Country = '{countryName}' OR Country = '{alternateCountryName}') AND LanguagePro{language} = 'C#') * 100 /
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE Country = '{countryName}' OR Country = '{alternateCountryName}')
		                )
		                as '{language}_Percent'");
                    }
                    else if (language.Equals("ObjectiveC"))
                    {
                        sb.Append($@"(
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE (Country = '{countryName}' OR Country = '{alternateCountryName}') AND LanguagePro{language} = 'Objective-C') * 100 /
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE Country = '{countryName}' OR Country = '{alternateCountryName}')
		                )
		                as '{language}_Percent'");
                    }
                    else
                    {
                        sb.Append($@"(
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE (Country = '{countryName}' OR Country = '{alternateCountryName}') AND LanguagePro{language} = '{language}') * 100 /
		                (SELECT COUNT(*) FROM SurveyResponses{year} WHERE Country = '{countryName}' OR Country = '{alternateCountryName}')
		                )
		                as '{language}_Percent'
                        ");
                    }
                    
                    if (i < dataRequestDTO.Languages.Count - 1)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append($"FROM SurveyResponses{year} WHERE Country = '{countryName}' OR Country = '{alternateCountryName}'");
                if (year != 2020)
                {
                    sb.Append("UNION ");
                }
            }
            sb.Append("GROUP BY Country ORDER BY SurveyYear");
            string dataQuery = sb.ToString();
            return dataQuery;
        }

        private string getAlternateCountryName(string countryName)
        {
            string[] sameName = new string[] { "United States", "India", "United Kingdom", "Germany", "Canada", "France", 
                                               "Netherlands", "Australia", "Italy", "Russia", "Bangladesh", "Mexico" };
            string[] southAmericaArray = new string[] { "Brazil", "Colombia", "Chile", "Peru", "Uruguay", "Venezuela", "Ecuador", 
                                                        "Argentina", "Venezuela" };
            string[] otherEuropeArray = new string[] { "Poland", "Spain", "Sweden", "Turkey", "Switzerland", "Romania", "Austria",
                                                       "Ukraine", "Czech Republic", "Belgium", "Ireland", "Denmark", "Greece",
                                                       "Portugal", "Norway", "Hungary", "Finland", "Bulgaria", "Serbia", "Slovakia",
                                                       "Croatia", "Lithuania", "Slovenia", "Estonia", "Latvia", "Bosnia and Herzegovina",
                                                       "Georgia", "Armenia", "Kazakhstan", "Albania", "Iceland", "Cyprus", "Azerbaijan",
                                                       "Moldova", "Malta", "Luxembourg", "Belarus"};
            string[] otherAsiaArray = new string[] { "Pakistan", "Indonesia", "Philippines", "China", "Vietnam", "Japan", "Sri Lanka",
                                                     "Nepal", "Malaysia", "Singapore", "South Korea", "Taiwan", "Thailand", "Hong Kong",
                                                     "Afghanistan", "Myanmar" };
            string[] middleEastArray = new string[] { "Israel", "Iran", "Egypt", "United Arab Emirates", "Saudi Arabia", "Lebanon",
                                                      "Jordan", "Iraq"};
            string[] africaArray = new string[] { "Nigeria", "South Africa", "Kenya", "Morocco", "Tunisia", "Ghana", "Algeria", "Uganda",
                                                  "Ethiopia", "Cameroon"};
            string[] australasiaArray = new string[] { "New Zealand" };
            string[] centralAmericaArray = new string[] { "Costa Rica", "Guatemala" };
            string[] northAmericaOtherArray = new string[] { "Dominican Republic" };
            if (sameName.Contains(countryName) )
            {
                return countryName;
            }
            else if (southAmericaArray.Contains(countryName))
            {
                return "South America";
            }
            else if (otherEuropeArray.Contains(countryName))
            {
                return "Other Europe";
            }
            else if (otherAsiaArray.Contains(countryName))
            {
                return "Other Asia";
            }
            else if (middleEastArray.Contains(countryName))
            {
                return "Middle East";
            }
            else if (africaArray.Contains(countryName))
            {
                return "Africa";
            }
            else if (australasiaArray.Contains(countryName))
            {
                return "Australasia";
            }
            else if (centralAmericaArray.Contains(countryName))
            {
                return "Central America";
            }
            else if (northAmericaOtherArray.Contains(countryName))
            {
                return "North America (Other)";
            }
            return "";
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
