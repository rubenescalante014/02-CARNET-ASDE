USE [master]
GO
/****** Object:  Database [CarnetAsde]    Script Date: 2/13/2024 10:29:27 AM ******/
CREATE DATABASE [CarnetAsde]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarnetAsde', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CarnetAsde.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarnetAsde_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CarnetAsde_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarnetAsde] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarnetAsde].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarnetAsde] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarnetAsde] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarnetAsde] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarnetAsde] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarnetAsde] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarnetAsde] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CarnetAsde] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarnetAsde] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarnetAsde] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarnetAsde] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarnetAsde] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarnetAsde] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarnetAsde] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarnetAsde] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarnetAsde] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarnetAsde] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarnetAsde] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarnetAsde] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarnetAsde] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarnetAsde] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarnetAsde] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarnetAsde] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarnetAsde] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarnetAsde] SET  MULTI_USER 
GO
ALTER DATABASE [CarnetAsde] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarnetAsde] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarnetAsde] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarnetAsde] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarnetAsde] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarnetAsde] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarnetAsde] SET QUERY_STORE = OFF
GO
USE [CarnetAsde]
GO
/****** Object:  Table [dbo].[ListadoEmpleados]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListadoEmpleados](
	[Empleadoid] [varchar](10) NOT NULL,
	[Tarjeta] [varchar](10) NULL,
	[Nombre] [varchar](200) NULL,
	[Cedula] [varchar](15) NULL,
	[Departamento] [varchar](200) NULL,
	[Puesto] [varchar](100) NULL,
	[Direccion] [varchar](200) NULL,
	[Fecha] [datetime] NULL,
	[Usuarioid] [int] NULL,
	[Carnet] [bit] NULL,
	[Llave] [bit] NULL,
	[CodigoLlave] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Empleadoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Privilegios]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privilegios](
	[Privilegioid] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Privilegioid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuarioid] [int] NOT NULL,
	[Password] [varchar](50) NULL,
	[Empleadoid] [varchar](10) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Privilegio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuarioid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ListadoEmpleados]  WITH CHECK ADD FOREIGN KEY([Usuarioid])
REFERENCES [dbo].[Usuarios] ([Usuarioid])
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCarnet]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ActualizarCarnet]
@cedula varchar(15)
as
 update ListadoEmpleados set Carnet = 1
where Cedula = @cedula
GO
/****** Object:  StoredProcedure [dbo].[AsignarCodigoLlave]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AsignarCodigoLlave]
@cedula varchar(50),
@codigollave varchar(10)
as
begin
	update ListadoEmpleados
	set Llave = 1,
		CodigoLlave = @codigollave
	where Cedula = @cedula
end
GO
/****** Object:  StoredProcedure [dbo].[CambiarDepartamento]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CambiarDepartamento]
@cedula varchar(15),
@departamento varchar(200)
as
update ListadoEmpleados 
 set Departamento = @departamento
where Cedula = @cedula
GO
/****** Object:  StoredProcedure [dbo].[CambiarPuesto]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CambiarPuesto]
@cedula varchar(15),
@puesto varchar(100)
as
update ListadoEmpleados 
 set Puesto = @puesto
where Cedula = @cedula
GO
/****** Object:  StoredProcedure [dbo].[EmpleadosConLlave]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EmpleadosConLlave]
@direccion varchar(200)
as
begin
	select  Tarjeta, Nombre,Cedula, Llave, CodigoLlave
	from ListadoEmpleados
	where Direccion = @direccion and Llave = 'True'
end
GO
/****** Object:  StoredProcedure [dbo].[Pr_ActualizarEmpleado]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Pr_ActualizarEmpleado]
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
	update ListadoEmpleados
	set Tarjeta=@tarjeta, 
	Nombre=@nombre,
	Cedula=@cedula,
	Puesto=@puesto,
	Direccion=@direccion,
	Departamento=@departamento
	where Empleadoid=@empleadoid
end
GO
/****** Object:  StoredProcedure [dbo].[Pr_Login]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Pr_Login]
@user int,
@pass varchar(50)
as
begin
	SELECT * FROM Usuarios 
	WHERE UsuarioID=@user AND Password=@pass COLLATE SQL_Latin1_General_CP1_CS_AS
end

GO
/****** Object:  StoredProcedure [dbo].[Pr_NuevoEmpleado]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pr_NuevoEmpleado]
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

GO
/****** Object:  StoredProcedure [dbo].[Tb_Departamentos]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Tb_Departamentos]
as
begin
	select Direccion
	from ListadoEmpleados
	group by Direccion
	order by Direccion
end
GO
/****** Object:  StoredProcedure [dbo].[Tb_ListadoEmpleados]    Script Date: 2/13/2024 10:29:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Tb_ListadoEmpleados]
@direccion varchar(200)
as
begin
	select Empleadoid, Tarjeta, Nombre, Cedula, Puesto, Departamento, Direccion,Carnet,Llave
	from ListadoEmpleados
	where Direccion = @direccion
end
GO
USE [master]
GO
ALTER DATABASE [CarnetAsde] SET  READ_WRITE 
GO
