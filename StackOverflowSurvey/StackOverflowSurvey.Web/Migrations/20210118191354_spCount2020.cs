using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflowSurvey.Web.Migrations
{
    public partial class spCount2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCount2020
                                 @Id int output
                                 as
                                 Begin
                                    Select @p1 = count(*)
                                    from SurveyResponses2020
                                 End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spCount2020";
            migrationBuilder.Sql(procedure);
        }
    }
}
