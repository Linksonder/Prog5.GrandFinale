MERGE INTO Person AS Target  
USING (values 
	(1, 'Stijn',  26),
	(2, 'Ger', 28),
	(3, 'Rik', 29),
	(4, 'Martijn' , 27)
) AS Source (Id, Name, Age)  
ON Target.Id = Source.Id  
WHEN NOT MATCHED BY TARGET THEN  
	INSERT (Id, Name, Age)  
	VALUES (Id, Name, Age);
--WHEN MATCHED THEN
--	UPDATE SET
--		Name = Source.Name,
--		Summary = Source.Summary,
--		TeacherId = Source.TeacherId;
