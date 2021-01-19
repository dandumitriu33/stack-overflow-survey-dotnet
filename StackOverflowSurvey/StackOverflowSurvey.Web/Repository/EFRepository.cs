using Microsoft.EntityFrameworkCore;
using StackOverflowSurvey.Web.Context;
using StackOverflowSurvey.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Repository
{
    public class EFRepository : IAsyncRepository
    {
        private readonly StackOverflowSurveyContext _context;

        public EFRepository(StackOverflowSurveyContext context)
        {
            _context = context;
        }

        public async Task Add2011Response(SurveyResponse2011Model response)
        {
            await _context.SurveyResponses2011.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2012Response(SurveyResponse2012Model response)
        {
            await _context.SurveyResponses2012.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2013Response(SurveyResponse2013Model response)
        {
            await _context.SurveyResponses2013.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2014Response(SurveyResponse2014Model response)
        {
            await _context.SurveyResponses2014.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2015Response(SurveyResponse2015Model response)
        {
            await _context.SurveyResponses2015.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2016Response(SurveyResponse2016Model response)
        {
            await _context.SurveyResponses2016.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2017Response(SurveyResponse2017Model response)
        {
            await _context.SurveyResponses2017.AddAsync(response);
            await _context.SaveChangesAsync();
        }

        public async Task Add2018ResponsesBatch(List<SurveyResponse2018Model> batch)
        {
            foreach (var response in batch)
            {
                await _context.SurveyResponses2018.AddAsync(response);
            }
            await _context.SaveChangesAsync();
        }

        public async Task Add2019ResponsesBatch(List<SurveyResponse2019Model> batch)
        {
            foreach (var response in batch)
            {
                await _context.SurveyResponses2019.AddAsync(response);
            }
            await _context.SaveChangesAsync();
        }

        public async Task Add2020ResponsesBatch(List<SurveyResponse2020Model> batch)
        {
            foreach (var response in batch)
            {
                await _context.SurveyResponses2020.AddAsync(response);
            }
            await _context.SaveChangesAsync();
        }

        public SurveyResponse2020Model GetResponse2020ById(int id)
        {
            return _context.SurveyResponses2020
                           .FromSqlRaw<SurveyResponse2020Model>("spGetResponseById {0}", id)
                           .ToList()
                           .FirstOrDefault();
        }

        //public List<SurveyResponse2020Model> Get2020Count()
        //{
        //    var result = _context.SurveyResponses2020.FromSqlRaw<SurveyResponse2020Model>("exec spTestCount2020a").ToList();
        //    return result;
        //}

        public async Task<int> Get2020Count()
        {
            // LINQ
            //return await _context.SurveyResponses2020.CountAsync();

            // RAW SQL + LINQ - limitation on RAW - must return data for all properties of the entity type
            // can't return a simple INT, the result of the count
            // https://docs.microsoft.com/en-us/ef/core/querying/raw-sql#limitations
            var sql = "SELECT * FROM SurveyResponses2020";
            var queryResult = await _context.SurveyResponses2020.FromSqlRaw<SurveyResponse2020Model>(sql).ToListAsync();
            return queryResult.Count();
        }
    }
}
