using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class Rename2012ObjectiveC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(name: "ObjectiveC", table: "SurveyResponses2012", newName: "LanguageProObjectiveC", schema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(name: "LanguageProObjectiveC", table: "SurveyResponses2012", newName: "ObjectiveC", schema: "dbo");
        }
    }
}
