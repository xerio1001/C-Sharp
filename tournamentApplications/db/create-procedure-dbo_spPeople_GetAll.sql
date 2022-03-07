USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 7/03/2022 22:00:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPeople_GetAll]
	
AS
BEGIN
	select *
	from dbo.People
END
GO


