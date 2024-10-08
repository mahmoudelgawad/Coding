USE [DB_PlayGround]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/1/2024 8:30:33 AM ******/
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
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'45d6db06-28eb-4295-a63c-030b6964d6f8', N'Mahmoud', N'Ahmed', N'Abdelgawad', N'', 3500)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'b65c232c-7532-4500-b059-078360c26e0f', N'Rehab', N'Abdelrahman', N'mahmoud', N'', 2500)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'fe74f18b-940f-4eb6-8a45-3b17600289f5', N'sami', N'ibrahem', N'mohamed', N'', 850)
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (N'cc065f07-e055-4a68-a4ec-7a107f2d6228', N'jilan', N'mahmoud', N'ahmed', N'', 1500)
GO


-- for dublicate records
/*
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (NEWID(), N'Mahmoud', N'Ahmed', N'Abdelgawad', N'', 3500)
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (NEWID(), N'Mahmoud', N'Ahmed', N'Abdelgawad', N'', 3500)
INSERT [dbo].[Employee] ([Id], [FirstName], [MiddleName], [LastName], [Address], [Salary]) VALUES (NEWID(), N'sami', N'ibrahem', N'mohamed', N'', 850)

*/