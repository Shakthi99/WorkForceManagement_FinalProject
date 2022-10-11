CREATE TABLE SoftLock
(
	LockId int NOT NULL PRIMARY KEY,
	EmpId  int NULL,
	RequestedManager  varchar(50) NULL,
	RequestedDate  DATETIME,
	LockStatus  varchar(50) NOT NULL,	
	IsLocked Bit NULL,
	LastUpdatedDate DATETIME,
	RequestMessage   varchar(255) NOT NULL,
	WfmRemark  varchar(255) NOT NULL,
	ManagerStatus  varchar(50) NOT NULL,
	ManagerComment  varchar(255) NOT NULL,
	ManagerLastUpdatedDate  DATETIME
)

CREATE TABLE Employee (
    EmpId  int NOT NULL PRIMARY KEY,
	EmpName varchar(50) NOT NULL,
	Status varchar(50) NOT NULL,
	ManagerName varchar (30),
	wfm_MemberName varchar (30),
	Email varchar(250) NOT NULL ,
	LockStatus  varchar(50),
	Experience  decimal (5,0),
	Profile varchar(255),
	LockId int NOT NULL FOREIGN KEY REFERENCES SoftLock(LockId)
);

CREATE TABLE Skill(
	SkillId int NOT NULL PRIMARY KEY , 
	SkillName  varchar(30) NOT NULL
);


CREATE TABLE SkillMap(
	EmpId int FOREIGN KEY REFERENCES Employee(EmpId)  , 
	SkillId  int FOREIGN KEY REFERENCES Skill(SkillId)
);

CREATE TABLE [User](
	UserName varchar(50) NOT NULL PRIMARY KEY,
	[Password] varchar(50) NOT NULL,
	FirstName varchar(30) NOT NULL , 
	[Role]  varchar(30) NOT NULL,
	Email  varchar(50)
)

insert into users values ('Abi' , 'Abi@20', 'Abirami','Software Engineer','Abirami@gmail.com')
insert into users values ('Viki' , 'Viki@10', 'Vignesh','Trainee','Vignesh@gmail.com')
insert into users values ('Priya' , 'Priya@30', 'Priyadharshni','Test Engineer','priya@gmail.com')

insert into Skill values (1, 'java, sql server, C#')
insert into Skill values (2, 'Angular, react js, node js')
insert into Skill values (3, 'Python, javascript, jquery')

insert into SkillMap values (600, 1)
insert into SkillMap values (620, 2)
insert into SkillMap values (632, 3)

insert into softlock values (632, 'Sabitha','2022-09-05','Requested','2022-08-16',10,'Employee selected','','','',null)