CREATE TABLE [dbo].[tblSchedule]
(
	[ScheduleID] INT PRIMARY KEY,
	[SubjectID] INT NOT NULL,
	[RoomID] INT NOT NULL,
	[TeacherID] INT NOT NULL,
	[TimeStart] TIME NOT NULL,
	[TimeEnd] TIME NOT NULL,
	FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[tblSubjects],
	FOREIGN KEY ([RoomID]) REFERENCES [dbo].[tblRooms],
	FOREIGN KEY ([TeacherID]) REFERENCES [dbo].[tblTeachers]
);
