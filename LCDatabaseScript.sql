USE [batch]
GO
/****** Object:  Table [dbo].[StudentLCData]    Script Date: 08-Aug-20 1:09:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StudentLCData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdmissionNo] [int] NULL,
	[FullName] [varchar](100) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[MotherTongue] [varchar](50) NULL,
	[Religion] [varchar](50) NOT NULL,
	[Caste] [varchar](50) NOT NULL,
	[SubCaste] [varchar](50) NULL,
	[BirthPlace] [varchar](50) NOT NULL,
	[DOBInDigits] [varchar](50) NULL,
	[DOBInWords] [varchar](150) NULL,
	[PrevSchlName] [varchar](150) NULL,
	[AdmittedInClass] [nvarchar](50) NULL,
	[AdmissionDate] [varchar](50) NULL,
	[Progress] [varchar](150) NULL,
	[ConductBehaviour] [varchar](150) NULL,
	[DateOfSchlLeaving] [varchar](50) NULL,
	[ClassFromLeft] [nvarchar](50) NULL,
	[ReasonForLeaving] [varchar](150) NULL,
	[CertificateRcvdDate] [varchar](50) NULL,
	[ReceivedByName] [varchar](50) NULL,
 CONSTRAINT [PK_StudentLCData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
