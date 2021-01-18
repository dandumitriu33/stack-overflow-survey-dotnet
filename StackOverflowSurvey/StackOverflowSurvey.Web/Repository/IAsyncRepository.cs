using StackOverflowSurvey.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Repository
{
    public interface IAsyncRepository
    {
        Task Add2011Response(SurveyResponse2011Model response);
        Task Add2012Response(SurveyResponse2012Model response);
        Task Add2013Response(SurveyResponse2013Model response);
        Task Add2014Response(SurveyResponse2014Model response);
        Task Add2015Response(SurveyResponse2015Model response);
        Task Add2016Response(SurveyResponse2016Model response);
        Task Add2017Response(SurveyResponse2017Model response);
        Task Add2018ResponsesBatch(List<SurveyResponse2018Model> batch);
        Task Add2019ResponsesBatch(List<SurveyResponse2019Model> batch);
        Task Add2020ResponsesBatch(List<SurveyResponse2020Model> batch);
        SurveyResponse2020Model GetResponse2020ById(int id);
        //List<SurveyResponse2020Model> Get2020Count();
        Task<int> Get2020Count();
    }
}
