USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournament_Insert]    Script Date: 7/03/2022 22:02:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(50),
	@EntryFee decimal,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.Tournaments (TournamentName, EntryFee)
	values (@TournamentName, @EntryFee);

	select @id = SCOPE_IDENTITY();
END
GO


