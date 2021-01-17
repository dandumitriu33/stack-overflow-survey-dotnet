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
    [Migration("20210116201002_RemoveCPlusPlus11From2016")]
    partial class RemoveCPlusPlus11From2016
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

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2012Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnualUSD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget")
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

                    b.Property<string>("LanguageProHTML5")
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

                    b.Property<string>("ObjectiveC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingExperience")
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

                    b.Property<string>("StackOverFlowCareersAware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverFlowCareersProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverFlowCareersWhyNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverFlowCareersWhyNotOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowAdsEntertaining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowAdsIAddBlocker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowAdsIRememberAdvertiser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowAdsInformative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowAdsRelevant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackOverflowReputation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnAndroid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnAppleTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnBlackberry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnBoxee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnIPad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnKindle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnKindleFire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnNetbook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnNook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherGamingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherMediaStreaming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherSmartPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherTablet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnOtherTech")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnPS3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnRegularMobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnWii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnWindowsPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwnXBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechProductOwniPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhichSites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhichSitesOther")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2012");
                });

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2013Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeAdvertising")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeAppSales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeConsulting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeDirectSalesCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeDirectSalesConsumer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeGrantFundRaising")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowYourCompanyMonetizeSaaSSubscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSharp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJQuery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJQuery2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJavaScript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProNodeJs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPHP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPython")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRuby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectiveC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingExperience")
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

                    b.Property<string>("RolesInteractCustomers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractDesigner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractFinance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractHR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractProductManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractSalesMarketing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractSysAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractTechSupport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesInteractTestQA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekBugs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekCommuting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekInternetBrowsing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekLearningNewSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekMeetings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekNewFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekRefactoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpentWeekTechSupport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalDevsYourCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalDevsYourTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppAndroidPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppAndroidTablet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppBlackberry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppIPad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppIPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppNoApp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourCompanyMobileAppOther")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2013");
                });

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2014Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnualUSD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSharp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJavaScript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProNodeJs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPHP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPython")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRuby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectiveC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2014");
                });

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2015Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSharp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProGo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJavaScript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProNodeJs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProObjectiveC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPHP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPerl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPython")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRuby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQLServer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSwift")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2015");
                });

            modelBuilder.Entity("StackOverflowSurvey.Web.Models.SurveyResponse2016Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCPlusPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProCSharp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProGo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProJavaScript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProNodeJs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProObjectiveC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPHP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPerl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProPython")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRuby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProRust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSQLServer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProSwift")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyResponses2016");
                });
#pragma warning restore 612, 618
        }
    }
}
