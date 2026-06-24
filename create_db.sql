CREATE DATABASE HospitalManagementDB;
GO

USE HospitalManagementDB;
GO

CREATE TABLE Users (
    Username NVARCHAR(50) PRIMARY KEY,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(30) NOT NULL,          
    FullName NVARCHAR(100) NOT NULL
);

CREATE TABLE Doctors (
    Id NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Specialty NVARCHAR(100) NOT NULL,
    Department NVARCHAR(100) NOT NULL,
    Room NVARCHAR(50) NOT NULL,
    Contact NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL,
    Gender NVARCHAR(20) NULL
);

CREATE TABLE Patients (
    Id NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age NVARCHAR(10) NULL,
    Gender NVARCHAR(20) NOT NULL,
    Contact NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL,
    Birthday NVARCHAR(50) NULL
);

CREATE TABLE Sessions (
    Id NVARCHAR(50) PRIMARY KEY,
    DoctorId NVARCHAR(50) NOT NULL,
    SessionDate DATE NOT NULL,
    StartTime NVARCHAR(20) NOT NULL, -- e.g., "09:00 AM"
    EndTime NVARCHAR(20) NOT NULL,   -- e.g., "12:00 PM"
    Room NVARCHAR(50) NOT NULL,
    MaxPatients INT NOT NULL,
    CONSTRAINT FK_Sessions_Doctors FOREIGN KEY (DoctorId) REFERENCES Doctors(Id) ON DELETE CASCADE
);

CREATE TABLE Appointments (
    Id NVARCHAR(50) PRIMARY KEY,
    SessionId NVARCHAR(50) NOT NULL,
    PatientId NVARCHAR(50) NOT NULL,
    AppointmentNumber INT NOT NULL,
    BookingTime DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Appointments_Sessions FOREIGN KEY (SessionId) REFERENCES Sessions(Id) ON DELETE CASCADE,
    CONSTRAINT FK_Appointments_Patients FOREIGN KEY (PatientId) REFERENCES Patients(Id)
);

CREATE TABLE MedicalRecords (
    RecordID INT IDENTITY(1,1) PRIMARY KEY,
    PatientId NVARCHAR(50) NOT NULL,
    DoctorId NVARCHAR(50) NOT NULL,
    Diagnosis NVARCHAR(MAX) NOT NULL,
    Prescription NVARCHAR(MAX) NOT NULL,
    RecordDate DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    CONSTRAINT FK_MedicalRecords_Patients FOREIGN KEY (PatientId) REFERENCES Patients(Id),
    CONSTRAINT FK_MedicalRecords_Doctors FOREIGN KEY (DoctorId) REFERENCES Doctors(Id)
);
GO

INSERT INTO Users (Username, PasswordHash, Role, FullName) VALUES
('admin', '123', 'Admin', 'System Administrator'),
('doc01', 'doctor123', 'Doctor', 'Dr. Olivia Bennett');

INSERT INTO Doctors (Id, Name, Specialty, Department, Room, Contact, Email, Address, Gender) VALUES
('doc01', 'Dr. Olivia Bennett', 'Cardiologist', 'Cardiology Department', 'Room 401', '077-1111111', 'olivia@hms.lk', 'Colombo', 'Female'),
('2', 'Dr. Alexander Wright', 'Pediatrician', 'Pediatrics Clinic', 'Room 102', '077-2222222', 'alexander@hms.lk', 'Kandy', 'Male'),
('3', 'Dr. Sophia Martinez', 'Neurologist', 'Neurology Lab', 'Room 305', '077-3333333', 'sophia@hms.lk', 'Galle', 'Female'),
('4', 'Dr. Marcus Vance', 'Orthopedic Surgeon', 'Orthopedics Unit', 'Room 211', '077-4444444', 'marcus@hms.lk', 'Jaffna', 'Male');

INSERT INTO Patients (Id, Name, Age, Gender, Contact, Email, Address, Birthday) VALUES
('P101', 'Emma Watson', '28', 'Female', '077-1234567', 'emma@gmail.com', 'No 24, Flower Road, Colombo', '1998-04-15'),
('P102', 'John Doe', '45', 'Male', '071-7654321', 'john@gmail.com', 'No 5, Temple Road, Kandy', '1881-08-10'),
('P103', 'Sarah Connor', '35', 'Female', '075-9876543', 'sarah@gmail.com', 'No 12, Main Street, Galle', '1991-03-22');

INSERT INTO Sessions (Id, DoctorId, SessionDate, StartTime, EndTime, Room, MaxPatients) VALUES
('S101', 'doc01', CAST(GETDATE() AS DATE), '09:00 AM', '12:00 PM', 'Room 401', 15),
('S102', 'doc01', CAST(DATEADD(day, 1, GETDATE()) AS DATE), '02:00 PM', '05:00 PM', 'Room 401', 12),
('S103', '2', CAST(GETDATE() AS DATE), '10:00 AM', '01:00 PM', 'Room 102', 20),
('S104', '3', CAST(DATEADD(day, 2, GETDATE()) AS DATE), '11:00 AM', '02:00 PM', 'Room 305', 10),
('S105', '4', CAST(DATEADD(day, 1, GETDATE()) AS DATE), '08:30 AM', '11:30 AM', 'Room 211', 8);
GO
