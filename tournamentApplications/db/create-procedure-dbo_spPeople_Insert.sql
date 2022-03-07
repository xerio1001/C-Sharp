USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 7/03/2022 22:01:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@CellphoneNumber nvarchar(30),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.People (FirstName, LastName, Email, CellphoneNumber)
	values (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);

	select @id = SCOPE_IDENTITY();
END
GO


