﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackOverflowSurvey.Web.Context;

namespace StackOverflowSurvey.Web.Migrations
{
    [DbContext(typeof(StackOverflowSurveyContext))]
    [Migration("20210116123011_Add2011")]
    partial class Add2011
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnualUSD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget100K150K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget10K25K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget25K40K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget40K75K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget75K100K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetDontKnow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetLess10K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetMore150K")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareerSatisfaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSharp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJavaScript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProNone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPHP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPerl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPython")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRuby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRecommendationInfluence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleApprover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleCheckWriter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleImASeller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleInfluencer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleNoInvolvement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRolePurchaser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseRoleRecommender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeConsultants")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeHardware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeServers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeSoftware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTypeUserEquipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpentOnTechLastYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnAndroid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnAppleTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnBlackberry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnBluRay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnHDTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnIPad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnKindle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnNook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherGamingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherNetbook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherSmartPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherTech")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnPS3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnRegularMobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnWii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnXBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwniPhone")
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
