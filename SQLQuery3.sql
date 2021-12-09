CREATE TABLE [PatientInfo] (
	PID integer NOT NULL,
	RoomNo integer NOT NULL,
	BlockCode integer NOT NULL,
	BlockFloor integer NOT NULL,
	Name varchar(80) NOT NULL,
	Address varchar(255) NOT NULL,
	Phone varchar(255) NOT NULL,
	DiseaseName varchar(255) NOT NULL,
	TreatedBy varchar(255) NOT NULL,
  CONSTRAINT [PK_PATIENTINFO] PRIMARY KEY CLUSTERED
  (
  [PID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [DoctorInfo] (
	DID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Phone varchar(255) NOT NULL,
	Adress varchar(255) NOT NULL,
	Qualification varchar(255) NOT NULL,
	Position varchar(255) NOT NULL,
  CONSTRAINT [PK_DOCTORINFO] PRIMARY KEY CLUSTERED
  (
  [DID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [PatientCheckout] (
	PCID integer NOT NULL,
	CheckoutBy varchar(255) NOT NULL,
	BlockCode integer NOT NULL,
	BlockFloor integer NOT NULL,
	RoomNo integer NOT NULL,
	Checkout varchar(255) NOT NULL,
	DateOfCheckout date NOT NULL,
	BillCleared varchar(255) NOT NULL,
  CONSTRAINT [PK_PATIENTCHECKOUT] PRIMARY KEY CLUSTERED
  (
  [PCID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Room] (
	RoomNo integer NOT NULL,
	PID integer NOT NULL,
	RoomType varchar(255) NOT NULL,
	BlockFloor integer NOT NULL,
	BlockCode integer NOT NULL,
	Unavailable varchar(255) NOT NULL,
  CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED
  (
  [RoomNo] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Block] (
	BlockCode integer NOT NULL,
	BlockFloor integer NOT NULL,
  CONSTRAINT [PK_BLOCK] PRIMARY KEY CLUSTERED
  (
  [BlockCode] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk0] FOREIGN KEY ([RoomNo]) REFERENCES [Room]([RoomNo])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk0]
GO
ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk1] FOREIGN KEY ([BlockCode]) REFERENCES [Block]([BlockCode])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk1]
GO
ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk2] FOREIGN KEY ([BlockFloor]) REFERENCES [Block]([BlockFloor])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk2]
GO
ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk3] FOREIGN KEY ([TreatedBy]) REFERENCES [DoctorInfo]([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk3]
GO


ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk0] FOREIGN KEY ([PCID]) REFERENCES [PatientInfo]([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk0]
GO
ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk1] FOREIGN KEY ([CheckoutBy]) REFERENCES [DoctorInfo]([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk1]
GO
ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk2] FOREIGN KEY ([BlockCode]) REFERENCES [Block]([BlockCode])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk2]
GO
ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk3] FOREIGN KEY ([BlockFloor]) REFERENCES [Block]([BlockFloor])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk3]
GO
ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk4] FOREIGN KEY ([RoomNo]) REFERENCES [Room]([RoomNo])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk4]
GO

ALTER TABLE [Room] WITH CHECK ADD CONSTRAINT [Room_fk0] FOREIGN KEY ([PID]) REFERENCES [PatientInfo]([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [Room] CHECK CONSTRAINT [Room_fk0]
GO
ALTER TABLE [Room] WITH CHECK ADD CONSTRAINT [Room_fk1] FOREIGN KEY ([BlockFloor]) REFERENCES [Block]([BlockFloor])
ON UPDATE CASCADE
GO
ALTER TABLE [Room] CHECK CONSTRAINT [Room_fk1]
GO
ALTER TABLE [Room] WITH CHECK ADD CONSTRAINT [Room_fk2] FOREIGN KEY ([BlockCode]) REFERENCES [Block]([BlockCode])
ON UPDATE CASCADE
GO
ALTER TABLE [Room] CHECK CONSTRAINT [Room_fk2]
GO


