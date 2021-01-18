using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class count2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure count2020
                                 as
                                 Begin
                                 select count(*) from SurveyResponses2020;
                                 End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure count2020";
            migrationBuilder.Sql(procedure);
        }
    }
}
