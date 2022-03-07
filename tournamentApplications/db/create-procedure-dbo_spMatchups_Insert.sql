USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 7/03/2022 21:58:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[spMatchups_Insert]
	@TournamentId int,
	@MatchupRound int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Matchups (Tournament_id, MatchupRound)
	values (@TournamentId, @MatchupRound);

	select @id = SCOPE_IDENTITY();
END
GO


