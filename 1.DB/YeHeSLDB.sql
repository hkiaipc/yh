set quoted_identifier on 
GO

/****** ����: �û� dbo    �ű�����: 2010-08-20 10:16:06 ******/
/****** ����: �û� guest    �ű�����: 2010-08-20 10:16:06 ******/
if not exists (select * from dbo.sysusers where name = N'guest' and hasdbaccess = 1)
	EXEC sp_grantdbaccess N'guest'
GO

/****** ����: ��ͼ dbo.VIEW3    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VIEW3]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[VIEW3]
GO

/****** ����: ��ͼ dbo.vRainFillData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRainFillData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRainFillData]
GO

/****** ����: ��ͼ dbo.vRTDitchData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTDitchData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTDitchData]
GO

/****** ����: ��ͼ dbo.vRTRainFillData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTRainFillData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTRainFillData]
GO

/****** ����: ��ͼ dbo.vRTSluiceData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTSluiceData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTSluiceData]
GO

/****** ����: ��ͼ dbo.vSluiceData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vSluiceData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vSluiceData]
GO

/****** ����: ��ͼ dbo.vWaterLevelData    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vWaterLevelData]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vWaterLevelData]
GO

/****** ����: ��ͼ dbo.waterDatas    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[waterDatas]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[waterDatas]
GO

/****** ����: ��ͼ dbo.vRTDitchStation    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTDitchStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTDitchStation]
GO

/****** ����: ��ͼ dbo.vRTRainFillStation    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTRainFillStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTRainFillStation]
GO

/****** ����: ��ͼ dbo.vRTSluiceStation    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vRTSluiceStation]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vRTSluiceStation]
GO

/****** ����: ��ͼ dbo.vWaterUser    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[vWaterUser]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[vWaterUser]
GO

/****** ����: �� [dbo].[tblWaterSourcePlan]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterSourcePlan]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterSourcePlan]
GO

/****** ����: �� [dbo].[tblDeivceDitch]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeivceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDeivceDitch]
GO

/****** ����: �� [dbo].[tblDeviceSluice]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceSluice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDeviceSluice]
GO

/****** ����: �� [dbo].[tblDitchData]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDitchData]
GO

/****** ����: �� [dbo].[tblIn]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblIn]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblIn]
GO

/****** ����: �� [dbo].[tblMeasureSluiceData]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblMeasureSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblMeasureSluiceData]
GO

/****** ����: �� [dbo].[tblOut]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblOut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblOut]
GO

/****** ����: �� [dbo].[tblRainFillData]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblRainFillData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblRainFillData]
GO

/****** ����: �� [dbo].[tblSluiceData]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblSluiceData]
GO

/****** ����: �� [dbo].[tblWaterLevelData]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterLevelData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterLevelData]
GO

/****** ����: �� [dbo].[tblWaterSource]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterSource]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterSource]
GO

/****** ����: �� [dbo].[tblDevice]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDevice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDevice]
GO

/****** ����: �� [dbo].[tblStation]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblStation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblStation]
GO

/****** ����: �� [dbo].[tblChannal]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblChannal]
GO

/****** ����: �� [dbo].[tblFee]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblFee]
GO

/****** ����: �� [dbo].[tblWaterUserPlan]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserPlan]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUserPlan]
GO

/****** ����: �� [dbo].[tblWaterUser]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUser]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUser]
GO

/****** ����: �� [dbo].[tb_menu]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_menu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_menu]
GO

/****** ����: �� [dbo].[tb_role]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_role]
GO

/****** ����: �� [dbo].[tb_role_linkmenu]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role_linkmenu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_role_linkmenu]
GO

/****** ����: �� [dbo].[tb_User]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tb_User]
GO

/****** ����: �� [dbo].[tblDBInfo]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDBInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblDBInfo]
GO

/****** ����: �� [dbo].[tblWaterUserLevel]    �ű�����: 2010-08-20 10:16:08 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblWaterUserLevel]
GO

/****** ����: �� [dbo].[tb_menu]    �ű�����: 2010-08-20 10:16:08 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_menu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_menu] (
	[menu_id] [int] IDENTITY (1, 1) NOT NULL ,
	[name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[fatherid] [int] NULL ,
	[seq] [int] NULL ,
	[menulink] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_type] [int] NULL 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tb_role]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_role] (
	[role_id] [int] IDENTITY (1, 1) NOT NULL ,
	[rolename] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_type] [int] NULL ,
	[remark] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tb_role_linkmenu]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_role_linkmenu]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_role_linkmenu] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[role_id] [int] NULL ,
	[menu_id] [int] NULL ,
	[father_id] [int] NULL 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tb_User]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tb_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tb_User] (
	[UserID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Password] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[role_id] [int] NOT NULL ,
	[WaterUserID] [int] NULL ,
	[Role] [smallint] NOT NULL 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblDBInfo]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDBInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDBInfo] (
	[DBInfoID] [int] IDENTITY (1, 1) NOT NULL ,
	[Project] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[DT] [datetime] NULL ,
	[MajorVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Major__286302EC] DEFAULT (0),
	[MinorVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Minor__29572725] DEFAULT (0),
	[RevisionVersion] [int] NOT NULL CONSTRAINT [DF__tblDBInfo__Revis__2A4B4B5E] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK__tblDBInfo__038683F8] PRIMARY KEY  NONCLUSTERED 
	(
		[DBInfoID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterUserLevel]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserLevel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUserLevel] (
	[WaterUserLevelID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserLevelName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Ordinal] [int] NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterU__Delet__76CBA758] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblWaterUserLevel_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserLevelID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterUser]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUser]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUser] (
	[WaterUserID] [int] IDENTITY (1, 1) NOT NULL ,
	[ParentWaterUserID] [int] NULL ,
	[WaterUserLevelID] [int] NULL ,
	[WaterUserName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[WaterUserType] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WaterUserInfo] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterU__Delet__07F6335A] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblWaterUser_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterUser_tblWaterUser_FK1] FOREIGN KEY 
	(
		[ParentWaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	),
	CONSTRAINT [tblWaterUserLevel_tblWaterUser_FK1] FOREIGN KEY 
	(
		[WaterUserLevelID]
	) REFERENCES [dbo].[tblWaterUserLevel] (
		[WaterUserLevelID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblChannal]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblChannal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblChannal] (
	[ChannalID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[ChannalName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblChanna__Delet__0DAF0CB0] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblCanal_PK] PRIMARY KEY  CLUSTERED 
	(
		[ChannalID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterUser_tblChannal_FK1] FOREIGN KEY 
	(
		[WaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblFee]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblFee] (
	[FeeID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[FeeName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[BeginDT] [datetime] NULL ,
	[EndDT] [datetime] NULL ,
	[UnitPrice] [smallmoney] NULL ,
	[TotalPrice] [int] NULL CONSTRAINT [DF__tblFee__TotalPri__0425A276] DEFAULT (0),
	[WaterAmount] [int] NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblFee__Deleted__0519C6AF] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblFee_PK] PRIMARY KEY  CLUSTERED 
	(
		[FeeID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterUser_tblFee_FK1] FOREIGN KEY 
	(
		[WaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterUserPlan]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterUserPlan]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterUserPlan] (
	[WaterUserPlanID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[BeginDT] [datetime] NOT NULL ,
	[EndDT] [datetime] NOT NULL ,
	[Amount] [int] NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterU__Delet__7D78A4E7] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblWaterUserPlan_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterUserPlanID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterUser_tblWaterUserPlan_FK1] FOREIGN KEY 
	(
		[WaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblStation]    �ű�����: 2010-08-20 10:16:09 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblStation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblStation] (
	[StationID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannalID] [int] NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblStatio__Delet__1367E606] DEFAULT (0),
	[Name] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Remark] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[CommuniType] [int] NULL ,
	[CommuniTypeContent] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[CanalID] [bigint] NOT NULL CONSTRAINT [DF__tblStatio__Canal__145C0A3F] DEFAULT (0),
	[IrrID] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF__tblStatio__IrrID__15502E78] DEFAULT ('0'),
	CONSTRAINT [PK__tblStation__0D0FEE32] PRIMARY KEY  NONCLUSTERED 
	(
		[StationID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblChannal_tblStation_FK1] FOREIGN KEY 
	(
		[ChannalID]
	) REFERENCES [dbo].[tblChannal] (
		[ChannalID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblDevice]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDevice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDevice] (
	[DeviceID] [int] IDENTITY (1, 1) NOT NULL ,
	[StationID] [int] NULL ,
	[Name] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Address] [int] NULL ,
	[DeviceType] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblDevice__Delet__239E4DCF] DEFAULT (0),
	[Remark] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [PK__tblDevice__019E3B86] PRIMARY KEY  NONCLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblStation_tblDevice_FK1] FOREIGN KEY 
	(
		[StationID]
	) REFERENCES [dbo].[tblStation] (
		[StationID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblDeivceDitch]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeivceDitch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDeivceDitch] (
	[DeviceID] [int] NOT NULL ,
	[LowLimit] [int] NULL ,
	[HighLimit] [int] NULL ,
	CONSTRAINT [tblDeivceDitch_PK] PRIMARY KEY  CLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDeivceDitch_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblDeviceSluice]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDeviceSluice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDeviceSluice] (
	[DeviceID] [int] NOT NULL ,
	[HasBeforeWL] [bit] NULL CONSTRAINT [DF__tblDevice__HasBe__1FCDBCEB] DEFAULT (0),
	[HasBehindWL] [bit] NULL CONSTRAINT [DF__tblDevice__HasBe__20C1E124] DEFAULT (0),
	CONSTRAINT [tblDeviceSluice_PK] PRIMARY KEY  CLUSTERED 
	(
		[DeviceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDeviceSluice_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblDitchData]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblDitchData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblDitchData] (
	[DitchDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[WL1] [smallint] NULL ,
	[WL2] [smallint] NULL ,
	[InstantFlux] [int] NULL ,
	[UsedAmount] [int] NULL ,
	[Voltage] [int] NULL ,
	CONSTRAINT [tblWaterInfo_PK] PRIMARY KEY  NONCLUSTERED 
	(
		[DitchDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblDitchData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblIn]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblIn]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblIn] (
	[InID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[DeviceID] [int] NULL ,
	CONSTRAINT [tblIn_PK] PRIMARY KEY  CLUSTERED 
	(
		[InID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblIn_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	),
	CONSTRAINT [tblWaterUser_tblIn_FK1] FOREIGN KEY 
	(
		[WaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblMeasureSluiceData]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblMeasureSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblMeasureSluiceData] (
	[MeasureSluiceDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[BeforeWL] [int] NULL ,
	[BehindWL] [int] NULL ,
	[InstantFlux] [int] NULL ,
	[Height] [int] NULL ,
	[RemainedAmount] [int] NULL ,
	[UsedAmount] [int] NULL ,
	CONSTRAINT [PK_tblMeasureSlucieData] PRIMARY KEY  CLUSTERED 
	(
		[MeasureSluiceDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblMeasureSluiceData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblOut]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblOut]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblOut] (
	[OutID] [int] IDENTITY (1, 1) NOT NULL ,
	[WaterUserID] [int] NULL ,
	[DeviceID] [int] NULL ,
	CONSTRAINT [tblOut_PK] PRIMARY KEY  CLUSTERED 
	(
		[OutID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblOut_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	),
	CONSTRAINT [tblWaterUser_tblOut_FK1] FOREIGN KEY 
	(
		[WaterUserID]
	) REFERENCES [dbo].[tblWaterUser] (
		[WaterUserID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblRainFillData]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblRainFillData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblRainFillData] (
	[RainFillDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DT] [datetime] NULL ,
	[RainFill] [int] NULL ,
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[DeviceID] [int] NULL ,
	CONSTRAINT [PK_tblRainFillData] PRIMARY KEY  CLUSTERED 
	(
		[RainFillDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblRainFillData_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblSluiceData]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblSluiceData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblSluiceData] (
	[SluiceDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[Height] [smallint] NULL ,
	[BeforeWL] [smallint] NULL ,
	[BehindWL] [smallint] NULL ,
	CONSTRAINT [tblSluiceData_PK] PRIMARY KEY  CLUSTERED 
	(
		[SluiceDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblSluiceData_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterLevelData]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterLevelData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterLevelData] (
	[WaterLevelDataID] [int] IDENTITY (1, 1) NOT NULL ,
	[DeviceID] [int] NULL ,
	[DT] [datetime] NULL ,
	[BeforeWL] [int] NULL ,
	[BehindWL] [int] NULL ,
	CONSTRAINT [PK_tblWaterLevel] PRIMARY KEY  CLUSTERED 
	(
		[WaterLevelDataID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_tblWaterLevelData_tblDevice] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterSource]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterSource]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterSource] (
	[WaterSourceID] [int] NOT NULL ,
	[DeviceID] [int] NULL ,
	[WaterSourceName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterS__Delet__0AD2A005] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	CONSTRAINT [tblWaterSource_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterSourceID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblDevice_tblWaterSource_FK1] FOREIGN KEY 
	(
		[DeviceID]
	) REFERENCES [dbo].[tblDevice] (
		[DeviceID]
	)
) ON [PRIMARY]
END

GO


/****** ����: �� [dbo].[tblWaterSourcePlan]    �ű�����: 2010-08-20 10:16:10 ******/
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblWaterSourcePlan]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[tblWaterSourcePlan] (
	[WaterSourcePlanID] [int] IDENTITY (1, 1) NOT NULL ,
	[BeginDT] [datetime] NOT NULL ,
	[EndDT] [datetime] NOT NULL ,
	[Amount] [int] NOT NULL CONSTRAINT [DF__tblWaterS__Amoun__00551192] DEFAULT (0),
	[Remark] [nvarchar] (400) COLLATE Chinese_PRC_CI_AS NULL ,
	[Deleted] [bit] NULL CONSTRAINT [DF__tblWaterS__Delet__014935CB] DEFAULT (0),
	[WaterSourceID] [int] NULL ,
	CONSTRAINT [tblWaterSourcePlan_PK] PRIMARY KEY  CLUSTERED 
	(
		[WaterSourcePlanID]
	)  ON [PRIMARY] ,
	CONSTRAINT [tblWaterSource_tblWaterSourcePlan_FK1] FOREIGN KEY 
	(
		[WaterSourceID]
	) REFERENCES [dbo].[tblWaterSource] (
		[WaterSourceID]
	)
) ON [PRIMARY]
END

