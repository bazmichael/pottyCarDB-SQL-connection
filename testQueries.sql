

SELECT * FROM [dbo].[CarsDB];

INSERT INTO [dbo].[CarsDB]([Marka], [DataProdukcji], [LiczbaDrzwi],[NrRejestracyjny], [Przebieg]) VALUES('a', GETDATE(),  4, '123FCA', 150);

delete from [dbo].[CarsDB] where [NrRejestracyjny] = '123FCA';