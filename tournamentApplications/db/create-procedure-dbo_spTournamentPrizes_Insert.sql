USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 7/03/2022 22:03:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert] 
	@Tournament_id int,
	@Prize_id int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Tournaments_Prizes (Tournament_id, Prize_id)
	values(@Tournament_id, @Prize_id);

	select @id = SCOPE_IDENTITY();
END
GO


