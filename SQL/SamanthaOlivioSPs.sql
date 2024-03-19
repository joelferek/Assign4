USE DatabaseCreation;
GO

CREATE PROCEDURE GetCityWithHighestEventCount
AS
BEGIN
    SELECT TOP 1 c.CityID, c.CityName, c.AvgTemp, COUNT(e.EventID) AS EventCount
    FROM City c
    INNER JOIN Event e ON c.CityID = e.CityID
    GROUP BY c.CityID, c.CityName, c.AvgTemp
    ORDER BY EventCount DESC;
END;
GO
EXEC GetCityWithHighestEventCount;
GO

CREATE PROCEDURE FindCheapestEvents
AS
BEGIN
    SELECT EventID, EventName, EventPrice
    FROM Event
    WHERE EventPrice = (SELECT MIN(EventPrice) FROM Event);
END;
GO
EXEC FindCheapestEvents;
GO