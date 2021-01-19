-- SELECT TOP 100 * FROM SurveyResponses2020;

--SELECT count(*) FROM SurveyResponses2020
--WHERE Country = 'Germany'

--SELECT count(*) FROM SurveyResponses2020
--WHERE Country = 'Germany' and LanguageProC = 'C'


--SELECT Country, ((SELECT count(Country)) * 100 / (SELECT count(*) FROM SurveyResponses2020)) as 'Percent'
--FROM SurveyResponses2020
--GROUP BY Country
--ORDER BY Country

--SELECT Country, 	
--	  (
--	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = 'Germany' AND LanguageProC = 'C') * 100 /
--	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = 'Germany')
--	  )
--	  as 'C_Percent'
--FROM SurveyResponses2020
--WHERE Country = 'Germany'
--GROUP BY Country

DECLARE @CountryName AS VARCHAR(100) = 'Germany'
PRINT @CountryName
SELECT Country,
	  '2020' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2020 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2020
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2019' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2019 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2019
WHERE Country = @CountryName
UNION
SELECT Country,
	  '2018' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2018 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2018
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2017' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2017 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2017
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2016' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2016 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2016
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2015' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Perl_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2015 WHERE Country = @CountryName)
	  )
	  as 'Swift_Percent'
FROM SurveyResponses2015
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2014' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Go_Percent',
	  '0' as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND ObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Perl_Percent',
	  '0' as Perl_Percent,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  '0' as Swift_Percent
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Swift_Percent'
FROM SurveyResponses2014
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2013' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Go_Percent',
	  '0' as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND ObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Perl_Percent',
	  '0' as Perl_Percent,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2013 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  '0' as Swift_Percent
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Swift_Percent'
FROM SurveyResponses2013
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2012' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Go_Percent',
	  '0' as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND ObjectiveC = 'Objective-C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'ObjectiveC_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Perl_Percent',
	  '0' as Perl_Percent,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2012 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  '0' as Swift_Percent
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Swift_Percent'
FROM SurveyResponses2012
WHERE Country = @CountryName
UNION
SELECT Country, 
	  '2011' as SurveyYear,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProC = 'C') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'C_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProCPlusPlus = 'C++') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'C++_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProCSharp = 'C#') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'C#_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProGo = 'Go') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Go_Percent',
	  '0' as 'Go_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProJava = 'Java') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'Java_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProJavaScript = 'JavaScript') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'JS_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND ObjectiveC = 'Objective-C') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  --)
	  --as 'ObjectiveC_Percent',
	  '0' as 'ObjectiveC_Percent',
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProPerl = 'Perl') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Perl_Percent',
	  '0' as Perl_Percent,
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProPHP = 'PHP') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'PHP_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProPython = 'Python') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'Python_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProRuby = 'Ruby') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'Ruby_Percent',
	  (
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName AND LanguageProSQL = 'SQL') * 100 /
	  (SELECT COUNT(*) FROM SurveyResponses2011 WHERE Country = @CountryName)
	  )
	  as 'SQL_Percent',
	  '0' as Swift_Percent
	  --(
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName AND LanguageProSwift = 'Swift') * 100 /
	  --(SELECT COUNT(*) FROM SurveyResponses2014 WHERE Country = @CountryName)
	  --)
	  --as 'Swift_Percent'
FROM SurveyResponses2011
WHERE Country = @CountryName
GROUP BY Country
ORDER BY SurveyYear