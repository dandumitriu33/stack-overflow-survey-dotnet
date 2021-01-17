using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Add2013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2013",
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
                    TotalDevsYourCompany = table.Column<string>(nullable: true),
                    TotalDevsYourTeam = table.Column<string>(nullable: true),
                    RolesInteractSysAdmin = table.Column<string>(nullable: true),
                    RolesInteractDesigner = table.Column<string>(nullable: true),
                    RolesInteractProductManager = table.Column<string>(nullable: true),
                    RolesInteractTestQA = table.Column<string>(nullable: true),
                    RolesInteractTechSupport = table.Column<string>(nullable: true),
                    RolesInteractSalesMarketing = table.Column<string>(nullable: true),
                    RolesInteractCustomers = table.Column<string>(nullable: true),
                    RolesInteractFinance = table.Column<string>(nullable: true),
                    RolesInteractHR = table.Column<string>(nullable: true),
                    YourCompanyMobileAppIPhone = table.Column<string>(nullable: true),
                    YourCompanyMobileAppIPad = table.Column<string>(nullable: true),
                    YourCompanyMobileAppAndroidPhone = table.Column<string>(nullable: true),
                    YourCompanyMobileAppAndroidTablet = table.Column<string>(nullable: true),
                    YourCompanyMobileAppBlackberry = table.Column<string>(nullable: true),
                    YourCompanyMobileAppOther = table.Column<string>(nullable: true),
                    YourCompanyMobileAppNoApp = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeAdvertising = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeDirectSalesConsumer = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeDirectSalesCompany = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeSaaSSubscription = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeAppSales = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeConsulting = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeGrantFundRaising = table.Column<string>(nullable: true),
                    HowYourCompanyMonetizeOther = table.Column<string>(nullable: true),
                    TimeSpentWeekNewFeatures = table.Column<string>(nullable: true),
                    TimeSpentWeekRefactoring = table.Column<string>(nullable: true),
                    TimeSpentWeekBugs = table.Column<string>(nullable: true),
                    TimeSpentWeekTechSupport = table.Column<string>(nullable: true),
                    TimeSpentWeekMeetings = table.Column<string>(nullable: true),
                    TimeSpentWeekLearningNewSkill = table.Column<string>(nullable: true),
                    TimeSpentWeekInternetBrowsing = table.Column<string>(nullable: true),
                    TimeSpentWeekCommuting = table.Column<string>(nullable: true),
                    PurchaseRoleRecommender = table.Column<string>(nullable: true),
                    PurchaseRoleInfluencer = table.Column<string>(nullable: true),
                    PurchaseRolePurchaser = table.Column<string>(nullable: true),
                    PurchaseRoleApprover = table.Column<string>(nullable: true),
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
                    LanguageProC = table.Column<string>(nullable: true),
                    LanguageProCPlusPlus = table.Column<string>(nullable: true),
                    LanguageProCSharp = table.Column<string>(nullable: true),
                    LanguageProJava = table.Column<string>(nullable: true),
                    LanguageProJavaScript = table.Column<string>(nullable: true),
                    LanguageProJQuery = table.Column<string>(nullable: true),
                    LanguageProJQuery2 = table.Column<string>(nullable: true),
                    LanguageProNodeJs = table.Column<string>(nullable: true),
                    ObjectiveC = table.Column<string>(nullable: true),
                    LanguageProPHP = table.Column<string>(nullable: true),
                    LanguageProPython = table.Column<string>(nullable: true),
                    LanguageProRuby = table.Column<string>(nullable: true),
                    LanguageProSQL = table.Column<string>(nullable: true),
                    LanguageProOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses2013", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2013");
        }
    }
}
