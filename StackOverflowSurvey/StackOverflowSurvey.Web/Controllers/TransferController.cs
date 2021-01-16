using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackOverflowSurvey.Web.Models;
using StackOverflowSurvey.Web.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly IAsyncRepository _repository;

        public TransferController(IAsyncRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<TranferController>/transfer-2011
        [HttpGet]
        [Route("transfer-2011")]
        public async Task<string> Transfer2011()
        {
            List<SurveyResponse2011Model> inMemoryTempDb = new List<SurveyResponse2011Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2011 Stack Overflow Survey Results.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    string processedLine = processLine(line);


                    var values = processedLine.Split(',');

                    SurveyResponse2011Model newResponseToAdd = new SurveyResponse2011Model
                    {
                        Country = values[0],
                        State = values[1],
                        Age = values[2],
                        ProgrammingExperience = values[3],
                        Industry = values[4],
                        CompanySize = values[5],
                        Occupation = values[6],
                        PurchaseRecommendationInfluence = values[7],
                        PurchaseRoleInfluencer = values[8],
                        PurchaseRoleRecommender = values[9],
                        PurchaseRoleApprover = values[10],
                        PurchaseRolePurchaser = values[11],
                        PurchaseRoleCheckWriter = values[12],
                        PurchaseRoleNoInvolvement = values[13],
                        PurchaseRoleImASeller = values[14],
                        PurchaseTypeHardware = values[15],
                        PurchaseTypeServers = values[16],
                        PurchaseTypeSoftware = values[17],
                        PurchaseTypeUserEquipment = values[18],
                        PurchaseTypeConsultants = values[19],
                        PurchaseTypeOther = values[20],
                        BudgetLess10K = values[21],
                        Budget10K25K = values[22],
                        Budget25K40K = values[23],
                        Budget40K75K = values[24],
                        Budget75K100K = values[25],
                        Budget100K150K = values[26],
                        BudgetMore150K = values[27],
                        BudgetDontKnow = values[28],
                        TypeOfProject = values[29],
                        LanguageProJava = values[30],
                        LanguageProJavaScript = values[31],
                        LanguageProCSS = values[32],
                        LanguageProPHP = values[33],
                        LanguageProPython = values[34],
                        LanguageProRuby = values[35],
                        LanguageProSQL = values[36],
                        LanguageProCSharp = values[37],
                        LanguageProCPlusPlus = values[38],
                        LanguageProC = values[39],
                        LanguageProPerl = values[40],
                        LanguageProNone = values[41],
                        LanguageProOther = values[42],
                        OperatingSystem = values[43],
                        CareerSatisfaction = values[44],
                        AnnualUSD = values[45],
                        TechProductOwniPhone = values[46],
                        TechProductOwnAndroid = values[47],
                        TechProductOwnBlackberry = values[48],
                        TechProductOwnOtherSmartPhone = values[49],
                        TechProductOwnRegularMobilePhone = values[50],
                        TechProductOwnKindle = values[51],
                        TechProductOwnNook = values[52],
                        TechProductOwnBluRay = values[53],
                        TechProductOwnHDTV = values[54],
                        TechProductOwnAppleTV = values[55],
                        TechProductOwnIPad = values[56],
                        TechProductOwnOtherNetbook = values[57],
                        TechProductOwnPS3 = values[58],
                        TechProductOwnXBox = values[59],
                        TechProductOwnWii = values[60],
                        TechProductOwnOtherGamingSystem = values[61],
                        TechProductOwnOtherTech = values[62],
                        SpentOnTechLastYear = values[63],
                        WhichSites = values[64]
                    };
                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2011Response(response);
            }


            string payload = "Transfer 2011 abcd.";

            return payload;
        }

        private string processLine(string line)
        {
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("(hardware, software, consulting, etc)",
                                "(hardware software consulting etc)");
            line = line.Replace("bonus, what", 
                                "bonus what");
            line = line.Replace("months, how",
                                "months how");
            line = line.Replace("\"Executive (VP of Eng, CTO, CIO, etc.)\"", "Executive VP CTO CIO");
            line = line.Replace("\"Other (not working, consultant, etc.)\"", "Other not working consultant");
            line = line.Replace("\"User Equipment: Monitors, PCs, Laptops\"", "User Equipment Monitors PCs Laptops");
            return line;
        }
    }
}
