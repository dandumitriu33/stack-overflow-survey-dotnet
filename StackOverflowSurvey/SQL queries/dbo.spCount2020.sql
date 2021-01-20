Create procedure spCount2020
                                 @p1 int = 0
                                 as
                                 Begin
                                    Select @p1 = count(*)
                                    from SurveyResponses2020
                                 End