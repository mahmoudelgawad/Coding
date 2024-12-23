USE [DB_PlayGround]
GO
/****** Object:  Table [dbo].[ConstantKey]    Script Date: 10/25/2024 3:14:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstantKey](
	[Id] [uniqueidentifier] NOT NULL,
	[Key] [nvarchar](50) NULL,
	[Value] [nvarchar](500) NULL,
 CONSTRAINT [PK_ConstantKey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/25/2024 3:15:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](250) NULL,
	[Salary] [float] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Names]    Script Date: 10/25/2024 3:15:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Names](
	[ID] [int] NULL,
	[Name] [nvarchar](30) NULL,
	[Total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 10/25/2024 3:15:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](60) NULL,
	[LastName] [nvarchar](60) NULL,
	[Age] [tinyint] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentGrade]    Script Date: 10/25/2024 3:15:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentGrade](
	[ID] [uniqueidentifier] NOT NULL,
	[Student_ID] [uniqueidentifier] NOT NULL,
	[Subject_ID] [uniqueidentifier] NOT NULL,
	[Grade] [tinyint] NOT NULL,
 CONSTRAINT [PK_StudentGrade] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 10/25/2024 3:15:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](60) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'b65c232c-7532-4500-b059-078360c26e0f', N'Rehab', N'Abdelrahman', N'mahmoud', N'', 2500)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'fe74f18b-940f-4eb6-8a45-3b17600289f5', N'sami', N'ibrahem', N'mohamed', N'', 850)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'cc065f07-e055-4a68-a4ec-7a107f2d6228', N'jilan', N'mahmoud', N'ahmed', N'', 1500)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'554828b8-81cd-40b1-8555-9c19309bae20', N'Mahmoud', N'Ahmed', N'Abdelgawad', N'', 3500)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (1, N'dog', 6)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (1, N'dog', 6)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (2, N'cat', 10)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (3, N'horse', 11)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (4, N'bear', 16)
GO
INSERT [dbo].[Names] ([ID], [Name], [Total]) VALUES (4, N'bear', 16)
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Age]) VALUES (N'219820da-fb59-4077-8f78-2342f73837ee', N'Mahmoud', N'Ahmed', 13)
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Age]) VALUES (N'34a7885a-d73c-4001-8ffd-7de149971eb7', N'Rehab', N'AbdulRahman', 12)
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Age]) VALUES (N'2f26309e-b0b5-45b4-a47d-9bd96f4d5078', N'Jilan', N'Mahmoud', 11)
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Age]) VALUES (N'3e76a9b1-5efe-4f06-b4a9-f80a0f95709d', N'Aaisha', N'Mahmoud', 10)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'4cf72430-f706-44c3-b67c-1df6b4aad9f9', N'219820da-fb59-4077-8f78-2342f73837ee', N'0f721a1c-2576-4b86-bd82-578d25bb42cb', 60)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'2121cc52-f1eb-4954-a0cb-252abd056199', N'219820da-fb59-4077-8f78-2342f73837ee', N'cd2cd09b-c680-4007-9912-12c15252468d', 75)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'e44f1cc3-588f-4e18-a63f-2eafad8260b9', N'34a7885a-d73c-4001-8ffd-7de149971eb7', N'ef5300ec-6d5a-4684-a64c-bf5f716aa49e', 71)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'5dd4bc01-b0b0-4329-81b3-504fbcd320ed', N'34a7885a-d73c-4001-8ffd-7de149971eb7', N'cd2cd09b-c680-4007-9912-12c15252468d', 34)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'c2310d28-af24-45a2-b349-6ca4e92b17e4', N'3e76a9b1-5efe-4f06-b4a9-f80a0f95709d', N'0f721a1c-2576-4b86-bd82-578d25bb42cb', 69)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'5f16a7ca-6bf8-444f-9740-6d9832d94a89', N'2f26309e-b0b5-45b4-a47d-9bd96f4d5078', N'cd2cd09b-c680-4007-9912-12c15252468d', 80)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'1a01dc6a-8c05-49e7-9a9c-82d58e4f781b', N'2f26309e-b0b5-45b4-a47d-9bd96f4d5078', N'0f721a1c-2576-4b86-bd82-578d25bb42cb', 66)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'0bd1ad46-b4b5-42d5-a618-83db222f73a7', N'3e76a9b1-5efe-4f06-b4a9-f80a0f95709d', N'cd2cd09b-c680-4007-9912-12c15252468d', 90)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'c40ae339-43a2-46b6-aea9-9030c0207ba9', N'34a7885a-d73c-4001-8ffd-7de149971eb7', N'0f721a1c-2576-4b86-bd82-578d25bb42cb', 67)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'110f0cea-f5bb-4cc6-9bd7-918acd2bd4f6', N'3e76a9b1-5efe-4f06-b4a9-f80a0f95709d', N'c95527a1-7c5e-4e77-be0d-a1b9b4a42ac8', 52)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'3845c07f-314e-448f-a1f5-9509fcf48031', N'219820da-fb59-4077-8f78-2342f73837ee', N'c95527a1-7c5e-4e77-be0d-a1b9b4a42ac8', 55)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'150cb705-c780-4bf8-83bd-9a3feae47152', N'34a7885a-d73c-4001-8ffd-7de149971eb7', N'c95527a1-7c5e-4e77-be0d-a1b9b4a42ac8', 46)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'69bc3d49-a82c-434b-8056-ad93127354b8', N'219820da-fb59-4077-8f78-2342f73837ee', N'ef5300ec-6d5a-4684-a64c-bf5f716aa49e', 65)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'46f91785-cdee-43be-bcb5-d676231d8161', N'2f26309e-b0b5-45b4-a47d-9bd96f4d5078', N'c95527a1-7c5e-4e77-be0d-a1b9b4a42ac8', 45)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'769885ed-2e00-4a14-9a02-ec4db93485ca', N'2f26309e-b0b5-45b4-a47d-9bd96f4d5078', N'ef5300ec-6d5a-4684-a64c-bf5f716aa49e', 70)
GO
INSERT [dbo].[StudentGrade] ([ID], [Student_ID], [Subject_ID], [Grade]) VALUES (N'e432b32a-68cf-4820-859e-ffc43e321d64', N'3e76a9b1-5efe-4f06-b4a9-f80a0f95709d', N'ef5300ec-6d5a-4684-a64c-bf5f716aa49e', 72)
GO
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (N'cd2cd09b-c680-4007-9912-12c15252468d', N'Sience')
GO
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (N'0f721a1c-2576-4b86-bd82-578d25bb42cb', N'Math')
GO
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (N'c95527a1-7c5e-4e77-be0d-a1b9b4a42ac8', N'Arabic')
GO
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (N'ef5300ec-6d5a-4684-a64c-bf5f716aa49e', N'English')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_Key_ConstantKey]    Script Date: 10/25/2024 3:15:00 AM ******/
ALTER TABLE [dbo].[ConstantKey] ADD  CONSTRAINT [Unique_Key_ConstantKey] UNIQUE NONCLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
