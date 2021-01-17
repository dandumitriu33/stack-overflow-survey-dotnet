using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class RemoveCPlusPlus11From2016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageProCPlusPlus11",
                table: "SurveyResponses2016");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageProCPlusPlus11",
                table: "SurveyResponses2016",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
