USE DatabaseCreation;
GO

CREATE PROCEDURE GetEventsByName
--Only show events of a certain type like amusement park or sporting event.
  @EventName nvarchar(50)
AS
BEGIN
  SELECT e.EventID, e.EventName, e.CityID FROM Event e
  WHERE e.EventName = @EventName;
END;
GO
EXEC GetEventsByName @EventName = 'Amusement Park';
GO

CREATE PROCEDURE GetEventsListByTemp
--List event info organized by average temperature of city they're in.
AS
BEGIN
  SELECT e.EventID, e.EventName, c.CityName, c.AvgTemp FROM Event e
  INNER JOIN City c ON c.CityID=e.CityID
  ORDER BY c.AvgTemp DESC;
END;
GO
EXEC GetEventsListByTemp;
GO
