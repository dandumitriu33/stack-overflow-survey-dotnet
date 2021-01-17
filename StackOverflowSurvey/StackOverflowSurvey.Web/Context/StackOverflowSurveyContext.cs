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
        public DbSet<SurveyResponse2012Model> SurveyResponses2012 { get; set; }
        public DbSet<SurveyResponse2013Model> SurveyResponses2013 { get; set; }
        public DbSet<SurveyResponse2014Model> SurveyResponses2014 { get; set; }
        public DbSet<SurveyResponse2015Model> SurveyResponses2015 { get; set; }
        public DbSet<SurveyResponse2016Model> SurveyResponses2016 { get; set; }
        public DbSet<SurveyResponse2017Model> SurveyResponses2017 { get; set; }
        public DbSet<SurveyResponse2018Model> SurveyResponses2018 { get; set; }
    }
}
