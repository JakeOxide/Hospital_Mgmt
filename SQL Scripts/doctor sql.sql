GO
CREATE DATABASE CSharp4;

GO
USE CSharp4;

GO
CREATE TABLE Doctors (
  DRollNumber int IDENTITY(1, 1),
  DIdNumber int PRIMARY KEY NOT NULL,
  DFName varchar(100) NOT NULL,
  DLName varchar(100) NOT NULL,
  DGender varchar(6) NOT NULL,
  DBday date NOT NULL,
  DAge int,
  DAddress varchar(100) NOT NULL,
  DSpecialty varchar(100) NOT NULL,
  DSalary Money NOT NULL,
  DRating tinyint,
  DLeaveRecord tinyint
  );

  insert into Doctors values(1,'sami','eyasu','M','2002-05-16',20,'addis','OBGYN',55090,7,2)
  insert into Doctors values(2,'yoni','yakob','M','1998-08-23',20,'hawassa','urologist',27090,8,1)
  insert into Doctors values(3,'ela','josi','KING','1982-12-31',20,'dire','surgon',45090,2,9)
  insert into Doctors values(4,'jake','samson','F','1999-01-21',20,'bahirdar','pediatrist',55090,9,0)
  insert into Doctors values(5,'gedi','hanna','F','1990-03-17',20,'addis','internist',95090,6,4)


GO
CREATE TABLE Nurses (
  NRollNumber int IDENTITY(1, 1),
  NIdNumber int PRIMARY KEY NOT NULL,
  NFName varchar(100) NOT NULL,
  NLName varchar(100) NOT NULL,
  NGender varchar(6) NOT NULL,
  NBday date NOT NULL,
  NAge int,
  NAddress varchar(100) NOT NULL,
  NSpecialty varchar(100) NOT NULL,
  NSalary Money NOT NULL,
  NRating tinyint,
  NLeaveRecord tinyint
  );

GO
CREATE TABLE Admins (
  AdminRollNumber int IDENTITY(1, 1),
  AdminIdNumber int PRIMARY KEY NOT NULL,
  AdminFName varchar(100) NOT NULL,
  AdminLName varchar(100) NOT NULL,
  AdminGender varchar(6) NOT NULL,
  AdminBday date NOT NULL,
  AdminAge int,
  AdminAddress varchar(100) NOT NULL,
  AdminSalary Money NOT NULL,
  AdminRating tinyint,
  AdminLeaveRecord tinyint
  );

-- Doc SPs



-- Stored Procedures


--1 Calculate and insert entity age

GO
alter PROC [Calculate_Doc_Age]
@did int
AS
BEGIN
DECLARE @Age int;
  DECLARE @givenDate date = (SELECT DBday FROM Doctors WHERE DIdNumber = @did);
  IF(YEAR(@givenDate) < YEAR(GETDATE()))
  BEGIN
    IF(MONTH(@givenDate) >= MONTH(GETDATE()))
    BEGIN
      IF(DAY(@givenDate) >= DAY(GETDATE()))
      BEGIN
        SET @Age = (DATEDIFF(YEAR, @givenDate, GETDATE()) + 1)
        UPDATE Doctors 
        SET DAge = @Age
        WHERE DIdNumber = @did
      END
      ELSE
      BEGIN
        SET @Age = (DATEDIFF(YEAR, @givenDate, GETDATE()))
        UPDATE Doctors 
        SET DAge = @Age
        WHERE DIdNumber = @did
      END
    END
    ELSE
    BEGIN
      SET @Age = DATEDIFF(YEAR, @givenDate, GETDATE());
      UPDATE Doctors 
      SET DAge = @Age
      WHERE DIdNumber = @did
    END
  END
  print @age
END

execute [Calculate_Doc_Age]2
-- 2 Update Doctors Salary

GO
CREATE PROC [Update_Doctors_Salary]
@DIdNumber int, @Dir int, @Amount Money
AS
BEGIN
  IF(@Dir = 1)
  BEGIN
    UPDATE Doctors
    SET DSalary = (DSalary + @Amount)
    WHERE DIdNumber = @DIdNumber
  END
  ELSE IF(@Dir = 0)
  BEGIN
    UPDATE Doctors
    SET DSalary = (DSalary - @Amount)
    WHERE DIdNumber = @DIdNumber
  END
END



-- 3 Update Doctor Rating

GO
CREATE PROC [Update_Doctor_Rating]
@DIdNumber int, @Dir int, @Amount tinyint
AS
BEGIN
  IF(@Dir = 1)
  BEGIN
    UPDATE Doctors
    SET DRating = (DRating + @Amount)
    WHERE DIdNumber = @DIdNumber
  END
  ELSE IF(@Dir = 0)
  BEGIN
    UPDATE Doctors
    SET DRating = (DRating - @Amount)
    WHERE DIdNumber = @DIdNumber
  END
END



-- 4 Update Doctor LeaveRecord

GO
CREATE PROC [Update_Doctor_LeaveRecord]
@DIdNumber int, @Dir int, @Amount int
AS
BEGIN
  IF(@Dir = 1)
  BEGIN
    UPDATE Doctors
    SET DLeaveRecord = (DLeaveRecord + @Amount)
    WHERE DIdNumber = @DIdNumber
  END
  ELSE IF(@Dir = 0)
  BEGIN
    UPDATE Doctors
    SET DLeaveRecord = (DLeaveRecord - @Amount)
    WHERE DIdNumber = @DIdNumber
  END
END



-- 5 Check Name Format Proc

GO
CREATE PROC [PROC_Update_Name_Format] 
@DIdNumber int
AS
BEGIN
  DECLARE @GivenFName varchar(100), @GivenLName varchar(100)
  SET @GivenFName = (SELECT DFName FROM Doctors WHERE DIdNumber = @DIdNumber);
  SET @GivenLName = (SELECT DLName FROM Doctors WHERE DIdNumber = @DIdNumber);
  DECLARE @FNLen tinyint = (LEN(@GivenFName) - 1);
  DECLARE @LNLen tinyint = (LEN(@GivenLName) - 1);
  UPDATE Doctors
  SET DFName = CONCAT (UPPER(SUBSTRING(@GivenFName, 1, 1)), LOWER(SUBSTRING(@GivenFName, 2, @FNLen)))
  WHERE DIdNumber =@DIdNumber;
  UPDATE Doctors
  SET DLName = CONCAT (UPPER(SUBSTRING(@GivenLName, 1, 1)), LOWER(SUBSTRING(@GivenLName, 2, @LNLen)))
  WHERE DIdNumber = @DIdNumber;
END
