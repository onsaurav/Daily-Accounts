USE [ONSAccounts]
GO

/****** Object:  Table [dbo].[GroupAccount]    Script Date: 03/03/2012 19:43:02 ******/
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('AS', 'Asset', 'Debit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('LI', 'Liabilities', 'Credit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('OE', 'Owners Equity', 'Credit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('RE', 'Revenue', 'Credit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('EX', 'Expenses', 'Debit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('SA', 'Sales', 'Credit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('SR', 'Sales Return', 'Debit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('PU', 'Purchase', 'Debit')
INSERT INTO GroupAccount (GroupId, Name, BalanceType) VALUES ('PR', 'Purchase Return', 'Credit')


/****** Object:  Table [dbo].[IDType]    Script Date: 04/15/2012 19:43:02 ******/
INSERT INTO IDType (IDTypeId, Name, Description) VALUES ('ACC', 'Accounts', 'Accounts')
INSERT INTO IDType (IDTypeId, Name, Description) VALUES ('UEE', 'UserEntryExit', 'UserEntryExit')
INSERT INTO IDType (IDTypeId, Name, Description) VALUES ('VOU', 'Voucher', 'Voucher')


/****** Object:  Table [dbo].[FeatureType]    Script Date: 04/15/2012 19:43:02 ******/
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('STR', 'String', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('INT', 'Integer', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('LNG', 'Long', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('DBL', 'Double', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('DEC', 'Decimal', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('BOL', 'Boolean', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('BIT', 'bit', '01/01/2012')
INSERT INTO FeatureType (FeatureTypeId, Name, DateOfEntry) VALUES ('CHR', 'Char', '01/01/2012')


/****** For First Time Log In (Start) ******/
INSERT [dbo].[Company] ([CompanyId], [Name], [Address], [Phone], [Fax], [Email], [URL], [OpeningDate], [DateOfEntry], [EntryBy]) VALUES (N'ONS', N'ONSoft', N'.', N'.', N'.', N'.', N'.', CAST(0x00009FCB00000000 AS DateTime), CAST(0x00009FCB00000000 AS DateTime), N'saurav')
INSERT [dbo].[Location] ([LocationId], [Name], [CompanyId], [EntryBy], [DateOfEntry]) VALUES (N'HO', N'Head Office', N'ONS', N'saurav', CAST(0x00009FCB00000000 AS DateTime))

INSERT [dbo].[UserDepartment] ([DepartmentId], [Name], [CompanyId], [DateOfEntry], [EntryBy]) VALUES (N'ADM', N'Administration', N'ONS', CAST(0x00009FCB00000000 AS DateTime), N'saurav')
INSERT [dbo].[UserLevel] ([LevelId], [Name], [CompanyId], [DateOfEntry], [EntryBy]) VALUES (N'ADM', N'Administrator', N'ONS', CAST(0x00009FCB00000000 AS DateTime), N'saurav')

INSERT [dbo].[Users] ([DepartmentId], [LevelId], [UserName], [FullName], [Password], [Active], [DateOfEntry], [FirstLogIn], [ActiveDays], [LastActivated], [CompanyId], [EntryBy]) VALUES (N'ADM', N'ADM', N'saurav', N'Saurav Biswas Kartik', N'BCD', 1, CAST(0x00009FCB00000000 AS DateTime), 0, 350, CAST(0x00009FCB00000000 AS DateTime), N'ONS', N'saurav')
INSERT [dbo].[UserLoginAssign] ([UserName], [CompanyId], [LocationId], [DateOfEntry], [EntryBy]) VALUES (N'saurav', N'ONS', N'HO', CAST(0x00009FCB00000000 AS DateTime), N'saurav')
/****** For First Time Log In (End) ******/

