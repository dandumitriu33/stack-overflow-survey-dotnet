using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Transfer()
        {
            return View();
        }
    }
}
