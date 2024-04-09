AFTER TABLE table_name
ADD CONSTRAINT constraint_name CHECK (column_name BETWEEN value1 AND value2)

CREATE TABLE Product (
	ID INT PRIMARY KEY IDENTITY(1, 2),
	ProductName VARCHAR(20) UNIQUE NOT NULL
)

CREATE TABLE table_name (
	ID INT PRIMARY KEY,
	foreign_key INT FOREIGN KEY REFERENCES another_table(foreign_column)
)

CREATE TABLE Student (
	ID INT PRIMARY KEY,
	StudentName VARCHAR(20)
)
CREATE TABLE Class (
	ID INT PRIMARY KEY,
	ClassName VARCHAR(20)
)
CREATE TABLE Enrollment (
	StudentID INT NOT NULL,
	ClassID INT NOT NULL,
	CONSTRAINT PK_Enrollment PRIMARY KEY (StudentID, ClassID),
	CONSTRAINT FK_Enrollment_Student FOREIGN KEY (StudentID) REFERENCES Student(ID),
	CONSTRAINT FK_Enrollment_Class FOREIGN KEY (ClassID) REFERENCES Class(ID)
)

BEGIN TRANSACTION [name_of_trans]
BEGIN TRY
	COMMIT TRANSACTION [name_of_trans]
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION [name_of_trans]
END CATCH

CREATE CLUSTERED INDEX Cluster_IX_Customer_ID ON Customer(ID)
CREATE INDEX NonCluster_IX_Customer_City ON Customer(City)