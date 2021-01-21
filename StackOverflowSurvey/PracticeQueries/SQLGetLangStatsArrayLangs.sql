DECLARE @CountryName AS VARCHAR(100) = 'Hong Kong'
DECLARE @AltCountryName AS VARCHAR(100) = 'Other Asia'
DECLARE @LanguagesFromRequest TABLE (languageName VARCHAR(100)) 
INSERT @LanguagesFromRequest(languageName) values ('LanguageProC'),('LanguageProCPlusPlus');

PRINT @CountryName
PRINT @AltCountryName


SELECT Country,
	  '2020' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2020
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2019' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2019
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country,
	  '2018' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2018
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2017' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2017
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2016' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2016
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2015' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2015
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2014' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2014
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2013' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2013
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2012' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2012
WHERE Country = @CountryName OR Country = @AltCountryName
UNION
SELECT Country, 
	  '2011' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE (Country = @CountryName OR Country = @AltCountryName) AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName OR Country = @AltCountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2011
WHERE Country = @CountryName OR Country = @AltCountryName
GROUP BY Country
ORDER BY SurveyYear