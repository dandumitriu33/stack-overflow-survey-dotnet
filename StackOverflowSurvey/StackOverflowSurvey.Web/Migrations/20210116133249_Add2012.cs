using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Add2012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2012",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    ProgrammingExperience = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    CompanySize = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    PurchaseRoleInfluencer = table.Column<string>(nullable: true),
                    PurchaseRoleRecommender = table.Column<string>(nullable: true),
                    PurchaseRoleApprover = table.Column<string>(nullable: true),
                    PurchaseRolePurchaser = table.Column<string>(nullable: true),
                    PurchaseRoleCheckWriter = table.Column<string>(nullable: true),
                    PurchaseRoleNoInvolvement = table.Column<string>(nullable: true),
                    PurchaseRoleImASeller = table.Column<string>(nullable: true),
                    PurchaseTypeHardware = table.Column<string>(nullable: true),
                    PurchaseTypeServers = table.Column<string>(nullable: true),
                    PurchaseTypeSoftware = table.Column<string>(nullable: true),
                    PurchaseTypeUserEquipment = table.Column<string>(nullable: true),
                    PurchaseTypeConsultants = table.Column<string>(nullable: true),
                    PurchaseTypeOther = table.Column<string>(nullable: true),
                    Budget = table.Column<string>(nullable: true),
                    TypeOfProject = table.Column<string>(nullable: true),
                    LanguageProJava = table.Column<string>(nullable: true),
                    LanguageProJavaScript = table.Column<string>(nullable: true),
                    LanguageProCSS = table.Column<string>(nullable: true),
                    LanguageProPHP = table.Column<string>(nullable: true),
                    LanguageProPython = table.Column<string>(nullable: true),
                    ObjectiveC = table.Column<string>(nullable: true),
                    LanguageProRuby = table.Column<string>(nullable: true),
                    LanguageProSQL = table.Column<string>(nullable: true),
                    LanguageProCSharp = table.Column<string>(nullable: true),
                    LanguageProCPlusPlus = table.Column<string>(nullable: true),
                    LanguageProC = table.Column<string>(nullable: true),
                    LanguageProPerl = table.Column<string>(nullable: true),
                    LanguageProHTML5 = table.Column<string>(nullable: true),
                    LanguageProNone = table.Column<string>(nullable: true),
                    LanguageProOther = table.Column<string>(nullable: true),
                    OperatingSystem = table.Column<string>(nullable: true),
                    CareerSatisfaction = table.Column<string>(nullable: true),
                    AnnualUSD = table.Column<string>(nullable: true),
                    StackOverFlowCareersAware = table.Column<string>(nullable: true),
                    StackOverFlowCareersProfile = table.Column<string>(nullable: true),
                    StackOverFlowCareersWhyNot = table.Column<string>(nullable: true),
                    StackOverFlowCareersWhyNotOther = table.Column<string>(nullable: true),
                    TechProductOwniPhone = table.Column<string>(nullable: true),
                    TechProductOwnAndroid = table.Column<string>(nullable: true),
                    TechProductOwnBlackberry = table.Column<string>(nullable: true),
                    TechProductOwnWindowsPhone = table.Column<string>(nullable: true),
                    TechProductOwnOtherSmartPhone = table.Column<string>(nullable: true),
                    TechProductOwnRegularMobilePhone = table.Column<string>(nullable: true),
                    TechProductOwnKindle = table.Column<string>(nullable: true),
                    TechProductOwnNook = table.Column<string>(nullable: true),
                    TechProductOwnAppleTV = table.Column<string>(nullable: true),
                    TechProductOwnBoxee = table.Column<string>(nullable: true),
                    TechProductOwnOtherMediaStreaming = table.Column<string>(nullable: true),
                    TechProductOwnNetbook = table.Column<string>(nullable: true),
                    TechProductOwnPS3 = table.Column<string>(nullable: true),
                    TechProductOwnXBox = table.Column<string>(nullable: true),
                    TechProductOwnWii = table.Column<string>(nullable: true),
                    TechProductOwnOtherGamingSystem = table.Column<string>(nullable: true),
                    TechProductOwnKindleFire = table.Column<string>(nullable: true),
                    TechProductOwnIPad = table.Column<string>(nullable: true),
                    TechProductOwnOtherTablet = table.Column<string>(nullable: true),
                    TechProductOwnOtherTech = table.Column<string>(nullable: true),
                    SpentOnTechLastYear = table.Column<string>(nullable: true),
                    StackOverflowAdsRelevant = table.Column<string>(nullable: true),
                    StackOverflowAdsEntertaining = table.Column<string>(nullable: true),
                    StackOverflowAdsInformative = table.Column<string>(nullable: true),
                    StackOverflowAdsIAddBlocker = table.Column<string>(nullable: true),
                    StackOverflowAdsIRememberAdvertiser = table.Column<string>(nullable: true),
                    StackOverflowReputation = table.Column<string>(nullable: true),
                    WhichSites = table.Column<string>(nullable: true),
                    WhichSitesOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses2012", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2012");
        }
    }
}
