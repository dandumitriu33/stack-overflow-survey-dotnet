using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Add2014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2014",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    CountryOther = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ProgrammingExperience = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    AnnualUSD = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    LanguageProC = table.Column<string>(nullable: true),
                    LanguageProCPlusPlus = table.Column<string>(nullable: true),
                    LanguageProCSharp = table.Column<string>(nullable: true),
                    LanguageProJava = table.Column<string>(nullable: true),
                    LanguageProJavaScript = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_SurveyResponses2014", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2014");
        }
    }
}
