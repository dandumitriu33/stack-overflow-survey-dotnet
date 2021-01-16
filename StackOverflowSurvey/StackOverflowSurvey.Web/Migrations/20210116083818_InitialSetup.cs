using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2011",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    ProgrammingExperience = table.Column<int>(nullable: false),
                    Industry = table.Column<string>(nullable: true),
                    CompanySize = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Influence = table.Column<string>(nullable: true),
                    PurchaseWeight = table.Column<string>(nullable: true),
                    PurchaseWeightOption1 = table.Column<string>(nullable: true),
                    PurchaseWeightOption2 = table.Column<string>(nullable: true),
                    PurchaseWeightOption3 = table.Column<string>(nullable: true),
                    PurchaseWeightOption4 = table.Column<string>(nullable: true),
                    PurchaseWeightOption5 = table.Column<string>(nullable: true),
                    PurchaseWeightOption6 = table.Column<string>(nullable: true),
                    PurchaseType = table.Column<string>(nullable: true),
                    PurchaseTypeOption1 = table.Column<string>(nullable: true),
                    PurchaseTypeOption2 = table.Column<string>(nullable: true),
                    PurchaseTypeOption3 = table.Column<string>(nullable: true),
                    PurchaseTypeOption4 = table.Column<string>(nullable: true),
                    PurchaseTypeOption5 = table.Column<string>(nullable: true),
                    Budget = table.Column<string>(nullable: true),
                    BudgetOption1 = table.Column<string>(nullable: true),
                    BudgetOption2 = table.Column<string>(nullable: true),
                    BudgetOption3 = table.Column<string>(nullable: true),
                    BudgetOption4 = table.Column<string>(nullable: true),
                    BudgetOption5 = table.Column<string>(nullable: true),
                    BudgetOption6 = table.Column<string>(nullable: true),
                    BudgetOption7 = table.Column<string>(nullable: true),
                    TypeOfProject = table.Column<string>(nullable: true),
                    LanguageProficient = table.Column<string>(nullable: true),
                    Language1 = table.Column<string>(nullable: true),
                    Language2 = table.Column<string>(nullable: true),
                    Language3 = table.Column<string>(nullable: true),
                    Language4 = table.Column<string>(nullable: true),
                    Language5 = table.Column<string>(nullable: true),
                    Language6 = table.Column<string>(nullable: true),
                    Language7 = table.Column<string>(nullable: true),
                    Language8 = table.Column<string>(nullable: true),
                    Language9 = table.Column<string>(nullable: true),
                    Language10 = table.Column<string>(nullable: true),
                    Language11 = table.Column<string>(nullable: true),
                    Language12 = table.Column<string>(nullable: true),
                    OperatingSystem = table.Column<string>(nullable: true),
                    CareerSatisfaction = table.Column<string>(nullable: true),
                    AnnualUSD = table.Column<string>(nullable: true),
                    TechProductOwn = table.Column<string>(nullable: true),
                    TechProductOwnOption1 = table.Column<string>(nullable: true),
                    TechProductOwnOption2 = table.Column<string>(nullable: true),
                    TechProductOwnOption3 = table.Column<string>(nullable: true),
                    TechProductOwnOption4 = table.Column<string>(nullable: true),
                    TechProductOwnOption5 = table.Column<string>(nullable: true),
                    TechProductOwnOption6 = table.Column<string>(nullable: true),
                    TechProductOwnOption7 = table.Column<string>(nullable: true),
                    TechProductOwnOption8 = table.Column<string>(nullable: true),
                    TechProductOwnOption9 = table.Column<string>(nullable: true),
                    TechProductOwnOption10 = table.Column<string>(nullable: true),
                    TechProductOwnOption11 = table.Column<string>(nullable: true),
                    TechProductOwnOption12 = table.Column<string>(nullable: true),
                    TechProductOwnOption13 = table.Column<string>(nullable: true),
                    TechProductOwnOption14 = table.Column<string>(nullable: true),
                    TechProductOwnOption15 = table.Column<string>(nullable: true),
                    TechProductOwnOption16 = table.Column<string>(nullable: true),
                    SpentOnTechLastYear = table.Column<string>(nullable: true),
                    WhichSites = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses2011", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2011");
        }
    }
}
