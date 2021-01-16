using Microsoft.EntityFrameworkCore;
using StackOverflowSurvey.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Context
{
    public class StackOverflowSurveyContext : DbContext
    {
        public StackOverflowSurveyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SurveyResponse2011Model> SurveyResponses2011 { get; set; }
    }
}
