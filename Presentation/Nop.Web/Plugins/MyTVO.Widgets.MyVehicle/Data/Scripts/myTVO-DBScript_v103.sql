/****** Object:  Table [dbo].[myTVO_Device]    Script Date: 02/12/2021 12:37:09 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_Device')
BEGIN
CREATE TABLE [dbo].[myTVO_Device](
	[DeviceID] [int] IDENTITY(1,1) NOT NULL,
	[DeviceUserID] [int] NOT NULL,
	[DeviceStatusID] [int] NOT NULL,
	[DeviceType] [int] NULL,
	[DeviceMakeModel] [nvarchar](50) NULL,
	[DeviceOS] [nvarchar](20) NULL,
	[DeviceOSVersion] [nvarchar](20) NULL,
	[DeviceSerialNo] [nvarchar](50) NULL,
	[DeviceActivationDate] [datetime2](7) NULL,
	[DeviceActivationGuid] [uniqueidentifier] NULL,
	[DeviceActivationIP] [nvarchar](50) NULL,
	[DeviceCeaseDate] [datetime2](7) NULL,
	[DeviceCeaseReason] [nvarchar](200) NULL,
	[DeviceNotificationToken] [nvarchar](max) NULL,
	[DeviceManufacturer] [nvarchar](200) NULL,
	[DeviceName] [nvarchar](200) NULL,
	[DeviceSiteCodeName] [nvarchar](200) NULL,
	[DeviceLastModified] [datetime2](7) NULL,
	[DeviceGuid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_myTVO_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_DocType]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_DocType')
BEGIN
CREATE TABLE [dbo].[myTVO_DocType](
	[DocTypeID] [int] IDENTITY(1,1) NOT NULL,
	[DocTypeName] [varchar](50) NULL,
	[DocTypeCode] [varchar](50) NULL,
	[DocTypeGUID] [uniqueidentifier] NULL,
	[DocTypeLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_DocType] PRIMARY KEY CLUSTERED 
(
	[DocTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_ImageAvatar]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_ImageAvatar')
BEGIN
CREATE TABLE [dbo].[myTVO_ImageAvatar](
	[ImageAvatarID] [int] IDENTITY(1,1) NOT NULL,
	[ImageID] [int] NULL,
	[AvatarID] [int] NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_VehicleInfoImageAvatar] PRIMARY KEY CLUSTERED 
(
	[ImageAvatarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_Invoice]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_Invoice')
BEGIN
CREATE TABLE [dbo].[myTVO_Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceAmount] [float] NULL,
	[InvoicePaid] [bit] NULL,
	[InvoiceDueDate] [datetime] NULL,
	[InvoiceLink] [varchar](200) NULL,
	[InvoiceGUID] [uniqueidentifier] NULL,
	[InvoiceLastModified] [datetime] NULL,
	[InvoiceTypeID] [int] NULL,
 CONSTRAINT [PK_myTVO_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_InvoiceType]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_InvoiceType')
BEGIN
CREATE TABLE [dbo].[myTVO_InvoiceType](
	[InvoiceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceTypeName] [varchar](50) NULL,
	[InvoiceTypeCode] [varchar](50) NULL,
	[InvoiceTypeGUID] [uniqueidentifier] NULL,
	[InvoiceTypeLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_InvoiceType] PRIMARY KEY CLUSTERED 
(
	[InvoiceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_Notification]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_Notification')
BEGIN
CREATE TABLE [dbo].[myTVO_Notification](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[NotificationUserID] [int] NOT NULL,
	[NotificationLinkID] [bigint] NULL,
	[NotificationClass] [nvarchar](100) NOT NULL,
	[NotificationToken] [nvarchar](max) NULL,
	[NotificationUrl] [nvarchar](max) NULL,
	[NotificationSubject] [nvarchar](200) NULL,
	[NotificationBody] [nvarchar](max) NULL,
	[NotificationStatus] [nvarchar](10) NULL,
	[NotificationSentDateTime] [datetime2](7) NULL,
	[NotificationSentResponse] [nvarchar](max) NULL,
	[NotificationIsRead] [bit] NOT NULL,
	[NotificationReleaseDate] [datetime2](7) NOT NULL,
	[NotificationImageURL] [nvarchar](1000) NULL,
	[NotificationSiteID] [int] NULL,
	[NotificationLastModified] [datetime2](7) NULL,
	[NotificationGuid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_myTVO_Notification] PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_NotificationSetting]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_NotificationSetting')
BEGIN
CREATE TABLE [dbo].[myTVO_NotificationSetting](
	[NotificationSettingID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNotification] [bit] NULL,
	[ReminderNotification] [bit] NULL,
	[DocumentNotificationValue] [varchar](100) NULL,
	[ReminderNotificationValue] [varchar](100) NULL,
	[NotificationDeviceID] [int] NULL,
	[NotificationSettingUserID] [int] NULL,
 CONSTRAINT [PK_myTVO_NotificationSetting] PRIMARY KEY CLUSTERED 
(
	[NotificationSettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_UserDoc]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_UserDoc')
BEGIN
CREATE TABLE [dbo].[myTVO_UserDoc](
	[UserDocID] [int] IDENTITY(1,1) NOT NULL,
	[UserDocType] [int] NULL,
	[UserDocTitle] [varchar](100) NULL,
	[UserDocTag] [varchar](200) NULL,
	[UserDocStatus] [bit] NULL,
	[UserDocStartDate] [datetime2](7) NULL,
	[UserDocExpireDate] [datetime2](7) NULL,
	[UserDocSecurityID] [int] NULL,
	[UserDocGUID] [uniqueidentifier] NULL,
	[UserDocLastModified] [datetime] NULL,
	[UserDocUserID] [int] NULL,
 CONSTRAINT [PK_myTVO_UserDoc] PRIMARY KEY CLUSTERED 
(
	[UserDocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_UserEmergency]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_UserEmergency')
BEGIN
CREATE TABLE [dbo].[myTVO_UserEmergency](
	[UserEmergencyID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[EmergencyContact] [nvarchar](26) NULL,
	[EmergencyName] [varchar](100) NULL,
 CONSTRAINT [PK_myTVO_UserEmergency] PRIMARY KEY CLUSTERED 
(
	[UserEmergencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_UserPanel]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_UserPanel')
BEGIN
CREATE TABLE [dbo].[myTVO_UserPanel](
	[UserPanelID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[WorkshopID] [int] NULL,
 CONSTRAINT [PK_myTVO_UserPanel] PRIMARY KEY CLUSTERED 
(
	[UserPanelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_UserReminder]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_UserReminder')
BEGIN
CREATE TABLE [dbo].[myTVO_UserReminder](
	[ReminderID] [int] IDENTITY(1,1) NOT NULL,
	[ReminderDisplayName] [nvarchar](256) NULL,
	[ReminderName] [nvarchar](256) NULL,
	[ReminderCategoryID] [int] NULL,
	[ReminderEnabled] [bit] NULL,
	[ReminderGUID] [uniqueidentifier] NULL,
	[ReminderLastModified] [datetime2](7) NULL,
	[ReminderDescription] [nvarchar](500) NULL,
	[ReminderStartDate] [datetime2](7) NULL,
	[ReminderExpireDate] [datetime2](7) NULL,
	[ReminderType] [int] NULL,
	[ReminderUserID] [int] NULL,
 CONSTRAINT [PK_myTVO_UserReminder] PRIMARY KEY CLUSTERED 
(
	[ReminderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_UserReminderCategory]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_UserReminderCategory')
BEGIN
CREATE TABLE [dbo].[myTVO_UserReminderCategory](
	[ReminderCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ReminderCategoryName] [nvarchar](200) NULL,
	[ReminderCategoryDisplayName] [nvarchar](200) NULL,
	[ReminderCategoryGUID] [uniqueidentifier] NULL,
	[ReminderCategoryLastModified] [datetime2](7) NULL,
 CONSTRAINT [PK_myTVO_UserReminderCategory] PRIMARY KEY CLUSTERED 
(
	[ReminderCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleAccident]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleAccident')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleAccident](
	[VehicleAccidentID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleAccidentUserID] [int] NULL,
	[VehicleAccidentInfoID] [int] NULL,
	[VehicleAccidentDate] [datetime] NULL,
	[VehicleAccidentDescription] [nvarchar](max) NULL,
	[VehicleAccidentDamage] [nvarchar](max) NULL,
	[VehicleAccidentStatus] [int] NULL,
	[VehicleAccidentNotes] [nvarchar](max) NULL,
	[VehicleAccidentType] [int] NULL,
	[VehicleAccidentRegNo] [nvarchar](20) NULL,
	[VehicleAccidentGUID] [uniqueidentifier] NULL,
	[VehicleAccidentLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_VehicleAccident] PRIMARY KEY CLUSTERED 
(
	[VehicleAccidentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleCustomInfo]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleCustomInfo')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleCustomInfo](
	[VehicleCustomID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleInfoID] [int] NULL,
	[VehicleCustomIsColor] [bit] NOT NULL,
	[VehicleCustomIsMake] [bit] NOT NULL,
	[VehicleCustomIsModel] [bit] NOT NULL,
	[VehicleCustomColor] [varchar](50) NULL,
	[VehicleCustomMake] [varchar](100) NULL,
	[VehicleCustomModel] [varchar](100) NULL,
 CONSTRAINT [PK_myTVO_VehicleCustomInfo] PRIMARY KEY CLUSTERED 
(
	[VehicleCustomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleDoc]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleDoc')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleDoc](
	[VehicleDocID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleDocType] [int] NULL,
	[VehicleDocTitle] [nvarchar](100) NULL,
	[VehicleDocTag] [nvarchar](200) NULL,
	[VehicleDocStatus] [bit] NULL,
	[VehicleDocStartDate] [datetime2](7) NULL,
	[VehicleDocExpireDate] [datetime2](7) NULL,
	[VehicleDocVehicleInfoID] [int] NULL,
	[VehicleDocSecurityID] [int] NULL,
	[VehicleDocGUID] [uniqueidentifier] NULL,
	[VehicleDocLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_VehicleDoc] PRIMARY KEY CLUSTERED 
(
	[VehicleDocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleDocFile]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleDocFile')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleDocFile](
	[VehicleDocFileID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleDocKey] [varbinary](max) NULL,
	[VehicleDocData] [varbinary](max) NULL,
	[VehicleDocCipher] [varbinary](max) NULL,
	[VehicleDocThumbKey] [varbinary](max) NULL,
	[VehicleDocThumbData] [varbinary](max) NULL,
	[VehicleDocThumbCipher] [varbinary](max) NULL,
	[VehicleDocExtension] [varchar](20) NULL,
	[VehicleDocID] [int] NULL,
	[VehicleDocGUID] [uniqueidentifier] NULL,
	[VehicleDocLastModified] [datetime] NULL,
	[UserDocID] [int] NULL,
 CONSTRAINT [PK_myTVO_VehicleDocFile] PRIMARY KEY CLUSTERED 
(
	[VehicleDocFileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleInfo]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleInfo')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleInfo](
	[VehicleInfoID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleInfoNo] [varchar](20) NOT NULL,
	[VehicleInfoMake] [int] NULL,
	[VehicleInfoModel] [int] NULL,
	[VehicleInfoColor] [varchar](50) NULL,
	[VehicleInfoMakeYear] [int] NULL,
	[VehicleInfoRegistrationDate] [datetime] NOT NULL,
	[VehicleInfoEngineNo] [varchar](50) NULL,
	[VehicleInfoChassisNo] [varchar](50) NULL,
	[VehicleInfoGUID] [uniqueidentifier] NULL,
	[VehicleInfoLastModified] [datetime] NULL,
	[VehicleInfoCategory] [varchar](200) NULL,
	[VehicleInfoUserID] [int] NULL,
	[VehicleInfoMakeCustom] [varchar](100) NULL,
	[VehicleInfoModelCustom] [varchar](100) NULL,
	[VehicleInfoColorCustom] [varchar](50) NULL,
 CONSTRAINT [PK_myTVO_VehicleInfo_1] PRIMARY KEY CLUSTERED 
(
	[VehicleInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleMake]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleMake')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleMake](
	[VehicleMakeID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleMakeName] [nvarchar](255) NULL,
	[VehicleMakeCode] [nvarchar](255) NULL,
	[VehicleMakeGUID] [nvarchar](255) NULL,
	[VehicleMakeLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_VehicleMake] PRIMARY KEY CLUSTERED 
(
	[VehicleMakeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleModel]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleModel')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleModel](
	[VehicleModelMakeID] [int] NULL,
	[VehicleModelName] [nvarchar](255) NOT NULL,
	[VehicleModelCode] [nvarchar](255) NOT NULL,
	[VehicleModelDescription] [nvarchar](255) NULL,
	[VehicleModelEngine] [nvarchar](255) NULL,
	[VehicleModelYearFrom] [date] NULL,
	[VehicleModelYearTo] [date] NULL,
	[VehicleModelID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleModelGUID] [uniqueidentifier] NULL,
	[VehicleModelLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_VehicleModel] PRIMARY KEY CLUSTERED 
(
	[VehicleModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_VehicleServiceHistory]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_VehicleServiceHistory')
BEGIN
CREATE TABLE [dbo].[myTVO_VehicleServiceHistory](
	[VehicleServiceHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleServiceDate] [datetime] NULL,
	[VehicleServiceNextDate] [datetime] NULL,
	[VehicleServiceWorkshopID] [int] NULL,
	[VehicleServiceWorkshopName] [varchar](200) NULL,
	[VehicleServiceInfoID] [int] NULL,
	[VehicleServiceCurrentOdometer] [int] NULL,
	[VehicleServiceNextOdometere] [int] NULL,
	[VehicleServiceHistoryGUID] [uniqueidentifier] NULL,
	[VehicleServiceHistoryLastModified] [datetime] NULL,
	[VehicleServiceInvoiceID] [int] NULL,
 CONSTRAINT [PK_myTVO_VehicleServiceHistory] PRIMARY KEY CLUSTERED 
(
	[VehicleServiceHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_Workshop]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_Workshop')
BEGIN
CREATE TABLE [dbo].[myTVO_Workshop](
	[WorkshopID] [int] IDENTITY(1,1) NOT NULL,
	[WorkshopUserID] [int] NULL,
	[WorkshopName] [varchar](200) NULL,
	[WorkshopCategoryID] [int] NULL,
	[WorkshopGPSLocation] [varchar](100) NULL,
	[WorkshopPIC] [varchar](100) NULL,
	[WorkshopMobile] [varchar](20) NULL,
	[WorkshopTel] [varchar](20) NULL,
	[WorkshopAddress1] [varchar](200) NULL,
	[WorkshopAddress2] [varchar](200) NULL,
	[WorkshopCity] [varchar](50) NULL,
	[WorkshopStateID] [int] NULL,
	[WorkshopCountryID] [int] NULL,
	[WorkshopPostalCode] [nvarchar](20) NULL,
	[WorkshopGUID] [uniqueidentifier] NULL,
	[WorkshopLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_Workshop] PRIMARY KEY CLUSTERED 
(
	[WorkshopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_WorkshopAppointment]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_WorkshopAppointment')
BEGIN
CREATE TABLE [dbo].[myTVO_WorkshopAppointment](
	[WorkshopAppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentVehicleInfoID] [int] NULL,
	[AppointmentUserID] [int] NULL,
	[AppointmentTitle] [varchar](100) NULL,
	[AppointmentStatus] [int] NULL,
	[AppointmentPeriority] [int] NULL,
	[AppointmentReminder] [datetime] NULL,
	[AppointmentStartDate] [date] NULL,
	[AppointmentEndDate] [date] NULL,
	[AppointmentStartTime] [nvarchar](10) NULL,
	[AppointmentEndTime] [nvarchar](10) NULL,
	[AppointmentNotes] [nvarchar](max) NULL,
	[AppointmentGUID] [uniqueidentifier] NULL,
	[AppointmentLastModified] [datetime] NULL,
	[AppointmentWorkshopID] [int] NULL,
 CONSTRAINT [PK_myTVO_WorkshopAppointment] PRIMARY KEY CLUSTERED 
(
	[WorkshopAppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[myTVO_WorkshopCategory]    Script Date: 02/12/2021 12:37:10 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS(SELECT * FROM sys.objects WHERE [type] = 'U' AND [name] = 'myTVO_WorkshopCategory')
BEGIN
CREATE TABLE [dbo].[myTVO_WorkshopCategory](
	[WorkshopCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[WorkshopCategoryName] [varchar](50) NULL,
	[WorkshopCategoryCode] [varchar](50) NULL,
	[WorkshopCategoryGUID] [uniqueidentifier] NULL,
	[WorkshopCategoryLastModified] [datetime] NULL,
 CONSTRAINT [PK_myTVO_WorkshopCategory] PRIMARY KEY CLUSTERED 
(
	[WorkshopCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
