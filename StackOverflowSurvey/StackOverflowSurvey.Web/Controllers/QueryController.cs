using Microsoft.AspNetCore.Mvc;
using StackOverflowSurvey.Web.SQLDeliverySerivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly ISQLDeliveryService _deliveryService;

        public QueryController(ISQLDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        // GET: api/<QueryController>/all-countries
        [Route("all-countries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _deliveryService.GetAllCountries();
            var payload = JsonSerializer.Serialize(countries);
            return Ok(payload);
        }
    }
}
