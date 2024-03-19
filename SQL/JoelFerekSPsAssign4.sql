Use DatabaseCreation
GO
CREATE PROCEDURE GetCityAvgTemp
    @CityID INT
AS
BEGIN
    SELECT AvgTemp
    FROM City
    WHERE CityID = @CityID;
END;
GO

EXEC GetCityAvgTemp @CityID = 1;
CREATE PROCEDURE GetEventsByCityID
    @CityID INT
AS
BEGIN
    SELECT e.EventID, e.EventName, e.EventPrice
    FROM Event e
    WHERE e.CityID = @CityID;
END;
GO
EXEC GetEventsByCityID @CityID = 1;
GO
