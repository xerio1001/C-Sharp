USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 7/03/2022 22:02:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Teams (Name)
	values (@TeamName);

	select @id = SCOPE_IDENTITY();
END
GO


