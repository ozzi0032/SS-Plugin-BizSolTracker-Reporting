USE [SmartStoreDB]
GO

INSERT INTO [dbo].[MessageTemplate]
           ([Name]
           ,[BccEmailAddresses]
           ,[Subject]
           ,[Body]
           ,[IsActive]
           ,[EmailAccountId]
           ,[LimitedToStores]
           ,[SendManually]
           ,[Attachment1FileId]
           ,[Attachment2FileId]
           ,[Attachment3FileId]
           ,[To]
           ,[ReplyTo]
           ,[ModelTypes]
           ,[LastModelTree])
     VALUES
           ('RegInvitation.ToAddress'
           ,null
           ,'{{ RegInvitation.Url }}'
           ,'Redirect to link for registration!'
           ,1
           ,1
           ,0
           ,0
           ,null
           ,null
           ,null
           ,'{{ RegInvitation.ToAddress }}'
           ,null
           ,null
           ,null)
GO


