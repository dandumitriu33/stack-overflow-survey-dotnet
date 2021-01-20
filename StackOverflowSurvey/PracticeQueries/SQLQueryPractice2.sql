--SELECT COUNT(DISTINCT Country) FROM SurveyResponses2011

SELECT Country, COUNT(Country) as Num FROM SurveyResponses2015
GROUP BY Country
ORDER BY Country