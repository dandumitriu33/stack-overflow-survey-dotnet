using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowSurvey.Web.Models
{
    public class SurveyResponse2020Model
    {
        public int Id { get; set; }
        public string Country { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProC { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProCPlusPlus { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProCSharp { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProGo { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProJava { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProJavaScript { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProNodeJs { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProObjectiveC { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProPerl { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProPHP { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProPython { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProRuby { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProRust { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProSQL { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProSQLServer { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LanguageProSwift { get; set; }
    }
}
