USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeam_GetAll]    Script Date: 7/03/2022 22:01:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeam_GetAll]

AS
BEGIN
	SET NOCOUNT ON;

	select *
	from dbo.Teams;
END
GO


