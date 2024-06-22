create table Historial(
	id int identity(1,1),
	fechaHora datetime,
	expresion varchar(50),
	Constraint PK_Historial Primary Key(id)
)