﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackOverflowSurvey.Web.Context;

namespace StackOverflowSurvey.Web.Migrations
{
    [DbContext(typeof(StackOverflowSurveyContext))]
    partial class StackOverflowSurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2011Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnnualUSD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetOption7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareerSatisfaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Influence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProficient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgrammingExperience")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOption1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOption2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOption5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseWeightOption6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpentOnTechLastYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOption9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhichSites")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2011");
                });
#pragma warning restore 612, 618
        }
    }
}
