Use DatabaseCreation
GO
CREATE PROCEDURE GetCityAndEventDetails
    @CityID INT
AS
BEGIN
    SELECT 
        c.CityID,
        c.CityName,
        c.AvgTemp,
        e.EventID,
        e.EventName,
        e.EventPrice
    FROM 
        City c
    INNER JOIN 
        Event e ON c.CityID = e.CityID
    WHERE 
        c.CityID = @CityID;
END;
GO

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