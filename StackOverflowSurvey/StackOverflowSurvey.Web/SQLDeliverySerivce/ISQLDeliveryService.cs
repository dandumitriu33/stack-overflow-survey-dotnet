﻿using StackOverflowSurvey.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.SQLDeliverySerivce
{
    public interface ISQLDeliveryService
    {
        Task<int> rowCount(string sqlQuery);
        Task<string[]> GetAllCountries();
        Task<List<DataResponseDTO>> GetDataForCountry(DataRequestDTO dataRequestDTO);
    }
}
