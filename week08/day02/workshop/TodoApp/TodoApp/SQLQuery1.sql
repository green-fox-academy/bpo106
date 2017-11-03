SET IDENTITY_INSERT Todos ON;
INSERT INTO Todos (Id, IsDone, IsUrgent, Title) VALUES (1, 1, 0, 'First Task');
INSERT INTO Todos (Id, IsDone, IsUrgent, Title) VALUES (2, 0, 1, 'Second Task');
INSERT INTO Todos (Id, IsDone, IsUrgent, Title) VALUES (3, 0, 0, 'Third Task');
INSERT INTO Todos (Id, IsDone, IsUrgent, Title) VALUES (4, 0, 0, 'Fourth Task');
SET IDENTITY_INSERT Todos OFF;