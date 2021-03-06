IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'cs6232-g5') 
BEGIN
DROP DATABASE [cs6232-g5]
END
GO

CREATE DATABASE [cs6232-g5]
GO
USE [cs6232-g5]
GO
/****** Object:  Table [dbo].[UserSecurity]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserSecurity](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_UserSecurity] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[UserSecurity] ([UserName], [Password]) VALUES (N'BrianThomas', N'c8dae1c50e092f3d877192fc555b1dcf')
INSERT [dbo].[UserSecurity] ([UserName], [Password]) VALUES (N'DavidAbreham', N'c8dae1c50e092f3d877192fc555b1dcf')
INSERT [dbo].[UserSecurity] ([UserName], [Password]) VALUES (N'JohnSmith', N'c8dae1c50e092f3d877192fc555b1dcf')
INSERT [dbo].[UserSecurity] ([UserName], [Password]) VALUES (N'MarySmith', N'c8dae1c50e092f3d877192fc555b1dcf')
INSERT [dbo].[UserSecurity] ([UserName], [Password]) VALUES (N'SamuelAraya', N'c8dae1c50e092f3d877192fc555b1dcf')
/****** Object:  Table [dbo].[Tests]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tests](
	[TestID] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [varchar](100) NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tests] ON
INSERT [dbo].[Tests] ([TestID], [TestName], [Inactive]) VALUES (1, N'HIV ', 0)
INSERT [dbo].[Tests] ([TestID], [TestName], [Inactive]) VALUES (2, N'Hepatitis A', 0)
INSERT [dbo].[Tests] ([TestID], [TestName], [Inactive]) VALUES (3, N'Hepatitis B', 0)
SET IDENTITY_INSERT [dbo].[Tests] OFF
/****** Object:  Table [dbo].[Patients]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[SSN] [char](9) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MInit] [char](1) NULL,
	[LastName] [varchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[StreetAddress1] [varchar](95) NOT NULL,
	[StreetAddress2] [varchar](40) NULL,
	[Phone] [varchar](10) NOT NULL,
	[City] [varchar](35) NOT NULL,
	[State] [varchar](10) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON
INSERT [dbo].[Patients] ([PatientID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [Phone], [City], [State], [ZipCode]) VALUES (1, N'256699897', N'Howell', N'H', N'Walton', CAST(0xF3F40A00 AS Date), N'M', N'3508 Proin St.', NULL, N'5553086036', N'Weston', N'VA', N'02431455')
INSERT [dbo].[Patients] ([PatientID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [Phone], [City], [State], [ZipCode]) VALUES (2, N'112255649', N'Kendal', NULL, N'Brian', CAST(0x38FC0A00 AS Date), N'M', N'Ap #680-8604 Vestibulum Ave', NULL, N'5566335588', N'Alexandria', N'VA', N'55889989')
INSERT [dbo].[Patients] ([PatientID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [Phone], [City], [State], [ZipCode]) VALUES (3, N'225599888', N'Ashley', NULL, N'Koby', CAST(0x950F0B00 AS Date), N'F', N'8064 Eu Rd.', NULL, N'7779989899', N'Arlington', N'VA', N'31113366')
SET IDENTITY_INSERT [dbo].[Patients] OFF
/****** Object:  Table [dbo].[Employees]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[SSN] [char](9) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MInit] [char](1) NULL,
	[LastName] [varchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Gender] [char](1) NOT NULL,
	[StreetAddress1] [varchar](100) NOT NULL,
	[StreetAddress2] [varchar](100) NULL,
	[City] [varchar](35) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[State] [varchar](10) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[Inactive] [bit] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (1, N'123456789', N'Samuel', N's', N'Araya', CAST(0x7E070B00 AS Date), N'M', N'123 Main st', NULL, N'Silver Spring', N'2555523523', N'MD', N'20111', 0)
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (2, N'231645987', N'John', NULL, N'Smith', CAST(0x1A0F0B00 AS Date), N'M', N'lockwood DR', NULL, N'Silver Spring', N'244336566', N'MD', N'229911', 0)
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (3, N'321645897', N'Mary', NULL, N'Smith', CAST(0x350B0B00 AS Date), N'F', N'522 North st', NULL, N'Columbia', N'5552221119', N'MD', N'2779956', 0)
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (4, N'612546997', N'Brain', NULL, N'Thomas', CAST(0x21050B00 AS Date), N'M', N'442 Carol Ave', NULL, N'Bethesda', N'552264899', N'MD', N'265698', 0)
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (5, N'166889233', N'Jane', N'M', N'Carney', CAST(0x0F070B00 AS Date), N'F', N'233 Lark st', NULL, N'New Carlton', N'222558977', N'MD', N'2777888', 0)
INSERT [dbo].[Employees] ([EmployeeID], [SSN], [FirstName], [MInit], [LastName], [DOB], [Gender], [StreetAddress1], [StreetAddress2], [City], [Phone], [State], [ZipCode], [Inactive]) VALUES (6, N'111222333', N'David', NULL, N'Abreham', CAST(0xB1030B00 AS Date), N'M', N'526 luke st', NULL, N'new Carlton', N'111222696', N'MD', N'27778978', 0)
SET IDENTITY_INSERT [dbo].[Employees] OFF
/****** Object:  Table [dbo].[Doctors]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [int] NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Doctors] ([DoctorID]) VALUES (3)
INSERT [dbo].[Doctors] ([DoctorID]) VALUES (5)
/****** Object:  Table [dbo].[Administrators]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrators](
	[AdminID] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Administrators] ([AdminID], [UserName]) VALUES (4, N'BrianThomas')
INSERT [dbo].[Administrators] ([AdminID], [UserName]) VALUES (6, N'DavidAbreham')
/****** Object:  Table [dbo].[Nurses]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nurses](
	[NurseID] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Nurses] PRIMARY KEY CLUSTERED 
(
	[NurseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Nurses] ([NurseID], [UserName]) VALUES (1, N'SamuelAraya')
INSERT [dbo].[Nurses] ([NurseID], [UserName]) VALUES (2, N'JohnSmith')
/****** Object:  Table [dbo].[Visits]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Visits](
	[VisitID] [int] IDENTITY(1,1) NOT NULL,
	[VisitDate] [date] NOT NULL,
	[NurseID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[Diagnosis] [varchar](400) NULL,
	[Systolic] [int] NOT NULL,
	[Diastolic] [int] NOT NULL,
	[Temperature] [decimal](5, 2) NOT NULL,
	[RespirationRate] [int] NOT NULL,
	[HeartRate] [int] NOT NULL,
	[Symptoms] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[VisitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Visits] ON
INSERT [dbo].[Visits] ([VisitID], [VisitDate], [NurseID], [PatientID], [DoctorID], [Diagnosis], [Systolic], [Diastolic], [Temperature], [RespirationRate], [HeartRate], [Symptoms]) VALUES (1, CAST(0xEA390B00 AS Date), 2, 2, 5, N'Lucy is a 34-year old single mother who has recently been diagnosed with a cranial tumour in the right frontal lobe. The diagnosis explains her symptoms of persistent and worsening headache over the last four weeks,', 120, 80, CAST(95.00 AS Decimal(5, 2)), 10, 50, N'sdfsdfdf sfsdf sdf sdf ')
INSERT [dbo].[Visits] ([VisitID], [VisitDate], [NurseID], [PatientID], [DoctorID], [Diagnosis], [Systolic], [Diastolic], [Temperature], [RespirationRate], [HeartRate], [Symptoms]) VALUES (2, CAST(0x5A390B00 AS Date), 1, 3, 5, N'This is a dignosis column', 140, 70, CAST(98.00 AS Decimal(5, 2)), 6, 52, N'this is a symptom column')
SET IDENTITY_INSERT [dbo].[Visits] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 04/21/2015 00:07:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[DatePerformed] [date] NULL,
	[Result] [char](1) NULL,
	[TestID] [int] NOT NULL,
	[VisitID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[TestID] ASC,
	[VisitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DatePerformed], [Result], [TestID], [VisitID]) VALUES (1, CAST(0xEB390B00 AS Date), CAST(0xEB390B00 AS Date), N'-', 1, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DatePerformed], [Result], [TestID], [VisitID]) VALUES (2, CAST(0x5A390B00 AS Date), CAST(0x5B390B00 AS Date), N'+', 1, 2)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Default [DF__UserSecur__Passw__0EA330E9]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[UserSecurity] ADD  CONSTRAINT [DF__UserSecur__Passw__0EA330E9]  DEFAULT ('c8dae1c50e092f3d877192fc555b1dcf') FOR [Password]
GO
/****** Object:  Default [DF_Tests_Inactive]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [DF_Tests_Inactive]  DEFAULT ((0)) FOR [Inactive]
GO
/****** Object:  Default [DF__Employees__Inact__0F975522]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ('0') FOR [Inactive]
GO
/****** Object:  ForeignKey [FK_Doctors_Employees]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Employees] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Employees]
GO
/****** Object:  ForeignKey [FK_Administrators_Employees]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Administrators_Employees] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Administrators_Employees]
GO
/****** Object:  ForeignKey [FK_Administrators_UserSecurity1]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Administrators_UserSecurity1] FOREIGN KEY([UserName])
REFERENCES [dbo].[UserSecurity] ([UserName])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Administrators_UserSecurity1]
GO
/****** Object:  ForeignKey [FK_Nurses_Employees]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [FK_Nurses_Employees] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [FK_Nurses_Employees]
GO
/****** Object:  ForeignKey [FK_Nurses_UserSecurity]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [FK_Nurses_UserSecurity] FOREIGN KEY([UserName])
REFERENCES [dbo].[UserSecurity] ([UserName])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [FK_Nurses_UserSecurity]
GO
/****** Object:  ForeignKey [FK_Visits_Doctors]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Doctors]
GO
/****** Object:  ForeignKey [FK_Visits_Nurses]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Nurses] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurses] ([NurseID])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Nurses]
GO
/****** Object:  ForeignKey [FK_Visits_Patients]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Patients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([PatientID])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Patients]
GO
/****** Object:  ForeignKey [FK_Orders_Tests]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Tests] FOREIGN KEY([TestID])
REFERENCES [dbo].[Tests] ([TestID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Tests]
GO
/****** Object:  ForeignKey [FK_Orders_Visits]    Script Date: 04/21/2015 00:07:15 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Visits] FOREIGN KEY([VisitID])
REFERENCES [dbo].[Visits] ([VisitID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Visits]
GO
