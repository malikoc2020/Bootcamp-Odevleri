USE [LogoDB]
GO
/* Veritaban�nda olu�turulan Company tablosuna kay�t ekleyen insert stored procerude scripti */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 /*user tablosu ile 1 e 1 ili�ki oldu�undan id alan� otomatik artan yap�lmad� ve burada parametre olarak user tablosundaki kar��l��� olan id alan� olacak �ekilde beklenerek d��ardan istenildi.*/
ALTER PROCEDURE [dbo].[spCompany_insert]
	@id int 
	  ,@Name nvarchar(1000)
      ,@NameShort nvarchar(100)
      ,@Mail nvarchar(250)
      ,@Address nvarchar(1000)
      ,@Phone nvarchar(50)
      ,@Descriptions nvarchar(max)
      ,@DateCreated datetime2(7)
      ,@IsActive bit
	  ,@Result bit out
	  ,@ErrorMessage varchar(max) out
AS
BEGIN
	SET NOCOUNT ON;
	SET @Result = 1;
	SET @ErrorMessage = '';
	
	IF((select count(Id) from tblCompany where Id = @id)>0)
	BEGIN
		SET @Result = 0;
		SET @ErrorMessage = CONVERT(varchar(max),@id) + ' id''li kay�t daha �nce eklenmi�. Ayn� Id''de ikinci bir kay�t olu�turulamaz.';
	END
	ELSE
	BEGIN

    insert into dbo.tblCompany
	( [Id]
	  ,[Name]
      ,NameShort
      ,[Mail]
      ,[Address]
      ,[Phone]
      ,[Descriptions]
      ,[DateCreated]
      ,[IsActive])
	  values(
	   @id
	  ,@Name 
      ,@NameShort 
      ,@Mail  
      ,@Address 
      ,@Phone  
      ,@Descriptions
      ,@DateCreated  
      ,@IsActive  
	  )

	  END
END
