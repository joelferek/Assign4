INSERT INTO [dbo].[City] ([CityID], [CityName], [AvgTemp])
VALUES
    (1, 'Las Vegas', '75'),
    (2, 'San Francisco', '68'),
    (3, 'Green Bay', '50'),
    (4, 'New England', '48'),
    (5, 'Chicago', '45'),
    (6, 'Philadelphia', '54'),
    (7, 'Seattle', '55'),
    (8, 'New York', '58'),
    (9, 'Baltimore', '60'),
    (10, 'Pittsburgh', '53'),
    (11, 'Tampa Bay', '78'),
    (12, 'Denver', '65'),
    (13, 'Houston', '77'),
    (14, 'Minnesota', '45'),
    (15, 'Kansas City', '62'),
    (16, 'Cleveland', '51'),
    (17, 'Atlanta', '70'),
    (18, 'New Orleans', '75'),
    (19, 'Dallas', '80'),
    (20, 'Carolina', '72'),
    (21, 'Washington', '65'),
    (22, 'Los Angeles', '75'),
    (23, 'Tennessee', '68'),
    (24, 'Indianapolis', '55'),
    (25, 'Miami', '82'),
    (26, 'Detroit', '53'),
    (27, 'Arizona', '80'),
    (28, 'Buffalo', '48'),
    (29, 'Cincinnati', '55'),
    (30, 'Jacksonville', '80');

INSERT INTO [dbo].[Event] ([EventID], [EventName], [EventPrice], [CityID])
VALUES
    (1, 'Sporting Event', '50', 1),   -- Las Vegas
    (2, 'Amusement Park', '30', 2),   -- San Francisco
    (3, 'Skiing Trip', '100', 3),     -- Green Bay
    (4, 'Sporting Event', '70', 4),   -- New England
    (5, 'Amusement Park', '40', 5),   -- Chicago
    (6, 'Skiing Trip', '120', 6),     -- Philadelphia
    (7, 'Sporting Event', '60', 7),   -- Seattle
    (8, 'Amusement Park', '35', 8),   -- New York
    (9, 'Skiing Trip', '110', 9),     -- Baltimore
    (10, 'Sporting Event', '65', 10); -- Pittsburgh

	INSERT INTO [dbo].[Event] ([EventID], [EventName], [EventPrice], [CityID])
VALUES
    (11, 'Sporting Event', '75', 11),  -- Tampa Bay
    (12, 'Amusement Park', '45', 12),  -- Denver
    (13, 'Skiing Trip', '130', 13),    -- Houston
    (14, 'Sporting Event', '55', 14),  -- Minnesota
    (15, 'Amusement Park', '50', 15),  -- Kansas City
    (16, 'Skiing Trip', '140', 16),    -- Cleveland
    (17, 'Sporting Event', '80', 17),  -- Atlanta
    (18, 'Amusement Park', '60', 18),  -- New Orleans
    (19, 'Skiing Trip', '150', 19),    -- Dallas
    (20, 'Sporting Event', '70', 20),  -- Carolina
    (21, 'Amusement Park', '55', 21),  -- Washington
    (22, 'Skiing Trip', '160', 22),    -- Los Angeles
    (23, 'Sporting Event', '85', 23),  -- Tennessee
    (24, 'Amusement Park', '65', 24),  -- Indianapolis
    (25, 'Skiing Trip', '170', 25),    -- Miami
    (26, 'Sporting Event', '60', 26),  -- Detroit
    (27, 'Amusement Park', '70', 27),  -- Arizona
    (28, 'Skiing Trip', '180', 28),    -- Buffalo
    (29, 'Sporting Event', '65', 29),  -- Cincinnati
    (30, 'Amusement Park', '75', 30);  -- Jacksonville