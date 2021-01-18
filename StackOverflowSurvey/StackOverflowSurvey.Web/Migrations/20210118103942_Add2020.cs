using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Add2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyResponses2020",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    LanguageProC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProCPlusPlus = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProCSharp = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProGo = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProJava = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProJavaScript = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProNodeJs = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProObjectiveC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProPerl = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProPHP = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProPython = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProRuby = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProRust = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProSQL = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProSQLServer = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageProSwift = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses2020", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponses2020");
        }
    }
}
