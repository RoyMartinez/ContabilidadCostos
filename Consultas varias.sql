Create Database CrudExample;
GO
Use CrudExample;
GO
Create Table Ejemplo
(
	Id Int Identity(1,1) Primary key,
	Nombre varchar(60),
	Edad Int,
	FechaCreacion DateTime
)
GO
Insert into Ejemplo
(Nombre,Edad,FechaCreacion)
Values
('Ejemplo1',30,'20260528');