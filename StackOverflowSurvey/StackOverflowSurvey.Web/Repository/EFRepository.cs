﻿using StackOverflowSurvey.Web.Context;
using StackOverflowSurvey.Web.Models;
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
    }
}
