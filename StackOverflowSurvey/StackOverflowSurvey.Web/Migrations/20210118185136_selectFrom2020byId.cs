using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class selectFrom2020byId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetResponseById
                                 @Id int
                                 as
                                 Begin
                                    Select * from SurveyResponses2020
                                    where Id = @Id
                                 End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetResponseById";
            migrationBuilder.Sql(procedure);
        }
    }
}
