USE [master]
GO
/****** Object:  Database [CS6232-G2]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE DATABASE [CS6232-G2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CS6232-G2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CS6232-G2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CS6232-G2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CS6232-G2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CS6232-G2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-G2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-G2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232-G2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232-G2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232-G2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232-G2] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232-G2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232-G2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232-G2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232-G2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232-G2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232-G2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232-G2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232-G2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232-G2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232-G2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CS6232-G2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232-G2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232-G2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232-G2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232-G2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232-G2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232-G2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232-G2] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232-G2] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232-G2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232-G2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232-G2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232-G2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CS6232-G2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CS6232-G2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CS6232-G2] SET QUERY_STORE = OFF
GO
USE [CS6232-G2]
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[administratorId] [int] IDENTITY(1,1) NOT NULL,
	[personId] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[administratorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[appointmentId] [int] IDENTITY(1,1) NOT NULL,
	[doctorId] [int] NOT NULL,
	[patientId] [int] NOT NULL,
	[appointmentTime] [smalldatetime] NOT NULL,
	[reasonsForVisit] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[doctorId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialties]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialties](
	[doctorId] [int] NOT NULL,
	[name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[doctorId] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTest]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTest](
	[testCode] [int] NOT NULL,
	[patientVisitID] [int] NOT NULL,
	[testDateTime] [smalldatetime] NOT NULL,
	[result] [varchar](45) NOT NULL,
	[normal] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[testCode] ASC,
	[patientVisitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[username] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurses]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurses](
	[nurseId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nurseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[patientId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientVisits]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientVisits](
	[patientVisitID] [int] IDENTITY(1,1) NOT NULL,
	[visitDateAndTime] [smalldatetime] NOT NULL,
	[appointmentTime] [smalldatetime] NOT NULL,
	[weight] [decimal](3, 2) NOT NULL,
	[bpSystolic] [int] NOT NULL,
	[bpDiastolic] [int] NOT NULL,
	[bodyTemperature] [decimal](3, 2) NOT NULL,
	[pulse] [varchar](5) NOT NULL,
	[symptoms] [varchar](150) NOT NULL,
	[initialDiagnosis] [varchar](45) NOT NULL,
	[finalDiagnosis] [varchar](45) NULL,
	[routine] [bit] NOT NULL,
	[nurseId] [int] NOT NULL,
	[appointmentId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientVisitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialties]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialties](
	[name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[testCode] [int] NOT NULL,
	[testName] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/31/2023 12:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](45) NULL,
	[firstName] [varchar](45) NULL,
	[dob] [date] NULL,
	[ssn] [char](9) NULL,
	[gender] [char](1) NULL,
	[streetNumber] [varchar](45) NULL,
	[city] [varchar](45) NULL,
	[state] [varchar](45) NULL,
	[country] [varchar](45) NULL,
	[phone] [char](13) NULL,
	[zipcode] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([administratorId], [personId], [username]) VALUES (1, 1, N'johnsmith')
SET IDENTITY_INSERT [dbo].[Administrators] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (1, 1, 1, CAST(N'2023-03-15T10:00:00' AS SmallDateTime), N'Annual physical')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (2, 2, 2, CAST(N'2023-03-14T11:30:00' AS SmallDateTime), N'Flu symptoms')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (3, 2, 3, CAST(N'2023-03-16T13:45:00' AS SmallDateTime), N'Back pain')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (4, 1, 4, CAST(N'2023-03-17T09:15:00' AS SmallDateTime), N'Headache')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (5, 2, 1, CAST(N'2023-03-27T18:15:00' AS SmallDateTime), N'New Patient, physical')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (6, 1, 1, CAST(N'2023-03-30T13:30:00' AS SmallDateTime), N'Blood pressure med')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (7, 1, 1, CAST(N'2023-03-30T13:45:00' AS SmallDateTime), N'duplicate tests')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (8, 1, 6, CAST(N'2023-03-31T13:45:00' AS SmallDateTime), N'First Appt')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (9, 1, 6, CAST(N'2023-03-31T14:00:00' AS SmallDateTime), N'2nd Appt')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (10, 2, 6, CAST(N'2023-03-31T13:45:00' AS SmallDateTime), N'1st Opinion')
INSERT [dbo].[Appointments] ([appointmentId], [doctorId], [patientId], [appointmentTime], [reasonsForVisit]) VALUES (11, 2, 6, CAST(N'2023-04-07T14:00:00' AS SmallDateTime), N'physical')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([doctorId], [userId]) VALUES (1, 2)
INSERT [dbo].[Doctors] ([doctorId], [userId]) VALUES (2, 3)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO
INSERT [dbo].[Logins] ([username], [password]) VALUES (N'hansmuller', N'mypassword')
INSERT [dbo].[Logins] ([username], [password]) VALUES (N'jaeeunpark', N'1234567890')
INSERT [dbo].[Logins] ([username], [password]) VALUES (N'johnsmith', N'password123')
GO
SET IDENTITY_INSERT [dbo].[Nurses] ON 

INSERT [dbo].[Nurses] ([nurseId], [userId], [username], [active]) VALUES (1, 9, N'hansmuller', 1)
INSERT [dbo].[Nurses] ([nurseId], [userId], [username], [active]) VALUES (2, 10, N'jaeeunpark', 1)
SET IDENTITY_INSERT [dbo].[Nurses] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (1, 4)
INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (2, 5)
INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (3, 6)
INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (4, 7)
INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (5, 8)
INSERT [dbo].[Patients] ([patientId], [userId]) VALUES (6, 11)
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (1, N'Smith', N'John', CAST(N'1979-05-12' AS Date), N'123456789', N'M', N'123 Main St', N'New York', N'NY', N'USA', N'212-555-1234 ', N'10001')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (2, N'Doe', N'Jane', CAST(N'1985-02-28' AS Date), N'987490321', N'F', N'456 Elm St', N'Los Angeles', N'CA', N'USA', N'323-555-5678 ', N'90001')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (3, N'Doe', N'Bob', CAST(N'1972-12-01' AS Date), N'345678912', N'M', N'789 Oak Ave', N'Chicago', N'IL', N'USA', N'312-555-9012 ', N'60601')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (4, N'Brown', N'Jenny', CAST(N'1990-08-24' AS Date), N'234568290', N'F', N'321 Pine St', N'San Francisco', N'CA', N'USA', N'415-555-3456 ', N'94102')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (5, N'Lee', N'Samantha', CAST(N'1992-07-15' AS Date), N'987654321', N'F', N'456 Maple St', N'Boston', N'MA', N'USA', N'617-555-1234 ', N'02101')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (6, N'Garcia', N'Carlos', CAST(N'1980-12-05' AS Date), N'234567890', N'M', N'789 Oak St', N'Miami', N'FL', N'USA', N'305-555-5678 ', N'33101')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (7, N'Kim', N'Ji-hyun', CAST(N'1996-03-28' AS Date), N'456789012', N'F', N'123 Cherry Ave', N'Seoul', NULL, N'South Korea', N'822-555-9012 ', N'10101')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (8, N'Nguyen', N'Hieu', CAST(N'1987-11-20' AS Date), N'123123123', N'M', N'321 Cedar Blvd', N'Ho Chi Minh City', NULL, N'Vietnam', N'844-555-3456 ', N'70000')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (9, N'Muller', N'Hans', CAST(N'1975-05-01' AS Date), N'567890123', N'M', N'789 Linden Str', N'Berlin', NULL, N'Germany', N'430-555-6789 ', N'10115')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (10, N'Park', N'Jae-eun', CAST(N'1983-09-12' AS Date), N'987683521', N'F', N'456 Oak Ave', N'Seoul', NULL, N'South Korea', N'822-555-5678 ', N'06543')
INSERT [dbo].[Users] ([userId], [lastName], [firstName], [dob], [ssn], [gender], [streetNumber], [city], [state], [country], [phone], [zipcode]) VALUES (11, N'Mike', N'Thomas', CAST(N'2023-03-01' AS Date), N'123132121', N'M', N'123 Main St', N'River', N'CA', N'USA', N'1a2a2a31a1a1a', N'12345')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [administratorId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Administrators] ADD  CONSTRAINT [administratorId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[administratorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [person_personId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Administrators] ADD  CONSTRAINT [person_personId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [appointmentId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_appointment_doctor1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_appointment_doctor1_idx] ON [dbo].[Appointments]
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_patient_appointment_information_patient1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_patient_appointment_information_patient1_idx] ON [dbo].[Appointments]
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [doctorId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Doctors] ADD  CONSTRAINT [doctorId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_doctorSpecialties_specialties1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_doctorSpecialties_specialties1_idx] ON [dbo].[DoctorSpecialties]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_labTest_patientVisit1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_labTest_patientVisit1_idx] ON [dbo].[LabTest]
(
	[patientVisitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_labTest_test1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_labTest_test1_idx] ON [dbo].[LabTest]
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [username_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Logins] ADD  CONSTRAINT [username_UNIQUE] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [nurseId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Nurses] ADD  CONSTRAINT [nurseId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[nurseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [patientID_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Patients] ADD  CONSTRAINT [patientID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [userId_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Patients] ADD  CONSTRAINT [userId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_patient_person_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_patient_person_idx] ON [dbo].[Patients]
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [patientVisitID_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[PatientVisits] ADD  CONSTRAINT [patientVisitID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[patientVisitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_patientvisit_appointment1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_patientvisit_appointment1_idx] ON [dbo].[PatientVisits]
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_patientVisit_nurse1_idx]    Script Date: 3/31/2023 12:06:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_patientVisit_nurse1_idx] ON [dbo].[PatientVisits]
(
	[nurseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [name_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Specialties] ADD  CONSTRAINT [name_UNIQUE] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [testCode_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [testCode_UNIQUE] UNIQUE NONCLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [ssn_UNIQUE]    Script Date: 3/31/2023 12:06:17 PM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [ssn_UNIQUE] UNIQUE NONCLUSTERED 
(
	[ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PatientVisits] ADD  DEFAULT (NULL) FOR [finalDiagnosis]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [lastName]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [firstName]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [dob]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [ssn]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [gender]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [streetNumber]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [city]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [state]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [country]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [phone]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (NULL) FOR [zipcode]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [fk_administrator_login1] FOREIGN KEY([username])
REFERENCES [dbo].[Logins] ([username])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [fk_administrator_login1]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [fk_administrator_person1] FOREIGN KEY([personId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [fk_administrator_person1]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [fk_appointment_doctor1] FOREIGN KEY([doctorId])
REFERENCES [dbo].[Doctors] ([doctorId])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [fk_appointment_doctor1]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [fk_patient_appointment_information_patient1] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patients] ([patientId])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [fk_patient_appointment_information_patient1]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [fk_doctor_user1] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [fk_doctor_user1]
GO
ALTER TABLE [dbo].[DoctorSpecialties]  WITH CHECK ADD  CONSTRAINT [fk_doctorSpecialties_doctor1] FOREIGN KEY([doctorId])
REFERENCES [dbo].[Doctors] ([doctorId])
GO
ALTER TABLE [dbo].[DoctorSpecialties] CHECK CONSTRAINT [fk_doctorSpecialties_doctor1]
GO
ALTER TABLE [dbo].[DoctorSpecialties]  WITH CHECK ADD  CONSTRAINT [fk_doctorSpecialties_specialties1] FOREIGN KEY([name])
REFERENCES [dbo].[Specialties] ([name])
GO
ALTER TABLE [dbo].[DoctorSpecialties] CHECK CONSTRAINT [fk_doctorSpecialties_specialties1]
GO
ALTER TABLE [dbo].[LabTest]  WITH CHECK ADD  CONSTRAINT [fk_labTest_patientVisit1] FOREIGN KEY([patientVisitID])
REFERENCES [dbo].[PatientVisits] ([patientVisitID])
GO
ALTER TABLE [dbo].[LabTest] CHECK CONSTRAINT [fk_labTest_patientVisit1]
GO
ALTER TABLE [dbo].[LabTest]  WITH CHECK ADD  CONSTRAINT [fk_labTest_test1] FOREIGN KEY([testCode])
REFERENCES [dbo].[Tests] ([testCode])
GO
ALTER TABLE [dbo].[LabTest] CHECK CONSTRAINT [fk_labTest_test1]
GO
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [fk_nurse_login1] FOREIGN KEY([username])
REFERENCES [dbo].[Logins] ([username])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [fk_nurse_login1]
GO
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [fk_nurse_user1] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [fk_nurse_user1]
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [fk_patient_person] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [fk_patient_person]
GO
ALTER TABLE [dbo].[PatientVisits]  WITH CHECK ADD  CONSTRAINT [fk_patientvisit_appointment1] FOREIGN KEY([appointmentId])
REFERENCES [dbo].[Appointments] ([appointmentId])
GO
ALTER TABLE [dbo].[PatientVisits] CHECK CONSTRAINT [fk_patientvisit_appointment1]
GO
ALTER TABLE [dbo].[PatientVisits]  WITH CHECK ADD  CONSTRAINT [fk_patientVisit_nurse1] FOREIGN KEY([nurseId])
REFERENCES [dbo].[Nurses] ([nurseId])
GO
ALTER TABLE [dbo].[PatientVisits] CHECK CONSTRAINT [fk_patientVisit_nurse1]
GO
USE [master]
GO
ALTER DATABASE [CS6232-G2] SET  READ_WRITE 
GO
