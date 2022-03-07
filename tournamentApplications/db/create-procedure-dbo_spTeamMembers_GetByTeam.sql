USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 7/03/2022 22:02:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	select p.*
	from dbo.Team_Members m
	inner join dbo.people p on m.Person_id = p.id
	where m.Team_id = @TeamId;
END
GO


