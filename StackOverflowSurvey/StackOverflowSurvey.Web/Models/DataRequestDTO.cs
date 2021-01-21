using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Models
{
    public class DataRequestDTO
    {
        public string CountryName { get; set; }
        public List<string> Languages { get; set; }
    }
}
