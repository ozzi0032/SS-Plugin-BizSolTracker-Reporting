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
           ('RegConfirmation.ToAddress'
           ,null
           ,'Welcome from - {{ RegConfirmation.FirmName }}'
           ,'{{ RegConfirmation.Message }}'
           ,1
           ,1
           ,0
           ,0
           ,null
           ,null
           ,null
           ,'{{ RegConfirmation.ToAddress }}'
           ,null
           ,null
           ,null)
GO


