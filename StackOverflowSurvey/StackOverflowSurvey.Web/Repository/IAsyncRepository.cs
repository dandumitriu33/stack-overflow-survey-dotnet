using StackOverflowSurvey.Web.Models;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Repository
{
    public interface IAsyncRepository
    {
        Task Add2011Response(SurveyResponse2011Model response);
        Task Add2012Response(SurveyResponse2012Model response);
    }
}
