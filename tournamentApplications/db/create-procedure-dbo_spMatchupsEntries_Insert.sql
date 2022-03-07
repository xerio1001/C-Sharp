USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 7/03/2022 22:00:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

  insert into dbo.Macthup_Entries (Matchup_id, ParentMatchup_id, TeamCompeting_id)
  values (@MatchupId, @ParentMatchupId, @TeamCompetingId);
  
  select @id = SCOPE_IDENTITY();
END
GO


