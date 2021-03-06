USE [mohit]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_scl_getShift]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[udf_scl_getShift]
(
	-- Add the parameters for the function here
	@intime datetime
)
RETURNS varchar(20)
AS
BEGIN
	-- Declare the return variable here
	declare @tst time
	declare @tet time
	declare @tshift varchar(20)
	declare @tisn bit
	declare @sdt datetime
	declare @edt datetime
	set @sdt = convert(date,@intime)
	set @edt = convert(date,@intime)

	DECLARE @loopcr CURSOR
    SET @loopcr = CURSOR FORWARD_ONLY STATIC FOR select tShift,StartTime,EndTime,IsNight from ShiftConfig; 
	OPEN @loopcr
	FETCH NEXT FROM @loopcr into @tshift,@tst,@tet,@tisn
       WHILE @@FETCH_STATUS = 0
       BEGIN

			
			set @sdt = DATEADD(hour,datepart(hour,@tst),@sdt);
			set @sdt = DATEADD(minute,datepart(minute,@tst),@sdt);
			set @sdt = DATEADD(second,datepart(second,@tst),@sdt);

			
			if(@tisn = 0)
				begin
					set @edt = DATEADD(hour,datepart(hour,@tet),@edt);
					set @edt = DATEADD(minute,datepart(minute,@tet),@edt);
					set @edt = DATEADD(second,datepart(second,@tet),@edt);
				end
			else
				begin
					set @edt = DATEADD(day,1,@edt);
					set @edt = DATEADD(hour,datepart(hour,@tet),@edt);
					set @edt = DATEADD(minute,datepart(minute,@tet),@edt);
					set @edt = DATEADD(second,datepart(second,@tet),@edt);
				end

			if(@intime between @sdt and @edt)
			begin			
				break;
			end
		
		FETCH NEXT FROM @loopcr into @tshift,@tst,@tet,@tisn	
	   end
	   close @loopcr;
	   deallocate @loopcr;

	   return @tshift

