create database DatabaseCreation;
GO

use DatabaseCreation;
GO

CREATE TABLE [dbo].[City](
	[CityID] [int] NOT NULL,
	[CityName] [nvarchar](50) NULL,
	[AvgTemp] [nvarchar](50) NULL)

GO

CREATE TABLE [dbo].[Event](
	[EventID] [int] NOT NULL,
	[EventName] [nvarchar](50) NULL,
	[EventPrice] [nvarchar](50) NULL,
	[CityID] [int] NOT NULL)

	GO