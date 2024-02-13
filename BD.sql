create database CarnetAsde

use CarnetAsde

create table Usuarios(
Usuarioid int primary key,
Password varchar(50),
Empleadoid varchar(10),
Nombre varchar(50),
Apellido varchar(50)
)

create table ListadoEmpleados(
Empleadoid varchar(10) primary key,
Tarjeta varchar(10),
Nombre varchar(200),
Cedula varchar(15),
Departamento varchar(200),
Puesto varchar(100),
Direccion varchar(200),
Fecha Datetime,
Usuarioid int foreign key references Usuarios(Usuarioid)
)

create table EmpleadosConCarnet(
Empleadoid varchar(10) foreign key references ListadoEmpleados(Empleadoid),
Carnet bit
)

go
create proc Tb_ListadoEmpleados
@direccion varchar(200)
as
begin
	select Empleadoid, Tarjeta, Nombre, Cedula, Puesto, Departamento, Direccion
	from ListadoEmpleados
	where Direccion = @direccion
end

go
alter proc Pr_Login
@user int,
@pass varchar(50)
as
begin
	SELECT * FROM Usuarios 
	WHERE UsuarioID=@user AND Password=@pass COLLATE SQL_Latin1_General_CP1_CS_AS
end

go
alter proc Tb_Departamentos
as
begin
	select Direccion
	from ListadoEmpleados
	group by Direccion
	order by Direccion
end

go
create proc Pr_NuevoEmpleado
@empleadoid varchar(10),
@tarjeta varchar(10),
@nombre varchar(200),
@cedula varchar(15),
@puesto varchar(100),
@direccion varchar(200),
@departamento varchar(200),
@userid int
as
begin
	insert into ListadoEmpleados(Empleadoid,Tarjeta,Nombre,Cedula,Puesto,Departamento,Direccion,Fecha,Usuarioid)
	values (@empleadoid,@tarjeta,@nombre,@cedula,@puesto,@departamento,@direccion,GETDATE(),@userid)
end


select * from ListadoEmpleados