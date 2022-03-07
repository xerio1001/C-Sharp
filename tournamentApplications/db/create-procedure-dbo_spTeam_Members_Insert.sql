USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeam_Members_Insert]    Script Date: 7/03/2022 22:01:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeam_Members_Insert]
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.Team_Members (Team_id, Person_id)
	values (@TeamId, @PersonId);

	select @id = SCOPE_IDENTITY();
END
GO


