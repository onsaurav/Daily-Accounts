USE [ONSAccounts]
GO
/****** Object:  Table [dbo].[UserDepartment]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDepartment](
	[DepartmentId] [varchar](3) NOT NULL,
	[Name] [varchar](50) NULL,
	[CompanyId] [varchar](3) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
 CONSTRAINT [PK_UserDepartment] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IDType]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IDType](
	[IDTypeId] [varchar](3) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_IDType] PRIMARY KEY CLUSTERED 
(
	[IDTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuSecurity]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuSecurity](
	[MenuId] [varchar](5) NOT NULL,
	[FormName] [varchar](100) NULL,
	[FormCaption] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Caption] [varchar](100) NULL,
 CONSTRAINT [PK_MenuSecurity] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Company]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [varchar](3) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[URL] [varchar](50) NULL,
	[OpeningDate] [datetime] NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlSecurity]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlSecurity](
	[ControlId] [varchar](5) NOT NULL,
	[ParentName] [varchar](100) NOT NULL,
	[Name] [varchar](100) NULL,
	[Caption] [varchar](100) NULL,
	[ControlType] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ControlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GroupAccount]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GroupAccount](
	[GroupId] [varchar](2) NOT NULL,
	[Name] [varchar](20) NULL,
	[BalanceType] [varchar](10) NULL,
 CONSTRAINT [PK_GroupAccount] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FeatureType]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FeatureType](
	[FeatureTypeId] [varchar](3) NOT NULL,
	[Name] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
 CONSTRAINT [PK_FeatureType] PRIMARY KEY CLUSTERED 
(
	[FeatureTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Feature]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Feature](
	[FeatureId] [varchar](3) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](100) NULL,
	[FeatureTypeId] [varchar](3) NULL,
	[DefaultValue] [varchar](100) NULL,
	[Value] [varchar](100) NULL,
	[CompanyId] [varchar](3) NULL,
	[DateOfEntry] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[FeatureId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlAccount]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlAccount](
	[ControlId] [varchar](4) NOT NULL,
	[Name] [varchar](50) NULL,
	[GroupId] [varchar](2) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NULL,
	[Remarks] [varchar](50) NULL,
 CONSTRAINT [PK_ControlAccounts] PRIMARY KEY CLUSTERED 
(
	[ControlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Location]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [varchar](2) NOT NULL,
	[Name] [varchar](50) NULL,
	[CompanyId] [varchar](3) NULL,
	[EntryBy] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SecurityQuestion]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SecurityQuestion](
	[SecurityQuestionId] [varchar](3) NOT NULL,
	[Name] [varchar](50) NULL,
	[CompanyId] [varchar](3) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](50) NULL,
 CONSTRAINT [PK_SecurityQuestion] PRIMARY KEY CLUSTERED 
(
	[SecurityQuestionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [varchar](3) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](250) NULL,
	[CompanyId] [varchar](3) NULL,
	[EntryBy] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hacker]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hacker](
	[HackerName] [varchar](50) NULL,
	[TerminalName] [varchar](50) NULL,
	[DateOfEntry] [datetime] NULL,
	[CompanyId] [varchar](3) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLevel]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserLevel](
	[LevelId] [varchar](3) NOT NULL,
	[Name] [varchar](50) NULL,
	[CompanyId] [varchar](3) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
 CONSTRAINT [PK_UserLevel] PRIMARY KEY CLUSTERED 
(
	[LevelId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserEntryExit]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserEntryExit](
	[UserEntryExitID] [varchar](25) NOT NULL,
	[Name] [varchar](10) NULL,
	[EntryTime] [varchar](11) NULL,
	[EntryDate] [datetime] NULL,
	[ExitDate] [datetime] NULL,
	[ExitTime] [varchar](11) NULL,
	[CompanyId] [varchar](3) NULL,
	[LocationId] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserEntryExitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IDNumber]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IDNumber](
	[SlNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[IDNo] [varchar](35) NULL,
	[IDTypeId] [varchar](3) NULL,
	[CompanyId] [varchar](3) NULL,
	[LocationId] [varchar](2) NULL,
	[EntryBy] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[IDYear] [numeric](18, 0) NULL,
 CONSTRAINT [PK_IDNumber] PRIMARY KEY CLUSTERED 
(
	[SlNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[DepartmentId] [varchar](3) NULL,
	[LevelId] [varchar](3) NULL,
	[UserName] [varchar](10) NOT NULL,
	[FullName] [varchar](50) NULL,
	[Password] [varchar](3) NULL,
	[Active] [bit] NULL,
	[DateOfEntry] [datetime] NULL,
	[FirstLogIn] [bit] NULL,
	[ActiveDays] [float] NULL,
	[LastActivated] [datetime] NULL,
	[CompanyId] [varchar](3) NULL,
	[EntryBy] [varchar](50) NULL,
 CONSTRAINT [PK_SecurityUser] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubsidiaryAccounts]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubsidiaryAccounts](
	[GroupId] [varchar](2) NOT NULL,
	[ControlId] [varchar](4) NOT NULL,
	[SubsidiaryId] [varchar](10) NOT NULL,
	[Name] [varchar](50) NULL,
	[DateOfEntry] [datetime] NULL,
	[CompanyId] [varchar](3) NULL,
	[EntryBy] [varchar](10) NULL,
 CONSTRAINT [PK_SubsidiaryAccounts] PRIMARY KEY CLUSTERED 
(
	[SubsidiaryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Voucher](
	[VoucherNo] [varchar](30) NOT NULL,
	[VoucherDate] [datetime] NULL,
	[Description] [varchar](500) NULL,
	[EntryBy] [varchar](10) NULL,
	[Posted] [varchar](1) NULL,
	[PostedBy] [varchar](10) NULL,
	[PostingDate] [datetime] NULL,
	[Type] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[CompanyId] [varchar](3) NULL,
	[LocationId] [varchar](2) NULL,
	[ProjectId] [varchar](3) NULL,
 CONSTRAINT [PK_Voucher] PRIMARY KEY CLUSTERED 
(
	[VoucherNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsersDetail]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsersDetail](
	[UserName] [varchar](10) NULL,
	[PreviousPassword] [varchar](10) NULL,
	[NewPassword] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SecurityQuestionAnswer]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SecurityQuestionAnswer](
	[UserName] [varchar](10) NULL,
	[SecurityQuestionId] [varchar](3) NULL,
	[Answer] [varchar](100) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLoginAssign]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserLoginAssign](
	[UserName] [varchar](10) NULL,
	[CompanyId] [varchar](3) NULL,
	[LocationId] [varchar](2) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuSecurityAssign]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuSecurityAssign](
	[MenuAssignId] [varchar](5) NOT NULL,
	[UserName] [varchar](10) NOT NULL,
	[MenuId] [varchar](5) NOT NULL,
	[MenuStatus] [bit] NULL,
 CONSTRAINT [PK_MenuSecurityAssign] PRIMARY KEY CLUSTERED 
(
	[MenuAssignId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlSecurityAssign]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlSecurityAssign](
	[ControlAssignId] [varchar](5) NOT NULL,
	[UserName] [varchar](10) NOT NULL,
	[ControlId] [varchar](5) NOT NULL,
	[ControlStatus] [bit] NULL,
	[ControlType] [varchar](10) NULL,
 CONSTRAINT [PK_ControlSecurityAssign] PRIMARY KEY CLUSTERED 
(
	[ControlAssignId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[GroupId] [varchar](2) NULL,
	[ControlId] [varchar](4) NULL,
	[SubsidiaryId] [varchar](10) NULL,
	[AccountsId] [varchar](20) NOT NULL,
	[Name] [varchar](50) NULL,
	[OpeningDate] [datetime] NULL,
	[OpeningBalance] [float] NULL,
	[Type] [varchar](10) NULL,
	[CompanyId] [varchar](3) NOT NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
 CONSTRAINT [PK_Accounts_1] PRIMARY KEY CLUSTERED 
(
	[AccountsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[YearEndClosing]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YearEndClosing](
	[YearEndClosingID] [uniqueidentifier] NOT NULL,
	[AccountingYear] [float] NOT NULL,
	[AccountingMonth] [float] NOT NULL,
	[AccountingDate] [float] NOT NULL,
	[ProcessDate] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[Approved] [varchar](1) NULL,
	[ApprovedBy] [varchar](10) NULL,
	[ClosingStock] [float] NULL,
	[VoucherNo] [varchar](30) NULL,
	[CompanyId] [varchar](3) NULL,
	[DateOfEntry] [datetime] NULL,
	[LocationId] [varchar](2) NULL,
	[ProjectId] [varchar](3) NULL,
 CONSTRAINT [PK_YearEndClosing] PRIMARY KEY CLUSTERED 
(
	[AccountingYear] ASC,
	[AccountingMonth] ASC,
	[AccountingDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoucherDetail]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoucherDetail](
	[VoucherDetailID] [uniqueidentifier] NOT NULL,
	[VoucherNo] [varchar](30) NOT NULL,
	[Particulars] [varchar](100) NULL,
	[AccountsId] [varchar](20) NULL,
	[Debit] [float] NULL,
	[Credit] [float] NULL,
 CONSTRAINT [PK_VoucherDetail] PRIMARY KEY CLUSTERED 
(
	[VoucherDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DailyLedger]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DailyLedger](
	[DailyLedgerID] [uniqueidentifier] NOT NULL,
	[BalanceDate] [datetime] NOT NULL,
	[AccountsId] [varchar](20) NOT NULL,
	[Amount] [float] NULL,
	[Type] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NOT NULL,
	[ProjectID] [varchar](3) NULL,
 CONSTRAINT [PK_DailyLedger_1] PRIMARY KEY CLUSTERED 
(
	[BalanceDate] ASC,
	[AccountsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Budget]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Budget](
	[AccountsId] [varchar](20) NOT NULL,
	[MonthYear] [varchar](6) NOT NULL,
	[Amount] [float] NULL,
	[Remarks] [varchar](200) NULL,
	[EntryBy] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[Approve] [varchar](1) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NOT NULL,
	[ProjectID] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Budget_1] PRIMARY KEY CLUSTERED 
(
	[AccountsId] ASC,
	[MonthYear] ASC,
	[CompanyId] ASC,
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AllTransaction]    Script Date: 05/02/2012 15:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AllTransaction](
	[AllTransactionID] [uniqueidentifier] NOT NULL,
	[VoucherNo] [varchar](30) NULL,
	[PostDate] [datetime] NULL,
	[AccountsId] [varchar](20) NULL,
	[Amount] [float] NULL,
	[Type] [varchar](10) NULL,
	[DateOfEntry] [datetime] NULL,
	[EntryBy] [varchar](10) NULL,
	[CompanyId] [varchar](3) NULL,
	[LocationId] [varchar](2) NULL,
 CONSTRAINT [pk_AllTransactionID] PRIMARY KEY CLUSTERED 
(
	[AllTransactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Accounts_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Company]
GO
/****** Object:  ForeignKey [FK_Accounts_ControlAccounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_ControlAccounts] FOREIGN KEY([ControlId])
REFERENCES [dbo].[ControlAccount] ([ControlId])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_ControlAccounts]
GO
/****** Object:  ForeignKey [FK_Accounts_GroupAccount]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_GroupAccount] FOREIGN KEY([GroupId])
REFERENCES [dbo].[GroupAccount] ([GroupId])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_GroupAccount]
GO
/****** Object:  ForeignKey [FK_Accounts_SubsidiaryAccounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_SubsidiaryAccounts] FOREIGN KEY([SubsidiaryId])
REFERENCES [dbo].[SubsidiaryAccounts] ([SubsidiaryId])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_SubsidiaryAccounts]
GO
/****** Object:  ForeignKey [FK_AllTransaction_Accounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[AllTransaction]  WITH CHECK ADD  CONSTRAINT [FK_AllTransaction_Accounts] FOREIGN KEY([AccountsId])
REFERENCES [dbo].[Accounts] ([AccountsId])
GO
ALTER TABLE [dbo].[AllTransaction] CHECK CONSTRAINT [FK_AllTransaction_Accounts]
GO
/****** Object:  ForeignKey [FK_AllTransaction_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[AllTransaction]  WITH CHECK ADD  CONSTRAINT [FK_AllTransaction_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[AllTransaction] CHECK CONSTRAINT [FK_AllTransaction_Company]
GO
/****** Object:  ForeignKey [FK_AllTransaction_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[AllTransaction]  WITH CHECK ADD  CONSTRAINT [FK_AllTransaction_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[AllTransaction] CHECK CONSTRAINT [FK_AllTransaction_Location]
GO
/****** Object:  ForeignKey [FK_AllTransaction_Voucher]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[AllTransaction]  WITH CHECK ADD  CONSTRAINT [FK_AllTransaction_Voucher] FOREIGN KEY([VoucherNo])
REFERENCES [dbo].[Voucher] ([VoucherNo])
GO
ALTER TABLE [dbo].[AllTransaction] CHECK CONSTRAINT [FK_AllTransaction_Voucher]
GO
/****** Object:  ForeignKey [FK_Budget_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Company] FOREIGN KEY([AccountsId])
REFERENCES [dbo].[Accounts] ([AccountsId])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Company]
GO
/****** Object:  ForeignKey [FK_Budget_Company1]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Company1] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Company1]
GO
/****** Object:  ForeignKey [FK_ControlAccounts_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[ControlAccount]  WITH CHECK ADD  CONSTRAINT [FK_ControlAccounts_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[ControlAccount] CHECK CONSTRAINT [FK_ControlAccounts_Company]
GO
/****** Object:  ForeignKey [FK_ControlAccounts_ControlAccounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[ControlAccount]  WITH CHECK ADD  CONSTRAINT [FK_ControlAccounts_ControlAccounts] FOREIGN KEY([ControlId])
REFERENCES [dbo].[ControlAccount] ([ControlId])
GO
ALTER TABLE [dbo].[ControlAccount] CHECK CONSTRAINT [FK_ControlAccounts_ControlAccounts]
GO
/****** Object:  ForeignKey [FK_ControlAccounts_GroupAccount]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[ControlAccount]  WITH CHECK ADD  CONSTRAINT [FK_ControlAccounts_GroupAccount] FOREIGN KEY([GroupId])
REFERENCES [dbo].[GroupAccount] ([GroupId])
GO
ALTER TABLE [dbo].[ControlAccount] CHECK CONSTRAINT [FK_ControlAccounts_GroupAccount]
GO
/****** Object:  ForeignKey [FK_ControlSecurityAssign_ControlSecurity]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[ControlSecurityAssign]  WITH CHECK ADD  CONSTRAINT [FK_ControlSecurityAssign_ControlSecurity] FOREIGN KEY([ControlId])
REFERENCES [dbo].[ControlSecurity] ([ControlId])
GO
ALTER TABLE [dbo].[ControlSecurityAssign] CHECK CONSTRAINT [FK_ControlSecurityAssign_ControlSecurity]
GO
/****** Object:  ForeignKey [FK_ControlSecurityAssign_Users]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[ControlSecurityAssign]  WITH CHECK ADD  CONSTRAINT [FK_ControlSecurityAssign_Users] FOREIGN KEY([UserName])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[ControlSecurityAssign] CHECK CONSTRAINT [FK_ControlSecurityAssign_Users]
GO
/****** Object:  ForeignKey [FK_DailyLedger_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[DailyLedger]  WITH CHECK ADD  CONSTRAINT [FK_DailyLedger_Company] FOREIGN KEY([AccountsId])
REFERENCES [dbo].[Accounts] ([AccountsId])
GO
ALTER TABLE [dbo].[DailyLedger] CHECK CONSTRAINT [FK_DailyLedger_Company]
GO
/****** Object:  ForeignKey [FK_DailyLedger_Company1]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[DailyLedger]  WITH CHECK ADD  CONSTRAINT [FK_DailyLedger_Company1] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[DailyLedger] CHECK CONSTRAINT [FK_DailyLedger_Company1]
GO
/****** Object:  ForeignKey [FK_Feature_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Feature]  WITH CHECK ADD  CONSTRAINT [FK_Feature_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Feature] CHECK CONSTRAINT [FK_Feature_Company]
GO
/****** Object:  ForeignKey [FK_Feature_FeatureType]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Feature]  WITH CHECK ADD  CONSTRAINT [FK_Feature_FeatureType] FOREIGN KEY([FeatureTypeId])
REFERENCES [dbo].[FeatureType] ([FeatureTypeId])
GO
ALTER TABLE [dbo].[Feature] CHECK CONSTRAINT [FK_Feature_FeatureType]
GO
/****** Object:  ForeignKey [FK_Hacker_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Hacker]  WITH CHECK ADD  CONSTRAINT [FK_Hacker_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Hacker] CHECK CONSTRAINT [FK_Hacker_Company]
GO
/****** Object:  ForeignKey [FK_IDNumber_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[IDNumber]  WITH CHECK ADD  CONSTRAINT [FK_IDNumber_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[IDNumber] CHECK CONSTRAINT [FK_IDNumber_Company]
GO
/****** Object:  ForeignKey [FK_IDNumber_IDType]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[IDNumber]  WITH CHECK ADD  CONSTRAINT [FK_IDNumber_IDType] FOREIGN KEY([IDTypeId])
REFERENCES [dbo].[IDType] ([IDTypeId])
GO
ALTER TABLE [dbo].[IDNumber] CHECK CONSTRAINT [FK_IDNumber_IDType]
GO
/****** Object:  ForeignKey [FK_IDNumber_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[IDNumber]  WITH CHECK ADD  CONSTRAINT [FK_IDNumber_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[IDNumber] CHECK CONSTRAINT [FK_IDNumber_Location]
GO
/****** Object:  ForeignKey [FK_Location_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Location] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Location]
GO
/****** Object:  ForeignKey [FK_MenuSecurityAssign_MenuSecurity]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[MenuSecurityAssign]  WITH CHECK ADD  CONSTRAINT [FK_MenuSecurityAssign_MenuSecurity] FOREIGN KEY([MenuId])
REFERENCES [dbo].[MenuSecurity] ([MenuId])
GO
ALTER TABLE [dbo].[MenuSecurityAssign] CHECK CONSTRAINT [FK_MenuSecurityAssign_MenuSecurity]
GO
/****** Object:  ForeignKey [FK_MenuSecurityAssign_Users]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[MenuSecurityAssign]  WITH CHECK ADD  CONSTRAINT [FK_MenuSecurityAssign_Users] FOREIGN KEY([UserName])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[MenuSecurityAssign] CHECK CONSTRAINT [FK_MenuSecurityAssign_Users]
GO
/****** Object:  ForeignKey [FK_Project_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Company]
GO
/****** Object:  ForeignKey [FK_SecurityQuestion_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SecurityQuestion]  WITH CHECK ADD  CONSTRAINT [FK_SecurityQuestion_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[SecurityQuestion] CHECK CONSTRAINT [FK_SecurityQuestion_Company]
GO
/****** Object:  ForeignKey [FK_SecurityQuestionAnswer_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SecurityQuestionAnswer]  WITH CHECK ADD  CONSTRAINT [FK_SecurityQuestionAnswer_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[SecurityQuestionAnswer] CHECK CONSTRAINT [FK_SecurityQuestionAnswer_Company]
GO
/****** Object:  ForeignKey [FK_SecurityQuestionAnswer_SecurityQuestion]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SecurityQuestionAnswer]  WITH CHECK ADD  CONSTRAINT [FK_SecurityQuestionAnswer_SecurityQuestion] FOREIGN KEY([SecurityQuestionId])
REFERENCES [dbo].[SecurityQuestion] ([SecurityQuestionId])
GO
ALTER TABLE [dbo].[SecurityQuestionAnswer] CHECK CONSTRAINT [FK_SecurityQuestionAnswer_SecurityQuestion]
GO
/****** Object:  ForeignKey [FK_SecurityQuestionAnswer_Users]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SecurityQuestionAnswer]  WITH CHECK ADD  CONSTRAINT [FK_SecurityQuestionAnswer_Users] FOREIGN KEY([UserName])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[SecurityQuestionAnswer] CHECK CONSTRAINT [FK_SecurityQuestionAnswer_Users]
GO
/****** Object:  ForeignKey [FK_SubsidiaryAccounts_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SubsidiaryAccounts]  WITH CHECK ADD  CONSTRAINT [FK_SubsidiaryAccounts_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[SubsidiaryAccounts] CHECK CONSTRAINT [FK_SubsidiaryAccounts_Company]
GO
/****** Object:  ForeignKey [FK_SubsidiaryAccounts_ControlAccounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SubsidiaryAccounts]  WITH CHECK ADD  CONSTRAINT [FK_SubsidiaryAccounts_ControlAccounts] FOREIGN KEY([ControlId])
REFERENCES [dbo].[ControlAccount] ([ControlId])
GO
ALTER TABLE [dbo].[SubsidiaryAccounts] CHECK CONSTRAINT [FK_SubsidiaryAccounts_ControlAccounts]
GO
/****** Object:  ForeignKey [FK_SubsidiaryAccounts_GroupAccount]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[SubsidiaryAccounts]  WITH CHECK ADD  CONSTRAINT [FK_SubsidiaryAccounts_GroupAccount] FOREIGN KEY([GroupId])
REFERENCES [dbo].[GroupAccount] ([GroupId])
GO
ALTER TABLE [dbo].[SubsidiaryAccounts] CHECK CONSTRAINT [FK_SubsidiaryAccounts_GroupAccount]
GO
/****** Object:  ForeignKey [FK_UserEntryExit_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserEntryExit]  WITH CHECK ADD  CONSTRAINT [FK_UserEntryExit_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[UserEntryExit] CHECK CONSTRAINT [FK_UserEntryExit_Company]
GO
/****** Object:  ForeignKey [FK_UserEntryExit_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserEntryExit]  WITH CHECK ADD  CONSTRAINT [FK_UserEntryExit_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[UserEntryExit] CHECK CONSTRAINT [FK_UserEntryExit_Location]
GO
/****** Object:  ForeignKey [FK_UserLevel_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserLevel]  WITH CHECK ADD  CONSTRAINT [FK_UserLevel_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[UserLevel] CHECK CONSTRAINT [FK_UserLevel_Company]
GO
/****** Object:  ForeignKey [FK_UserLoginAssign_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserLoginAssign]  WITH CHECK ADD  CONSTRAINT [FK_UserLoginAssign_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[UserLoginAssign] CHECK CONSTRAINT [FK_UserLoginAssign_Company]
GO
/****** Object:  ForeignKey [FK_UserLoginAssign_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserLoginAssign]  WITH CHECK ADD  CONSTRAINT [FK_UserLoginAssign_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[UserLoginAssign] CHECK CONSTRAINT [FK_UserLoginAssign_Location]
GO
/****** Object:  ForeignKey [FK_UserLoginAssign_Users]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UserLoginAssign]  WITH CHECK ADD  CONSTRAINT [FK_UserLoginAssign_Users] FOREIGN KEY([UserName])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[UserLoginAssign] CHECK CONSTRAINT [FK_UserLoginAssign_Users]
GO
/****** Object:  ForeignKey [FK_SecurityUser_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_SecurityUser_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_SecurityUser_Company]
GO
/****** Object:  ForeignKey [FK_SecurityUser_UserDepartment]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_SecurityUser_UserDepartment] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_SecurityUser_UserDepartment]
GO
/****** Object:  ForeignKey [FK_SecurityUser_UserLevel]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_SecurityUser_UserLevel] FOREIGN KEY([LevelId])
REFERENCES [dbo].[UserLevel] ([LevelId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_SecurityUser_UserLevel]
GO
/****** Object:  ForeignKey [FK_Users_UserDepartment]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserDepartment] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[UserDepartment] ([DepartmentId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserDepartment]
GO
/****** Object:  ForeignKey [FK_UsersDetail_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UsersDetail]  WITH CHECK ADD  CONSTRAINT [FK_UsersDetail_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[UsersDetail] CHECK CONSTRAINT [FK_UsersDetail_Company]
GO
/****** Object:  ForeignKey [FK_UsersDetail_Users]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[UsersDetail]  WITH CHECK ADD  CONSTRAINT [FK_UsersDetail_Users] FOREIGN KEY([UserName])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[UsersDetail] CHECK CONSTRAINT [FK_UsersDetail_Users]
GO
/****** Object:  ForeignKey [FK_Voucher_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_Company]
GO
/****** Object:  ForeignKey [FK_Voucher_EntryBy]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_EntryBy] FOREIGN KEY([EntryBy])
REFERENCES [dbo].[Users] ([UserName])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_EntryBy]
GO
/****** Object:  ForeignKey [FK_Voucher_Location]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_Location]
GO
/****** Object:  ForeignKey [FK_Voucher_Project]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_Project]
GO
/****** Object:  ForeignKey [FK_VoucherDetail_Accounts]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[VoucherDetail]  WITH CHECK ADD  CONSTRAINT [FK_VoucherDetail_Accounts] FOREIGN KEY([AccountsId])
REFERENCES [dbo].[Accounts] ([AccountsId])
GO
ALTER TABLE [dbo].[VoucherDetail] CHECK CONSTRAINT [FK_VoucherDetail_Accounts]
GO
/****** Object:  ForeignKey [FK_VoucherDetail_Voucher]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[VoucherDetail]  WITH CHECK ADD  CONSTRAINT [FK_VoucherDetail_Voucher] FOREIGN KEY([VoucherNo])
REFERENCES [dbo].[Voucher] ([VoucherNo])
GO
ALTER TABLE [dbo].[VoucherDetail] CHECK CONSTRAINT [FK_VoucherDetail_Voucher]
GO
/****** Object:  ForeignKey [FK_YearEndClosing_Company]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[YearEndClosing]  WITH CHECK ADD  CONSTRAINT [FK_YearEndClosing_Company] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[YearEndClosing] CHECK CONSTRAINT [FK_YearEndClosing_Company]
GO
/****** Object:  ForeignKey [FK_YearEndClosing_Voucher]    Script Date: 05/02/2012 15:40:06 ******/
ALTER TABLE [dbo].[YearEndClosing]  WITH CHECK ADD  CONSTRAINT [FK_YearEndClosing_Voucher] FOREIGN KEY([VoucherNo])
REFERENCES [dbo].[Voucher] ([VoucherNo])
GO
ALTER TABLE [dbo].[YearEndClosing] CHECK CONSTRAINT [FK_YearEndClosing_Voucher]
GO
