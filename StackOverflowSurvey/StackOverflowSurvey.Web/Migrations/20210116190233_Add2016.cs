using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Add2016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2016",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    LanguageProC = table.Column<string>(nullable: true),
                    LanguageProCPlusPlus = table.Column<string>(nullable: true),
                    LanguageProCPlusPlus11 = table.Column<string>(nullable: true),
                    LanguageProCSharp = table.Column<string>(nullable: true),
                    LanguageProGo = table.Column<string>(nullable: true),
                    LanguageProJava = table.Column<string>(nullable: true),
                    LanguageProJavaScript = table.Column<string>(nullable: true),
                    LanguageProNodeJs = table.Column<string>(nullable: true),
                    LanguageProObjectiveC = table.Column<string>(nullable: true),
                    LanguageProPerl = table.Column<string>(nullable: true),
                    LanguageProPHP = table.Column<string>(nullable: true),
                    LanguageProPython = table.Column<string>(nullable: true),
                    LanguageProRuby = table.Column<string>(nullable: true),
                    LanguageProRust = table.Column<string>(nullable: true),
                    LanguageProSQL = table.Column<string>(nullable: true),
                    LanguageProSQLServer = table.Column<string>(nullable: true),
                    LanguageProSwift = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses2016", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2016");
        }
    }
}
