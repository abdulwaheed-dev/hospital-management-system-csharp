CREATE TABLE [DoctorInfo] (
	DID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Phone varchar(255) NOT NULL,
	Address varchar(255) NOT NULL,
	Qualification varchar(255) NOT NULL,
	Position varchar(255) NOT NULL,
  CONSTRAINT [PK_DOCTORINFO] PRIMARY KEY CLUSTERED
  (
  [DID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)
GO

CREATE TABLE [PatientInfo] (
	PID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Phone varchar(255) NOT NULL,
	Address varchar(255) NOT NULL,
	DiseaseName varchar(255) NOT NULL,
	RoomNo integer NOT NULL,
	RoomFloor integer NOT NULL,
  CONSTRAINT [PK_PATIENTINFO] PRIMARY KEY CLUSTERED
  (
  [PID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)
GO
CREATE TABLE [PatientCheckout] (
	PID integer NOT NULL,
	Name varchar(225) NOT NULL,
	Phone varchar(255) NOT NULL,
	Address varchar(255) NOT NULL,
	DiseaseName varchar(255) NOT NULL,
	RoomNo integer NOT NULL,
	RoomFloor integer NOT NULL,
	CheckoutBy varchar(255) NOT NULL,
	Checkout varchar(255) NOT NULL,
	DateCheckout date NOT NULL,
	BillCleared varchar(255) NOT NULL,
  CONSTRAINT [PK_PATIENTCHECKOUT] PRIMARY KEY CLUSTERED
  (
  [PID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)
GO
CREATE TABLE [login] (
	ID integer NOT NULL,
	FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
	Username varchar(255) NOT NULL UNIQUE,
	Password varchar(255) NOT NULL,
  CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)
GO


ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk0] FOREIGN KEY ([DID]) REFERENCES [DoctorInfo]([DID])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk0]
GO
ALTER TABLE [PatientInfo] WITH CHECK ADD CONSTRAINT [PatientInfo_fk1] FOREIGN KEY ([RoomNo]) REFERENCES [Room]([RoomNo])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientInfo] CHECK CONSTRAINT [PatientInfo_fk1]
GO

ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk0] FOREIGN KEY ([PID]) REFERENCES [PatientInfo]([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk0]
GO

ALTER TABLE [PatientCheckout] WITH CHECK ADD CONSTRAINT [PatientCheckout_fk2] FOREIGN KEY ([RoomNo]) REFERENCES [Room]([RoomNo])
ON UPDATE CASCADE
GO
ALTER TABLE [PatientCheckout] CHECK CONSTRAINT [PatientCheckout_fk2]
GO


