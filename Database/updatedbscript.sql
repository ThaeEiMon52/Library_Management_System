USE [LibraryManagementSystemDB]
GO
/****** Object:  Table [dbo].[books]    Script Date: 5/7/2023 1:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[author] [varchar](50) NOT NULL,
	[publisher] [varchar](100) NOT NULL,
	[edition_number] [int] NOT NULL,
	[publication_date] [date] NOT NULL,
	[category_id] [int] NOT NULL,
	[num_of_books] [int] NOT NULL,
	[language] [varchar](50) NOT NULL,
	[price] [decimal](5, 2) NOT NULL,
	[call_number] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 5/7/2023 1:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_histories]    Script Date: 5/7/2023 1:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_histories](
	[rental_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[staff_issue_id] [int] NOT NULL,
	[issue_date] [date] NOT NULL,
	[due_date] [date] NOT NULL,
	[return_date] [date] NULL,
	[staff_receive_id] [int] NULL,
	[fine_amount] [decimal](6, 2) NULL,
	[status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffs]    Script Date: 5/7/2023 1:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffs](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[photo] [varbinary](max) NULL,
	[password] [varchar](100) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[gender] [char](1) NOT NULL,
	[role] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 5/7/2023 1:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[nrc] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[gender] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[books] ON 

INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (1, N'The Glass Palace', N'Amitav Ghosh', N'Random House India', 1, CAST(N'2000-09-01' AS Date), 1, 3, N'Burmese', CAST(10.50 AS Decimal(5, 2)), N'PR9499.3.G46 G58 2000')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (2, N'Smile As They Bow', N'Nu Nu Yi', N'Silkworm Books', 1, CAST(N'2008-01-01' AS Date), 1, 5, N'Burmese', CAST(15.75 AS Decimal(5, 2)), N'PL3856.N8 H5313 2008')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (3, N'The Lizard Cage', N'Karen Connelly', N'Doubleday Canada', 1, CAST(N'2005-01-01' AS Date), 1, 2, N'Burmese', CAST(12.99 AS Decimal(5, 2)), N'PR9199.4.C647 L59 2005')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (4, N'The River of Lost Footsteps: A Personal History of Burma', N'Thant Myint-U', N'Faber and Faber', 1, CAST(N'2006-10-05' AS Date), 2, 1, N'English', CAST(8.99 AS Decimal(5, 2)), N'DS527.7 .T43 2006')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (5, N'Burma: The Curse of Independence', N'Sheldon W. Simon', N'Zed Books', 1, CAST(N'2001-10-01' AS Date), 2, 4, N'English', CAST(21.99 AS Decimal(5, 2)), N'DS530.5 .S55 2001')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (6, N'From the Land of Green Ghosts: A Burmese Odyssey', N'Pascal Khoo Thwe', N'HarperCollins Publishers', 1, CAST(N'2002-05-13' AS Date), 3, 3, N'English', CAST(9.99 AS Decimal(5, 2)), N'DS530.8 .P38 2002')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (7, N'Letters from Burma', N'Aung San Suu Kyi', N'Penguin Books', 1, CAST(N'1998-01-01' AS Date), 3, 2, N'English', CAST(14.25 AS Decimal(5, 2)), N'DS530.8 .A95 1998')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (8, N'Finding George Orwell in Burma', N'Emma Larkin', N'Penguin Press', 1, CAST(N'2004-01-01' AS Date), 2, 1, N'English', CAST(11.50 AS Decimal(5, 2)), N'DS530.8 .L26 2004')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (9, N'Burmese Days', N'George Orwell', N'HarperCollins Publishers', 1, CAST(N'1934-01-01' AS Date), 1, 4, N'English', CAST(7.50 AS Decimal(5, 2)), N'PR6029.R8 B87 2009')
INSERT [dbo].[books] ([book_id], [title], [author], [publisher], [edition_number], [publication_date], [category_id], [num_of_books], [language], [price], [call_number]) VALUES (10, N'The Art of Hearing Heartbeats', N'Jan-Philipp Sendker', N'Other Press', 1, CAST(N'2012-01-31' AS Date), 4, 2, N'English', CAST(16.99 AS Decimal(5, 2)), N'PT2681.E524 A7813 2012')
SET IDENTITY_INSERT [dbo].[books] OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([category_id], [category_name]) VALUES (1, N'Buddhism')
INSERT [dbo].[categories] ([category_id], [category_name]) VALUES (2, N'History')
INSERT [dbo].[categories] ([category_id], [category_name]) VALUES (3, N'Novel')
INSERT [dbo].[categories] ([category_id], [category_name]) VALUES (4, N'Poetry')
INSERT [dbo].[categories] ([category_id], [category_name]) VALUES (5, N'Politics')
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[rental_histories] ON 

INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (19, 11, 1, 11, CAST(N'2023-05-06' AS Date), CAST(N'2023-05-13' AS Date), CAST(N'2023-05-13' AS Date), 11, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (20, 11, 1, 11, CAST(N'2023-05-15' AS Date), CAST(N'2023-05-22' AS Date), CAST(N'2023-05-22' AS Date), 12, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (22, 12, 2, 12, CAST(N'2023-05-18' AS Date), CAST(N'2023-05-25' AS Date), CAST(N'2023-05-25' AS Date), 12, CAST(400.00 AS Decimal(6, 2)), N'L')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (23, 13, 3, 13, CAST(N'2023-05-20' AS Date), CAST(N'2023-05-27' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (24, 13, 3, 13, CAST(N'2023-05-21' AS Date), CAST(N'2023-05-28' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (25, 14, 4, 14, CAST(N'2023-05-22' AS Date), CAST(N'2023-05-29' AS Date), CAST(N'2023-05-29' AS Date), 13, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (26, 14, 4, 14, CAST(N'2023-05-23' AS Date), CAST(N'2023-05-30' AS Date), CAST(N'2023-05-30' AS Date), 14, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (27, 15, 5, 15, CAST(N'2023-05-24' AS Date), CAST(N'2023-05-31' AS Date), CAST(N'2023-05-31' AS Date), 17, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (28, 15, 5, 16, CAST(N'2023-05-25' AS Date), CAST(N'2023-06-01' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (29, 16, 6, 19, CAST(N'2023-05-26' AS Date), CAST(N'2023-06-02' AS Date), CAST(N'2023-06-02' AS Date), 20, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (30, 16, 6, 18, CAST(N'2023-05-27' AS Date), CAST(N'2023-06-03' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (31, 17, 7, 11, CAST(N'2023-05-28' AS Date), CAST(N'2023-06-04' AS Date), CAST(N'2023-06-04' AS Date), 11, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (32, 17, 7, 15, CAST(N'2023-05-29' AS Date), CAST(N'2023-06-05' AS Date), CAST(N'2023-06-25' AS Date), 11, CAST(200.00 AS Decimal(6, 2)), N'L')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (33, 18, 8, 12, CAST(N'2023-05-30' AS Date), CAST(N'2023-06-06' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (34, 18, 8, 17, CAST(N'2023-05-31' AS Date), CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date), 17, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (35, 19, 9, 18, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-08' AS Date), CAST(N'2023-06-08' AS Date), 11, CAST(0.00 AS Decimal(6, 2)), N'R')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (36, 19, 9, 20, CAST(N'2023-06-02' AS Date), CAST(N'2023-06-09' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (70, 11, 3, 17, CAST(N'2023-05-07' AS Date), CAST(N'2023-05-14' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (71, 11, 3, 18, CAST(N'2023-05-07' AS Date), CAST(N'2023-05-14' AS Date), NULL, NULL, NULL, N'B')
INSERT [dbo].[rental_histories] ([rental_id], [user_id], [book_id], [staff_issue_id], [issue_date], [due_date], [return_date], [staff_receive_id], [fine_amount], [status]) VALUES (74, 12, 1, 11, CAST(N'2023-05-07' AS Date), CAST(N'2023-05-14' AS Date), NULL, NULL, NULL, N'B')
SET IDENTITY_INSERT [dbo].[rental_histories] OFF
GO
SET IDENTITY_INSERT [dbo].[staffs] ON 

INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (11, N'Khin Myat', NULL, N'mypassword1', N'09987654321', N'khinmyat@gmail.com', N'1234 First Lane, Yangon, Myanmar', N'F', 1)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (12, N'Aung Htet', NULL, N'mypassword2', N'09876543210', N'aunghtet@gmail.com', N'567 Second Street, Mandalay, Myanmar', N'M', 1)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (13, N'Thuzar Win', NULL, N'mypassword3', N'09765432109', N'thuzarwin@gmail.com', N'890 Third Avenue, Naypyidaw, Myanmar', N'F', 1)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (14, N'Htet Myat', NULL, N'mypassword4', N'09654321098', N'htetmyat@gmail.com', N'246 Fourth Road, Yangon, Myanmar', N'M', 0)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (15, N'Su Mon', NULL, N'mypassword5', N'09543210987', N'sumon@gmail.com', N'135 Fifth Place, Mandalay, Myanmar', N'F', 0)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (16, N'Min Thant', NULL, N'mypassword6', N'09432109876', N'minthant@gmail.com', N'579 Sixth Boulevard, Naypyidaw, Myanmar', N'M', 0)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (17, N'Thet Hnin', NULL, N'mypassword7', N'09321098765', N'thethnin@gmail.com', N'246 Seventh Avenue, Yangon, Myanmar', N'F', 1)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (18, N'Zaw Oo', NULL, N'mypassword8', N'09210987654', N'zawoo@gmail.com', N'789 Eighth Street, Mandalay, Myanmar', N'M', 1)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (19, N'May Thu', NULL, N'mypassword9', N'09109876543', N'maythu@gmail.com', N'345 Ninth Lane, Naypyidaw, Myanmar', N'F', 0)
INSERT [dbo].[staffs] ([staff_id], [name], [photo], [password], [phone], [email], [address], [gender], [role]) VALUES (20, N'Kyaw Min', NULL, N'mypassword10', N'09098765432', N'kyawmin@gmail.com', N'123 Tenth Road, Yangon, Myanmar', N'M', 0)
SET IDENTITY_INSERT [dbo].[staffs] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (11, N'Aung Myint', N'12/ABC(N)123456', N'+959876543210', N'aungmyint@gmail.com', N'123 Main Street, Yangon', N'M')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (12, N'Khin Hlaing', N'34/DEF(N)789012', N'+959765432109', N'khinhlaing@yahoo.com', N'456 High Street, Mandalay', N'F')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (13, N'Zaw Min', N'56/GHI(N)345678', N'+959654321078', N'zawmin@hotmail.com', N'789 Park Street, Nay Pyi Taw', N'M')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (14, N'Thet Su', N'78/JKL(N)901234', N'+959543210987', N'thetsu@gmail.com', N'101 Market Street, Yangon', N'F')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (15, N'Ko Ko', N'90/MNO(N)567890', N'+959432109876', N'koko@yahoo.com', N'111 Bazaar Street, Mandalay', N'M')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (16, N'Ma Ma', N'23/PQR(N)123456', N'+959321098765', N'mama@hotmail.com', N'222 Center Street, Nay Pyi Taw', N'F')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (17, N'Mya Win', N'45/STU(N)789012', N'+959210987654', N'myawin@gmail.com', N'333 North Street, Yangon', N'F')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (18, N'Tun Tun', N'67/VWX(N)345678', N'+959109876543', N'tuntun@yahoo.com', N'444 South Street, Mandalay', N'M')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (19, N'Su Su', N'89/YZA(N)901234', N'+959098765432', N'susu@hotmail.com', N'555 West Street, Nay Pyi Taw', N'F')
INSERT [dbo].[users] ([user_id], [name], [nrc], [phone], [email], [address], [gender]) VALUES (20, N'Htet Htet', N'01/BCE(N)567890', N'+959987654321', N'htethtet@gmail.com', N'666 East Street, Yangon', N'F')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[books] ADD  DEFAULT ((1)) FOR [edition_number]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT (getdate()) FOR [issue_date]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT (dateadd(day,(7),getdate())) FOR [due_date]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT (NULL) FOR [return_date]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT (NULL) FOR [staff_receive_id]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT (NULL) FOR [fine_amount]
GO
ALTER TABLE [dbo].[rental_histories] ADD  DEFAULT ('B') FOR [status]
GO
ALTER TABLE [dbo].[books]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([category_id])
GO
ALTER TABLE [dbo].[rental_histories]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[books] ([book_id])
GO
ALTER TABLE [dbo].[rental_histories]  WITH CHECK ADD FOREIGN KEY([staff_issue_id])
REFERENCES [dbo].[staffs] ([staff_id])
GO
ALTER TABLE [dbo].[rental_histories]  WITH CHECK ADD FOREIGN KEY([staff_receive_id])
REFERENCES [dbo].[staffs] ([staff_id])
GO
ALTER TABLE [dbo].[rental_histories]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
