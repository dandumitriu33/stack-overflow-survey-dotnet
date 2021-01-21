using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Models
{
    public class DataResponseDTO
    {
        public string CountryName { get; set; }
        public int Year { get; set; }
        public Dictionary<string, int> LanguagesPercent { get; set; }
    }
}
