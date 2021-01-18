using Microsoft.AspNetCore.Mvc;
using StackOverflowSurvey.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    public class DataController : Controller
    {
        private readonly IAsyncRepository _repository;

        public DataController(IAsyncRepository repository)
        {
            _repository = repository;
        }

        // GET
        public IActionResult TransferCount2020()
        {
            var requests = _repository.GetResponse2020ById(173);
            return View(requests);
        }
    }
}
