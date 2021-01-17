using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackOverflowSurvey.Web.Models;
using StackOverflowSurvey.Web.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                    string processedLine = processLine2011(line);


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

        // GET: api/<TranferController>/transfer-2012
        [HttpGet]
        [Route("transfer-2012")]
        public async Task<string> Transfer2012()
        {
            List<SurveyResponse2012Model> inMemoryTempDb = new List<SurveyResponse2012Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2012 Stack Overflow Survey Results.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    string processedLine = processLine2012(line);

                    var values = processedLine.Split(',');

                    SurveyResponse2012Model newResponseToAdd = new SurveyResponse2012Model
                    {
                        Country = values[0],
                        State = values[1],
                        Age = values[2],
                        ProgrammingExperience = values[3],
                        Industry = values[4],
                        CompanySize = values[5],
                        Occupation = values[6],
                        PurchaseRoleInfluencer = values[7],
                        PurchaseRoleRecommender = values[8],
                        PurchaseRoleApprover = values[9],
                        PurchaseRolePurchaser = values[10],
                        PurchaseRoleCheckWriter = values[11],
                        PurchaseRoleNoInvolvement = values[12],
                        PurchaseRoleImASeller = values[13],
                        PurchaseTypeHardware = values[14],
                        PurchaseTypeServers = values[15],
                        PurchaseTypeSoftware = values[16],
                        PurchaseTypeUserEquipment = values[17],
                        PurchaseTypeConsultants = values[18],
                        PurchaseTypeOther = values[19],
                        Budget = values[20],
                        TypeOfProject = values[21],
                        LanguageProJava = values[22],
                        LanguageProJavaScript = values[23],
                        LanguageProCSS = values[24],
                        LanguageProPHP = values[25],
                        LanguageProPython = values[26],
                        ObjectiveC = values[27],
                        LanguageProRuby = values[28],
                        LanguageProSQL = values[29],
                        LanguageProCSharp = values[30],
                        LanguageProCPlusPlus = values[31],
                        LanguageProC = values[32],
                        LanguageProPerl = values[33],
                        LanguageProHTML5 = values[34],
                        LanguageProNone = values[35],
                        LanguageProOther = values[36],
                        OperatingSystem = values[37],
                        CareerSatisfaction = values[38],
                        AnnualUSD = values[39],
                        StackOverFlowCareersAware = values[40],
                        StackOverFlowCareersProfile = values[41],
                        StackOverFlowCareersWhyNot = values[42],
                        StackOverFlowCareersWhyNotOther = values[43],
                        TechProductOwniPhone = values[44],
                        TechProductOwnAndroid = values[45],
                        TechProductOwnBlackberry = values[46],
                        TechProductOwnWindowsPhone = values[47],
                        TechProductOwnOtherSmartPhone = values[48],
                        TechProductOwnRegularMobilePhone = values[49],
                        TechProductOwnKindle = values[50],
                        TechProductOwnNook = values[51],
                        TechProductOwnAppleTV = values[52],
                        TechProductOwnBoxee = values[53],
                        TechProductOwnOtherMediaStreaming = values[54],
                        TechProductOwnNetbook = values[55],
                        TechProductOwnPS3 = values[56],
                        TechProductOwnXBox = values[57],
                        TechProductOwnWii = values[58],
                        TechProductOwnOtherGamingSystem = values[59],
                        TechProductOwnKindleFire = values[60],
                        TechProductOwnIPad = values[61],
                        TechProductOwnOtherTablet = values[62],
                        TechProductOwnOtherTech = values[63],
                        SpentOnTechLastYear = values[64],
                        StackOverflowAdsRelevant = values[65],
                        StackOverflowAdsEntertaining = values[66],
                        StackOverflowAdsInformative = values[67],
                        StackOverflowAdsIAddBlocker = values[68],
                        StackOverflowAdsIRememberAdvertiser = values[69],
                        StackOverflowReputation = values[70],
                        WhichSites = values[71],
                        WhichSitesOther = values[72]
                    };
                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2012Response(response);
            }


            string payload = "Transfer 2012 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2013
        [HttpGet]
        [Route("transfer-2013")]
        public async Task<string> Transfer2013()
        {
            List<SurveyResponse2013Model> inMemoryTempDb = new List<SurveyResponse2013Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2013 Stack Overflow Survey Responses.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    string processedLine = processLine2013(line);

                    var values = processedLine.Split(',');

                    SurveyResponse2013Model newResponseToAdd = new SurveyResponse2013Model
                    {
                        Country = values[0],
                        State = values[1],
                        Age = values[2],
                        ProgrammingExperience = values[3],
                        Industry = values[4],
                        CompanySize = values[5],
                        //Occupation = values[6],
                        //TotalDevsYourCompany = values[7],
                        //TotalDevsYourTeam = values[8],
                        //RolesInteractSysAdmin = values[9],
                        //RolesInteractDesigner = values[10],
                        //RolesInteractProductManager = values[11],
                        //RolesInteractTestQA = values[12],
                        //RolesInteractTechSupport = values[13],
                        //RolesInteractSalesMarketing = values[14],
                        //RolesInteractCustomers = values[15],
                        //RolesInteractFinance = values[16],
                        //RolesInteractHR = values[17],
                        //YourCompanyMobileAppIPhone = values[18],
                        //YourCompanyMobileAppIPad = values[19],
                        //YourCompanyMobileAppAndroidPhone = values[20],
                        //YourCompanyMobileAppAndroidTablet = values[21],
                        //YourCompanyMobileAppBlackberry = values[22],
                        //YourCompanyMobileAppOther = values[23],
                        //YourCompanyMobileAppNoApp = values[24],
                        //HowYourCompanyMonetizeAdvertising = values[25],
                        //HowYourCompanyMonetizeDirectSalesConsumer = values[26],
                        //HowYourCompanyMonetizeDirectSalesCompany = values[27],
                        //HowYourCompanyMonetizeSaaSSubscription = values[28],
                        //HowYourCompanyMonetizeAppSales = values[29],
                        //HowYourCompanyMonetizeConsulting = values[30],
                        //HowYourCompanyMonetizeGrantFundRaising = values[31],
                        //HowYourCompanyMonetizeOther = values[32],
                        //TimeSpentWeekNewFeatures = values[33],
                        //TimeSpentWeekRefactoring = values[34],
                        //TimeSpentWeekBugs = values[35],
                        //TimeSpentWeekTechSupport = values[36],
                        //TimeSpentWeekMeetings = values[37],
                        //TimeSpentWeekLearningNewSkill = values[38],
                        //TimeSpentWeekInternetBrowsing = values[39],
                        //TimeSpentWeekCommuting = values[40],
                        //PurchaseRoleRecommender = values[41],
                        //PurchaseRoleInfluencer = values[42],
                        //PurchaseRolePurchaser = values[43],
                        //PurchaseRoleApprover = values[44],
                        //PurchaseRoleCheckWriter = values[45],
                        //PurchaseRoleNoInvolvement = values[46],
                        //PurchaseRoleImASeller = values[47],
                        //PurchaseTypeHardware = values[48],
                        //PurchaseTypeServers = values[49],
                        //PurchaseTypeSoftware = values[50],
                        //PurchaseTypeUserEquipment = values[51],
                        //PurchaseTypeConsultants = values[52],
                        //PurchaseTypeOther = values[53],
                        Budget = values[55],
                        LanguageProC = values[56],
                        LanguageProCPlusPlus = values[57],
                        LanguageProCSharp = values[58],
                        LanguageProJava = values[59],
                        LanguageProJavaScript = values[60],
                        LanguageProJQuery = values[61],
                        LanguageProJQuery2 = values[62],
                        LanguageProNodeJs = values[63],
                        ObjectiveC = values[64],
                        LanguageProPHP = values[65],
                        LanguageProPython = values[66],
                        LanguageProRuby = values[67],
                        LanguageProSQL = values[68],
                        LanguageProOther = values[69]
                    };
                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2013Response(response);
            }


            string payload = "Transfer 2013 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2014
        [HttpGet]
        [Route("transfer-2014")]
        public async Task<string> Transfer2014()
        {
            List<SurveyResponse2014Model> inMemoryTempDb = new List<SurveyResponse2014Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2014 Stack Overflow Survey Responses.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    string processedLine = processLine2014(line);

                    var values = processedLine.Split(',');

                    SurveyResponse2014Model newResponseToAdd = new SurveyResponse2014Model
                    {
                        Country = values[0],
                        CountryOther = values[1],
                        State = values[2],
                        Age = values[3],
                        Gender = values[4],
                        ProgrammingExperience = values[5],
                        Occupation = values[6],
                        Industry = values[8],
                        LanguageProC = values[42],
                        LanguageProCPlusPlus = values[43],
                        LanguageProCSharp = values[44],
                        LanguageProJava = values[45],
                        LanguageProJavaScript = values[46],
                        LanguageProNodeJs = values[47],
                        ObjectiveC = values[48],
                        LanguageProPHP = values[49],
                        LanguageProPython = values[50],
                        LanguageProRuby = values[51],
                        LanguageProSQL = values[52],
                        LanguageProOther = values[53]
                    };
                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2014Response(response);
            }
            
            string payload = "Transfer 2014 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2015
        [HttpGet]
        [Route("transfer-2015")]
        public async Task<string> Transfer2015()
        {
            List<SurveyResponse2015Model> inMemoryTempDb = new List<SurveyResponse2015Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2015 Stack Overflow Developer Survey Responses.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    string processedLine = processLine2015(line);

                    var values = processedLine.Split(',');

                    SurveyResponse2015Model newResponseToAdd = new SurveyResponse2015Model
                    {
                        Country = values[0],
                        Age = values[1],
                        Gender = values[2],
                        LanguageProC = values[11],
                        LanguageProCPlusPlus = values[12],
                        LanguageProCPlusPlus11 = values[13],
                        LanguageProCSharp = values[14],
                        LanguageProGo = values[22],
                        LanguageProJava = values[26],
                        LanguageProJavaScript = values[27],
                        LanguageProNodeJs = values[31],
                        LanguageProObjectiveC = values[32],
                        LanguageProPerl = values[33],
                        LanguageProPHP = values[34],
                        LanguageProPython = values[35],
                        LanguageProRuby = values[38],
                        LanguageProRust = values[39],
                        LanguageProSQL = values[44],
                        LanguageProSQLServer = values[45],
                        LanguageProSwift = values[46]
                    };
                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2015Response(response);
            }

            string payload = "Transfer 2015 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2016
        [HttpGet]
        [Route("transfer-2016")]
        public async Task<string> Transfer2016()
        {
            List<SurveyResponse2016Model> inMemoryTempDb = new List<SurveyResponse2016Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2016 Stack Overflow Survey Results\2016 Stack Overflow Survey Responses.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string processedLine = processLine2016(line);
                    var values = processedLine.Split(',');
                    List<string> languages = new List<string>();
                    var untrimmedLanguages = values[16].Split(';');
                    foreach (var language in untrimmedLanguages)
                    {
                        languages.Add(language.Trim());
                    }
                    
                    StringBuilder sb = new StringBuilder();
                    foreach (var lang in languages)
                    {
                        sb.Append(lang);
                    }

                    SurveyResponse2016Model newResponseToAdd = new SurveyResponse2016Model
                    {
                        Country = values[2],
                        Age = values[5],
                        Gender = values[7],
                        //LanguageProC = sb.ToString(),
                        LanguageProC = languages.Contains("C") ? "C" : null,
                        LanguageProCPlusPlus = languages.Contains("C++") ? "C++" : null,
                        LanguageProCSharp = languages.Contains("C#") ? "C#" : null,
                        LanguageProGo = languages.Contains("Go") ? "Go" : null,
                        LanguageProJava = languages.Contains("Java") ? "Java" : null,
                        LanguageProJavaScript = languages.Contains("JavaScript") ? "JavaScript" : null,
                        LanguageProNodeJs = languages.Contains("Node.js") ? "Node.js" : null,
                        LanguageProObjectiveC = languages.Contains("Objective-C") ? "Objective-C" : null, 
                        LanguageProPerl = languages.Contains("Perl") ? "Perl" : null,
                        LanguageProPHP = languages.Contains("PHP") ? "PHP" : null,
                        LanguageProPython = languages.Contains("Python") ? "Python" : null,
                        LanguageProRuby = languages.Contains("Ruby") ? "Ruby" : null,
                        LanguageProRust = languages.Contains("Rust") ? "Rust" : null,
                        LanguageProSQL = languages.Contains("SQL") ? "SQL" : null,
                        LanguageProSQLServer = languages.Contains("SQL Server") ? "SQL Server" : null,
                        LanguageProSwift = languages.Contains("Swift") ? "Swift" : null
                    };

                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2016Response(response);
            }

            string payload = "Transfer 2016 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2017
        [HttpGet]
        [Route("transfer-2017")]
        public async Task<string> Transfer2017()
        {
            List<SurveyResponse2017Model> inMemoryTempDb = new List<SurveyResponse2017Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2017 Stack Overflow Survey Results\survey_results_public.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string processedLine = processLine2017(line);
                    var values = processedLine.Split(',');
                    List<string> languages = new List<string>();
                    var untrimmedLanguages = values[88].Split(';');
                    foreach (var language in untrimmedLanguages)
                    {
                        languages.Add(language.Trim());
                    }

                    StringBuilder sb = new StringBuilder();
                    foreach (var lang in languages)
                    {
                        sb.Append(lang);
                    }

                    SurveyResponse2017Model newResponseToAdd = new SurveyResponse2017Model
                    {
                        Country = values[3],
                        //LanguageProC = sb.ToString(),
                        LanguageProC = languages.Contains("C") ? "C" : null,
                        LanguageProCPlusPlus = languages.Contains("C++") ? "C++" : null,
                        LanguageProCSharp = languages.Contains("C#") ? "C#" : null,
                        LanguageProGo = languages.Contains("Go") ? "Go" : null,
                        LanguageProJava = languages.Contains("Java") ? "Java" : null,
                        LanguageProJavaScript = languages.Contains("JavaScript") ? "JavaScript" : null,
                        LanguageProNodeJs = languages.Contains("Node.js") ? "Node.js" : null,
                        LanguageProObjectiveC = languages.Contains("Objective-C") ? "Objective-C" : null,
                        LanguageProPerl = languages.Contains("Perl") ? "Perl" : null,
                        LanguageProPHP = languages.Contains("PHP") ? "PHP" : null,
                        LanguageProPython = languages.Contains("Python") ? "Python" : null,
                        LanguageProRuby = languages.Contains("Ruby") ? "Ruby" : null,
                        LanguageProRust = languages.Contains("Rust") ? "Rust" : null,
                        LanguageProSQL = languages.Contains("SQL") ? "SQL" : null,
                        LanguageProSQLServer = languages.Contains("SQL Server") ? "SQL Server" : null,
                        LanguageProSwift = languages.Contains("Swift") ? "Swift" : null
                    };

                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                await _repository.Add2017Response(response);
            }

            string payload = "Transfer 2017 complete.";

            return payload;
        }

        // GET: api/<TranferController>/transfer-2018
        [HttpGet]
        [Route("transfer-2018")]
        public async Task<string> Transfer2018()
        {
            List<SurveyResponse2018Model> inMemoryTempDb = new List<SurveyResponse2018Model>();
            using (var reader = new StreamReader(@"C:\stackoverflow\2018 Stack Overflow Survey Results\2018Testing.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string processedLine = processLine2018(line);
                    var values = processedLine.Split(',');
                    List<string> languages = new List<string>();
                    var untrimmedLanguages = values[88].Split(';');
                    foreach (var language in untrimmedLanguages)
                    {
                        languages.Add(language.Trim());
                    }

                    StringBuilder sb = new StringBuilder();
                    foreach (var lang in languages)
                    {
                        sb.Append(lang);
                    }

                    SurveyResponse2018Model newResponseToAdd = new SurveyResponse2018Model
                    {
                        Country = values[3],
                        //LanguageProC = sb.ToString(),
                        LanguageProC = languages.Contains("C") ? "C" : null,
                        LanguageProCPlusPlus = languages.Contains("C++") ? "C++" : null,
                        LanguageProCSharp = languages.Contains("C#") ? "C#" : null,
                        LanguageProGo = languages.Contains("Go") ? "Go" : null,
                        LanguageProJava = languages.Contains("Java") ? "Java" : null,
                        LanguageProJavaScript = languages.Contains("JavaScript") ? "JavaScript" : null,
                        LanguageProNodeJs = languages.Contains("Node.js") ? "Node.js" : null,
                        LanguageProObjectiveC = languages.Contains("Objective-C") ? "Objective-C" : null,
                        LanguageProPerl = languages.Contains("Perl") ? "Perl" : null,
                        LanguageProPHP = languages.Contains("PHP") ? "PHP" : null,
                        LanguageProPython = languages.Contains("Python") ? "Python" : null,
                        LanguageProRuby = languages.Contains("Ruby") ? "Ruby" : null,
                        LanguageProRust = languages.Contains("Rust") ? "Rust" : null,
                        LanguageProSQL = languages.Contains("SQL") ? "SQL" : null,
                        LanguageProSQLServer = languages.Contains("SQL Server") ? "SQL Server" : null,
                        LanguageProSwift = languages.Contains("Swift") ? "Swift" : null
                    };

                    inMemoryTempDb.Add(newResponseToAdd);

                }
            }
            foreach (var response in inMemoryTempDb)
            {
                //await _repository.Add2018Response(response);
            }

            string payload = "Transfer 2018 complete.";

            return payload;
        }

        private string processLine2018(string line)
        {
            //line = line.Replace("\"", "");
            line = line.Replace("Yes, both", "Yes both");
            line = line.Replace("Yes, I program", "Yes I program");
            line = line.Replace("Yes, I contribute", "Yes I contribute");
            line = line.Replace("Not employed, and not", "Not employed and not");
            line = line.Replace("technology, networking, or system", "technology networking or system");
            line = line.Replace("Not employed, but", "Not employed but");
            line = line.Replace("contractor, freelancer, or", "contractor freelancer or");
            line = line.Replace("half, but not all, the", "half but not all the");
            line = line.Replace("half the time, but at", "half the time but at");
            line = line.Replace("company, not in startup", "company not in startup");
            line = line.Replace("partnership, not in startup", "partnership not in startup");
            line = line.Replace("\"g,\"", "g");
            line = line.Replace("actively looking, but", "actively looking but");
            line = line.Replace("project, assignment, or contract", "project assignment or contract");
            line = line.Replace("friend, family member, or", "friend family member or");
            line = line.Replace("Yes, part-time", "Yes part-time");
            line = line.Replace("Yes, full-time", "Yes full-time");
            line = line.Replace(",000", "K");
            line = line.Replace(",999", "_999");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");

            line = line.Replace(" Scientists, Machine", " Scientists Machine");
            line = line.Replace("AWS, GAE, Azure, etc", "AWS GAE Azure etc");
            line = line.Replace("Android, iOS, WP ", "Android iOS WP ");
            return line;
        }

        private string processLine2017(string line)
        {
            //line = line.Replace("\"", "");
            line = line.Replace("Yes, both", "Yes both");
            line = line.Replace("Yes, I program", "Yes I program");
            line = line.Replace("Yes, I contribute", "Yes I contribute");
            line = line.Replace("Not employed, and not", "Not employed and not");
            line = line.Replace("technology, networking, or system", "technology networking or system");
            line = line.Replace("Not employed, but", "Not employed but");
            line = line.Replace("contractor, freelancer, or", "contractor freelancer or");
            line = line.Replace("half, but not all, the", "half but not all the");
            line = line.Replace("half the time, but at", "half the time but at");
            line = line.Replace("company, not in startup", "company not in startup");
            line = line.Replace("partnership, not in startup", "partnership not in startup");
            line = line.Replace("\"g,\"", "g");
            line = line.Replace("actively looking, but", "actively looking but");
            line = line.Replace("project, assignment, or contract", "project assignment or contract");
            line = line.Replace("friend, family member, or", "friend family member or");
            line = line.Replace("Yes, part-time", "Yes part-time");
            line = line.Replace("Yes, full-time", "Yes full-time");
            line = line.Replace(",000", "K");
            line = line.Replace(",999", "_999");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");

            line = line.Replace(" Scientists, Machine", " Scientists Machine");
            line = line.Replace("AWS, GAE, Azure, etc", "AWS GAE Azure etc");
            line = line.Replace("Android, iOS, WP ", "Android iOS WP ");
            return line;
        }

        private string processLine2016(string line)
        {
            line = line.Replace("\"", "");
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");
            line = line.Replace(" Scientists, Machine", " Scientists Machine");
            line = line.Replace("AWS, GAE, Azure, etc", "AWS GAE Azure etc");
            line = line.Replace("Android, iOS, WP ", "Android iOS WP ");
            return line;
        }

        private string processLine2015(string line)
        {
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");
            line = line.Replace("(AWS, GAE, Azure, etc.)", "(AWS GAE Azure etc.)");
            line = line.Replace("average week, how", "average week how");
            line = line.Replace("mobile app, what", "mobile app what");
            line = line.Replace("like it, though", "like it though");
            line = line.Replace("(hardware, software, consulting, etc)", "(hardware software consulting etc)");
            line = line.Replace("bonus, what", "bonus what");
            line = line.Replace("months, how", "months how");
            line = line.Replace("decisions, but", "decisions but");
            line = line.Replace("\"Executive (VP of Eng, CTO, CIO, etc.)\"", "Executive VP CTO CIO");
            line = line.Replace("\"Other (not working, consultant, etc.)\"", "Other not working consultant");
            line = line.Replace("\"User Equipment: Monitors, PCs, Laptops\"", "User Equipment Monitors PCs Laptops");
            return line;
        }

        private string processLine2014(string line)
        {
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");
            line = line.Replace("average week, how", "average week how");
            line = line.Replace("mobile app, what", "mobile app what");
            line = line.Replace("like it, though", "like it though");
            line = line.Replace("(hardware, software, consulting, etc)", "(hardware software consulting etc)");
            line = line.Replace("bonus, what", "bonus what");
            line = line.Replace("months, how", "months how");
            line = line.Replace("decisions, but", "decisions but");
            line = line.Replace("\"Executive (VP of Eng, CTO, CIO, etc.)\"", "Executive VP CTO CIO");
            line = line.Replace("\"Other (not working, consultant, etc.)\"", "Other not working consultant");
            line = line.Replace("\"User Equipment: Monitors, PCs, Laptops\"", "User Equipment Monitors PCs Laptops");
            return line;
        }

        private string processLine2013(string line)
        {
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("001", "K");
            line = line.Replace("(hardware, software, consulting, etc)", "(hardware software consulting etc)");
            line = line.Replace("bonus, what", "bonus what");
            line = line.Replace("months, how", "months how");
            line = line.Replace("decisions, but", "decisions but");
            line = line.Replace("\"Executive (VP of Eng, CTO, CIO, etc.)\"", "Executive VP CTO CIO");
            line = line.Replace("\"Other (not working, consultant, etc.)\"", "Other not working consultant");
            line = line.Replace("\"User Equipment: Monitors, PCs, Laptops\"", "User Equipment Monitors PCs Laptops");
            return line;
        }

        private string processLine2012(string line)
        {
            line = line.Replace(",000", "K");
            line = line.Replace(",001", "K");
            line = line.Replace("(hardware, software, consulting, etc)", "(hardware software consulting etc)");
            line = line.Replace("bonus, what", "bonus what");
            line = line.Replace("months, how", "months how");
            line = line.Replace("\"Executive (VP of Eng, CTO, CIO, etc.)\"", "Executive VP CTO CIO");
            line = line.Replace("\"Other (not working, consultant, etc.)\"", "Other not working consultant");
            line = line.Replace("\"User Equipment: Monitors, PCs, Laptops\"", "User Equipment Monitors PCs Laptops");
            return line;
        }

        private string processLine2011(string line)
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
