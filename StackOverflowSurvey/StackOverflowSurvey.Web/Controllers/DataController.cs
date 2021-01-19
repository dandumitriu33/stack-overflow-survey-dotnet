using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StackOverflowSurvey.Web.Repository;
using StackOverflowSurvey.Web.SQLDeliverySerivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    public class DataController : Controller
    {
        private readonly IAsyncRepository _repository;
        private readonly ISQLDeliveryService _deliveryService;

        public DataController(IAsyncRepository repository,
                              ISQLDeliveryService deliveryService)
        {
            _repository = repository;
            _deliveryService = deliveryService;
        }

        // GET
        public async Task<IActionResult> TransferCount2020()
        {
            // EF Core way
            //var requests = await _repository.Get2020Count();

            // Manual connection way - PRACTICE SQL
            string sqlQuery = "SELECT count(*) FROM SurveyResponses2020";
            var requests = await Task.Run( () => _deliveryService.rowCount(sqlQuery) );
            return View(requests);
        }

        
    }
}
