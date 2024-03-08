USE DatabaseCreation;
GO

CREATE PROCEDURE GetEventsByCityName
    @CityName NVARCHAR(255)
AS
BEGIN
    SELECT e.EventID, e.EventName, e.EventPrice
    FROM Event e
    INNER JOIN City c ON e.CityID = c.CityID
    WHERE c.CityName = @CityName;
END;
GO

CREATE PROCEDURE GetCitiesByAvgTempAboveThreshold
    @ThresholdTemp INT
AS
BEGIN
    SELECT CityID, CityName, AvgTemp
    FROM City
    WHERE AvgTemp > @ThresholdTemp;
END;
GO 
EXEC GetCitiesByAvgTempAboveThreshold @ThresholdTemp = 70;
GO