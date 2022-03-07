USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 7/03/2022 22:02:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
	@Tournament_id int,
	@Team_id int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Tournaments_Entries (Tournament_id, Team_id)
	values (@Tournament_id, @Team_id);

	select @id = SCOPE_IDENTITY();
END
GO