GO


SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vWaterUser    �ű�����: 2010-08-20 10:16:10 ******/
CREATE VIEW dbo.vWaterUser
AS
SELECT dbo.tblWaterUser.WaterUserID
FROM dbo.tb_User LEFT OUTER JOIN
      dbo.tblWaterUser ON 
      dbo.tb_User.WaterUserID = dbo.tblWaterUser.ParentWaterUserID

GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTDitchStation    �ű�����: 2010-08-20 10:16:10 ******/
CREATE VIEW dbo.vRTDitchStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'XD221')      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTRainFillStation    �ű�����: 2010-08-20 10:16:10 ******/
CREATE VIEW dbo.vRTRainFillStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'RF')      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTSluiceStation    �ű�����: 2010-08-20 10:16:10 ******/
CREATE VIEW dbo.vRTSluiceStation  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblStation.CanalID,         dbo.tblStation.IrrID  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0) AND         (dbo.tblDevice.DeviceType = 'XD100')      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.VIEW3    �ű�����: 2010-08-20 10:16:10 ******/
/*WHERE (dbo.tblStation.Deleted = 1) AND (dbo.tblDevice.Deleted = 1)  */  CREATE VIEW dbo.VIEW3  AS  SELECT dbo.tblStation.StationID, dbo.tblDitchData.DeviceID, dbo.tblDitchData.DitchDataID,         dbo.tblStation.Name AS StationName, dbo.tblDitchData.DT, dbo.tblDitchData.WL1,         dbo.tblDitchData.WL2, dbo.tblDitchData.InstantFlux, dbo.tblDitchData.UsedAmount,         dbo.tblDitchData.Voltage  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN        dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID  WHERE (dbo.tblStation.Deleted = 0) AND (dbo.tblDevice.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRainFillData    �ű�����: 2010-08-20 10:16:10 ******/
CREATE VIEW dbo.vRainFillData  AS  SELECT dbo.tblStation.StationID, dbo.tblRainFillData.DeviceID,         dbo.tblRainFillData.RainFillDataID, dbo.tblStation.Name, dbo.tblRainFillData.DT,         dbo.tblRainFillData.RainFill, dbo.tblRainFillData.Remark  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblRainFillData ON         dbo.tblDevice.DeviceID = dbo.tblRainFillData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTDitchData    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.vRTDitchData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblDitchData.DT,         dbo.tblDitchData.WL1 AS WaterLevel, dbo.tblDitchData.InstantFlux,         dbo.tblDitchData.UsedAmount, 0 AS LeftMoney  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTRainFillData    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.vRTRainFillData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblRainFillData.DT,         dbo.tblRainFillData.RainFill  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblRainFillData ON         dbo.tblDevice.DeviceID = dbo.tblRainFillData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vRTSluiceData    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.vRTSluiceData  AS  SELECT dbo.tblStation.StationID, dbo.tblStation.Name, dbo.tblSluiceData.Height,         dbo.tblSluiceData.BeforeWL AS WaterLevel1,         dbo.tblSluiceData.BehindWL AS WaterLevel2, dbo.tblSluiceData.DT  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblSluiceData ON dbo.tblDevice.DeviceID = dbo.tblSluiceData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vSluiceData    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.vSluiceData  AS  SELECT dbo.tblStation.StationID, dbo.tblDevice.DeviceID, dbo.tblSluiceData.SluiceDataID,         dbo.tblStation.Name AS StationName, dbo.tblSluiceData.DT, dbo.tblSluiceData.Height,         dbo.tblSluiceData.BeforeWL, dbo.tblSluiceData.BehindWL  FROM dbo.tblStation INNER JOIN        dbo.tblDevice ON dbo.tblStation.StationID = dbo.tblDevice.StationID INNER JOIN        dbo.tblSluiceData ON dbo.tblDevice.DeviceID = dbo.tblSluiceData.DeviceID      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.vWaterLevelData    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.vWaterLevelData  AS  SELECT dbo.tblWaterLevelData.WaterLevelDataID, dbo.tblStation.StationID,         dbo.tblWaterLevelData.DeviceID, dbo.tblWaterLevelData.DT,         dbo.tblWaterLevelData.BeforeWL, dbo.tblWaterLevelData.BehindWL,         dbo.tblDevice.DeviceType, dbo.tblStation.Name  FROM dbo.tblWaterLevelData INNER JOIN        dbo.tblDevice ON         dbo.tblWaterLevelData.DeviceID = dbo.tblDevice.DeviceID INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID        
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** ����: ��ͼ dbo.waterDatas    �ű�����: 2010-08-20 10:16:11 ******/
CREATE VIEW dbo.waterDatas  AS  SELECT dbo.tblStation.Name, dbo.tblDitchData.UsedAmount AS AllAmount,         dbo.tblDitchData.InstantFlux AS Amount, dbo.tblDitchData.WL1 AS waterLevel,         dbo.tblDitchData.DT AS [time]  FROM dbo.tblDevice INNER JOIN        dbo.tblStation ON dbo.tblDevice.StationID = dbo.tblStation.StationID INNER JOIN        dbo.tblDitchData ON dbo.tblDevice.DeviceID = dbo.tblDitchData.DeviceID  WHERE (dbo.tblDevice.Deleted = 0) AND (dbo.tblStation.Deleted = 0)      
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