END
GO
/****** Object:  Table [dbo].[ccm1]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm1](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm1_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccm2]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm2](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm2_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccm3]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm3](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm3_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccm4]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm4](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm4_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccm5]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm5](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm5_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccm6]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccm6](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[SrNo] [int] NOT NULL,
	[LogDateTime] [datetime] NOT NULL,
	[PipeNumber] [varchar](15) NULL,
	[PipeDia] [varchar](10) NULL,
	[PipeClass] [varchar](10) NULL,
	[PipeLength] [float] NULL,
	[JointType] [varchar](10) NULL,
	[MouldNo] [varchar](10) NULL,
	[ActWt] [float] NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[MachineNo] [varchar](10) NULL,
	[PipeStatus] [varchar](50) NULL,
	[Material] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[OperatorCode] [varchar](10) NULL,
	[OperatorName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_ccm6_1] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC,
	[SrNo] ASC,
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmClass]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmClass](
	[ID] [int] NOT NULL,
	[Description] [varchar](10) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_MastClass] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmDefect]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmDefect](
	[ID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmDefect] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmErrLog]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmErrLog](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LogDateTime] [datetime] NULL,
	[LogTopic] [varchar](50) NULL,
	[LogDesc] [varchar](max) NULL,
 CONSTRAINT [PK_ErrLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmLastPara]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmLastPara](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineID] [varchar](10) NOT NULL,
	[LastSize] [varchar](10) NULL,
	[LastLength] [varchar](10) NULL,
	[LastClass] [varchar](10) NULL,
	[LastMinWt] [float] NULL,
	[LastMaxWt] [float] NULL,
	[LastNomWt] [float] NULL,
	[LastJoint] [varchar](50) NULL,
	[LastMould] [varchar](50) NULL,
	[LastMaterial] [varchar](50) NULL,
	[LastStandard] [varchar](50) NULL,	
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmLastPara] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmLength]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmLength](
	[ID] [int] NOT NULL,
	[Description] [float] NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmLength] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmMachineConfig]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmMachineConfig](
	[MachineName] [varchar](3) NOT NULL,
	[MachineIP] [varchar](15) NULL,
	[MachinePort] [int] NULL,
	[TableName] [varchar](20) NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmMachineConfig] PRIMARY KEY CLUSTERED 
(
	[MachineName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmMaterial]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmMaterial](
	[ID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_MastMaterial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmReportMaster]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmReportMaster](
	[ReportID] [int] NOT NULL,
	[ReportName] [varchar](50) NULL,
	[ReportType] [varchar](50) NULL,
	[ReportSQL] [varchar](max) NULL,
 CONSTRAINT [PK_ccmReportMaster] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmShiftWiseInfo]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmShiftWiseInfo](
	[tDate] [date] NOT NULL,
	[tShift] [varchar](2) NOT NULL,
	[InchargeName] [varchar](100) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmShiftWiseInfo] PRIMARY KEY CLUSTERED 
(
	[tDate] ASC,
	[tShift] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmSignalDetection]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmSignalDetection](
	[LogDateTime] [datetime] NOT NULL,
	[MachineIP] [varchar](50) NOT NULL,
	[SignalMsg] [varchar](200) NULL,
	[Processed] [bit] NOT NULL,
	[Saved] [bit] NOT NULL,
	[Remarks] [varchar](200) NULL,
	[Signal] [int] NOT NULL,
	[Weight] [float] NOT NULL,
 CONSTRAINT [PK_ccmSignalDetection] PRIMARY KEY CLUSTERED 
(
	[LogDateTime] ASC,
	[MachineIP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmSize]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmSize](
	[ID] [int] NOT NULL,
	[Description] [varchar](10) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_MastSize] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmStandard]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmStandard](
	[ID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_MastStandard] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ccmWeightMaster]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccmWeightMaster](
	[Size] [varchar](10) NOT NULL,
	[Class] [varchar](10) NOT NULL,
	[Len] [float] NOT NULL,
	[MinWt] [float] NULL,
	[MaxWt] [float] NULL,
	[NomWt] [float] NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_ccmWeightMaster] PRIMARY KEY CLUSTERED 
(
	[Size] ASC,
	[Class] ASC,
	[Len] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailConfig]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailConfig](
	[EmailAccount] [nvarchar](100) NOT NULL,
	[DisplayName] [varchar](100) NULL,
	[AccountUserID] [nvarchar](100) NOT NULL,
	[AccountPassword] [nvarchar](20) NOT NULL,
	[SmtpServer] [nvarchar](100) NOT NULL,
	[OutGoingPort] [int] NOT NULL,
	[IsDefault] [bit] NOT NULL,
	[isTLS] [bit] NOT NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_EmailConfig] PRIMARY KEY CLUSTERED 
(
	[EmailAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailRecipients]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailRecipients](
	[ID] [int] NOT NULL,
	[PersonName] [varchar](100) NULL,
	[EmailID] [varchar](100) NULL,
	[EmailType] [varchar](50) NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_EmailRecipients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailReports]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailReports](
	[ReportID] [int] NOT NULL,
	[ReportName] [varchar](200) NULL,
	[ReportSQL] [text] NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_EmailReports] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailSchedule]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailSchedule](
	[ID] [int] NOT NULL,
	[SchTime] [time](7) NOT NULL,
	[Subject] [varchar](100) NULL,
	[EmailReportID] [int] NULL,
	[DatePara] [varchar](20) NULL,
	[ShiftPara] [varchar](20) NULL,
	[MachinePara] [varchar](20) NULL,
	[LastExecutedOn] [datetime] NULL,
	[ExportPath] [text] NULL,
	[AddDt] [datetime] NULL,
	[UpdDt] [datetime] NULL,
 CONSTRAINT [PK_EmailSchedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailScheduleLog]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailScheduleLog](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ExecutionDt] [datetime] NULL,
	[ScheduleID] [int] NULL,
	[EmailStatus] [varchar](50) NULL,
	[Error] [text] NULL,
	[AddDt] [datetime] NULL,
 CONSTRAINT [PK_EmailScheduleLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShiftConfig]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShiftConfig](
	[tShift] [varchar](2) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[isNight] [bit] NOT NULL,
 CONSTRAINT [PK_ShiftConfig] PRIMARY KEY CLUSTERED 
(
	[tShift] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysInfo]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysInfo](
	[SysInfo] [varchar](500) NOT NULL,
	[adddt] [datetime] NULL,
	[active] [bit] NULL,
	[regkey] [varchar](500) NULL,
 CONSTRAINT [PK_SysInfo] PRIMARY KEY CLUSTERED 
(
	[SysInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysStatus]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysStatus](
	[BrodCastSts] [bit] NULL,
	[BrodCastUpdDt] [datetime] NULL,
	[DataWriterSts] [bit] NULL,
	[DataWriteUpdDt] [datetime] NULL,
	[AutoMailSts] [bit] NULL,
	[AutoMailUpdDt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeightVsSignal]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeightVsSignal](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineIP] [varchar](50) NULL,
	[WeightFromTime] [datetime] NULL,
	[WeightToTime] [datetime] NULL,
	[SignalCount] [int] NOT NULL,
	[WeightCount] [int] NOT NULL,
	[MinWeight] [float] NOT NULL,
	[MaxWeight] [float] NOT NULL,
	[AvgWeight] [float] NOT NULL,
 CONSTRAINT [PK_WeightVsSignal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_AllMachine_Data]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_AllMachine_Data]
AS
SELECT C.*,info.InchargeName
FROM CCM1 C left outer join ccmShiftWiseInfo info on c.tDate = info.tDate and c.tShift = info.tShift
UNION
SELECT  C.*,info.InchargeName
FROM  CCM2 C left outer join ccmShiftWiseInfo info on c.tDate = info.tDate and c.tShift = info.tShift
UNION
SELECT  C.*,info.InchargeName
FROM  CCM3 C left outer join ccmShiftWiseInfo info on c.tDate = info.tDate and c.tShift = info.tShift
UNION
SELECT  C.*,info.InchargeName
FROM  CCM4 C left outer join ccmShiftWiseInfo info on c.tDate = info.tDate and c.tShift = info.tShift
UNION
SELECT C.*,info.InchargeName
FROM   CCM5 C left outer join ccmShiftWiseInfo info on c.tDate = info.tDate and c.tShift = info.tShift

GO
/****** Object:  Index [NonClusteredIndex-20180802-182133]    Script Date: 4/21/2022 12:27:44 PM ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20180802-182133] ON [dbo].[ccmErrLog]
(
	[ID] DESC
)
INCLUDE([LogDateTime],[LogTopic]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex-20220223-172512]    Script Date: 4/21/2022 12:27:44 PM ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20220223-172512] ON [dbo].[ccmErrLog]
(
	[LogDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ccmSignalDetection] ADD  CONSTRAINT [DF_ccmSignalDetection_Processed]  DEFAULT ((0)) FOR [Processed]
GO
ALTER TABLE [dbo].[ccmSignalDetection] ADD  CONSTRAINT [DF_ccmSignalDetection_Saved]  DEFAULT ((0)) FOR [Saved]
GO
ALTER TABLE [dbo].[ccmSignalDetection] ADD  CONSTRAINT [DF_ccmSignalDetection_Signal]  DEFAULT ((0)) FOR [Signal]
GO
ALTER TABLE [dbo].[ccmSignalDetection] ADD  CONSTRAINT [DF_ccmSignalDetection_Weight]  DEFAULT ((0)) FOR [Weight]
GO
ALTER TABLE [dbo].[EmailConfig] ADD  CONSTRAINT [DF_EmailConfig_IsDefault]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[EmailConfig] ADD  CONSTRAINT [DF_EmailConfig_isTLS]  DEFAULT ((0)) FOR [isTLS]
GO
ALTER TABLE [dbo].[EmailSchedule] ADD  CONSTRAINT [DF_EmailSchedule_LastExecutedOn]  DEFAULT ('2000-01-01') FOR [LastExecutedOn]
GO
ALTER TABLE [dbo].[ShiftConfig] ADD  CONSTRAINT [DF_ShiftConfig_isNight]  DEFAULT ((0)) FOR [isNight]
GO
ALTER TABLE [dbo].[WeightVsSignal] ADD  CONSTRAINT [DF_WeightVsSignal_SignalCount]  DEFAULT ((0)) FOR [SignalCount]
GO
ALTER TABLE [dbo].[WeightVsSignal] ADD  CONSTRAINT [DF_WeightVsSignal_WeightCount]  DEFAULT ((0)) FOR [WeightCount]
GO
ALTER TABLE [dbo].[WeightVsSignal] ADD  CONSTRAINT [DF_Table_1_AvgWeight]  DEFAULT ((0)) FOR [MinWeight]
GO
ALTER TABLE [dbo].[WeightVsSignal] ADD  CONSTRAINT [DF_WeightVsSignal_MaxWeight]  DEFAULT ((0)) FOR [MaxWeight]
GO
ALTER TABLE [dbo].[WeightVsSignal] ADD  CONSTRAINT [DF_WeightVsSignal_AvgWeight]  DEFAULT ((0)) FOR [AvgWeight]
GO
/****** Object:  StoredProcedure [dbo].[sp_Process_WeightVsSignal]    Script Date: 4/21/2022 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Process_WeightVsSignal]
	-- Add the parameters for the stored procedure here
	@tMachineIP varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	if(RTRIM(@tMachineIP) = '')
		return 0;
	
	SET NOCOUNT ON;
	declare @MinRangWt float 
	set @MinRangWt = 5
	
	declare @tFromDt datetime
	declare @tToDt datetime
	declare @tMinWt float
	declare @tMaxWt float
	declare @tAvgWt float
	declare @tSignalCount int
	declare @tWeightCount int

	declare @tWeight float
	declare @tSignal float
	declare @Outer_loop int


	set @tWeight = 0
	set @tSignal = 0
	set @tSignalCount = 0
	set @tWeightCount = 0


	select top 1 @tFromDt = WeightToTime from WeightVsSignal where MachineIP = @tMachineIP and weightToTime is not null  order by id desc
	if(@tFromDt = null)
		set @tFromDt = dateadd(minute,-2,Getdate());


	DECLARE @lb_Exit  bit
	SET @lb_Exit  = 0
	declare @tcount int
	set @tcount = 0

	declare @tMinTime datetime
	select top 1 @tMinTime = LogDateTime from ccmSignalDetection where Machineip = @tMachineIP and LogDateTime >= @tFromDt and [Weight] > @MinRangWt Order by LogDateTime Asc

	if(@tMinTime = null)
		return;

	Declare @Maincur Cursor
	Set @Maincur =cursor LOCAL for Select LogDateTime,Signal,[Weight] from ccmSignalDetection where Machineip = @tMachineIP and LogDateTime > @tMinTime  Order by LogDateTime Asc
	open @Maincur fetch next from @Maincur into  @tToDt,@tSignal,@tWeight
	SET @Outer_loop = @@FETCH_STATUS
	WHILE (@Outer_loop = 0) AND (@lb_Exit = 0) 
	begin
		if(@tWeight < @MinRangWt )
			set @lb_Exit = 1
		
		--set @tcount = @tcount + 1
		--print @tcount

		if(@tSignal = 1)
			set @tSignalCount = @tSignalCount + 1
			 
		if(@tWeight >= 40)
			set @tWeightCount = @tWeightCount + 1
		
		fetch next from @Maincur into  @tToDt,@tSignal,@tWeight
		SET @Outer_loop = @@FETCH_STATUS			
	end
	close @Maincur
	deallocate @Maincur

	
	

	

	if(@tWeightCount > 0)
	begin
		declare @IdentityValue int
		declare @IdentityOutput table ( ID int )

		insert WeightVsSignal
		 ( MachineIP, WeightFromTime,WeightToTime,SignalCount)
		output inserted.ID into @IdentityOutput
		values
			 ( @tMachineIP,@tMinTime,@tToDt,@tSignalCount)

		select @IdentityValue = (select ID from @IdentityOutput)


		select @tMinWt = Min(Weight), @tMaxWt = Max(Weight) , @tAvgWt = AVG(Weight) ,@tWeightCount = count(*) from ccmSignalDetection
		where MachineIP = @tMachineIP and LogDateTime between @tFromDt and @tToDt and Weight >= 40

		update WeightVsSignal Set MinWeight = @tMinWt , MaxWeight = @tMaxWt , AvgWeight = @tAvgWt , WeightCount = @tWeightCount where ID = @IdentityValue;
	end


END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[10] 2[55] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AllMachine_Data'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AllMachine_Data'
GO
