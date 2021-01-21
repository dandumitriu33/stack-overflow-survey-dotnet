using Microsoft.AspNetCore.Mvc;
using StackOverflowSurvey.Web.Models;
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

        // GET: api/<QueryController>/data-for-country
        [Route("data-for-country")]
        public async Task<IActionResult> GetDataForCountry(DataRequestDTO dataRequestDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var data = await _deliveryService.GetDataForCountry(dataRequestDTO);
                    var payload = JsonSerializer.Serialize(data);
                    return Ok(payload);
                }
                catch (Exception)
                {
                    return BadRequest();
                }                
            };
            return BadRequest();
        }
    }
}
