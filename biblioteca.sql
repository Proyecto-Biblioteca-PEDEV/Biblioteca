create database Biblioteca
go

use Biblioteca
go 

create schema proyecto
go

-------------- Genero libros ----------------
-- drop table proyecto.genero
create table proyecto.genero(
	idGenero int primary key  not null,
	nombre varchar(30) not null
)
-------------- Estado libros ---------------------
-- drop table proyecto.EstadoLibro
create table proyecto.EstadoLibro(
	idEstado int primary key identity not null,
	estado varchar(30) not null
)

-------------- Estado alumnos ---------------------
-- drop table proyecto.EstadoAlumnos
create table proyecto.EstadoAlumnos(
	id int primary key identity not null,
	estado varchar(30) not null
)
-------------- facultad ------------------------
 -- drop table proyecto.Facultad
create table proyecto.Facultad(
	idFacultad int primary key identity not null,
	nombreFacultad varchar(50) not null
)

-------------- Usuarios -----------

create table proyecto.Usuarios(
	id int primary key not null,
	UserName varchar(30) not null,
	contrasena varchar(20) not null
)

----------------- libros ---------
  drop table proyecto.libros
create table proyecto.libros(
	idLibro int primary key not null,
	nombre varchar(40) not null,
	autor varchar(30) not null,
	editorial varchar(40) not null,
	generoId int foreign key references proyecto.genero(idGenero),
	publicacion int not null,
	pais varchar(30),
	idioma varchar(30),
	estadoId int foreign key references proyecto.EstadoLibro(idEstado)
)

-------- Registro alumnos --------------------
-- drop table proyecto.Alumno
create table proyecto.Alumno(
	idAlumno varchar(15) primary key not null,
	nombre varchar(25) not null,
	apellido varchar(25) not null,
	edad int not null,
	facultadid int foreign key references proyecto.Facultad(idFacultad),
	estadoid int foreign key references proyecto.EstadoAlumnos(id),
	multa int
)

----------- Prestamos -----------------------
-- drop table proyecto.Prestamo
create table proyecto.Prestamo(
	idPrestamo int primary key not null,
	alumnoid varchar(15) foreign key references proyecto.Alumno(idAlumno),
	libroid int foreign key references proyecto.libros(idLibro),
	fechaPrestamo date not null,
	fechaVencimiento date not null,
)

------------ Retornos ----------------------------
--  drop table proyecto.Retornos
create table proyecto.Retornos(
	idretorno int primary key not null,
	alumnoid varchar(15) foreign key references proyecto.Alumno(idAlumno),
	libroid int foreign key references proyecto.libros(idLibro),
	prestamoid int foreign key references proyecto.Prestamo(idPrestamo),
	fechaRetorno date not null,
)

----- inserciones estado libro ------
insert into proyecto.EstadoLibro (estado) values ('Retornado'),('No Retornado'),('Extraviado'),('Libre'),('Ocupado'),('Dañado')
select * from proyecto.EstadoLibro
insert into proyecto.EstadoLibro (estado) values ('Elimado')

----- inserciones estado Alumno ------
insert into proyecto.EstadoAlumnos (estado) values ('Disponible'),('Denegado')
select * from proyecto.EstadoAlumnos

----- inserciones  Facultad------
insert into proyecto.Facultad (nombreFacultad) values ('Ing. Ciencias de la Computacion'),('Ing. Industrial'),('Ing. Civil'),('Medicina'),('Odontologia'),('Enfermeria')
select * from proyecto.Facultad

----- inserciones en Genero ------
insert into proyecto.genero (idGenero, nombre) values (0,'Ciencia Ficcion'),(1,'Aventuras'),(2,'Terror y Misterio'),
(3,'Romance'),(4,'Educativo'),(5,'Poesia'),(6,'Leyenda y Novela')
select * from proyecto.genero

insert into proyecto.Alumno (idAlumno,nombre, apellido, edad, facultadid, estadoid, multa) values ('0318-2004-02610','Sandra','Calderon',19,1,1,' ')
select * from proyecto.Alumno

---- muestra la identidad, nombreCompleto, edad, facultad, estado del alumno ----------------------------------------
select alu.idAlumno as Identidad, concat(nombre, ' ', apellido) as NombreCompleto,alu.edad, fa.nombreFacultad as Facultad, es.estado from proyecto.Alumno as alu
inner join proyecto.Facultad as fa on fa.idFacultad=alu.facultadid
inner join proyecto.EstadoAlumnos as es on es.id=alu.estadoid

------------------------------------------------------------------------- LIBROS INICIO--------------------------------------------------------------------------------------------------
-- Procedimentos Almacenados formulario Libros -----
-- Sandra Jackelin Calderon 0318200402610
------------------------------ INSERTAR LIBROS -----------------------------------------------------------
alter procedure insertarLibros(
	@idLibro as int,
	@nombre as varchar(40),
	@autor as varchar(30),
	@editorial  varchar(40),
	@generoId int,
	@publicacion int,
	@pais varchar(30),
	@idioma varchar(30),
	@estadoId int
	)
	as begin
		if exists (select idLibro from proyecto.libros where idLibro=@idLibro)
		raiserror('Ya existe un libro con este codigo, por Favor ingrese uno nuevo',16,1)
	else
	insert into proyecto.libros values(@idlibro,@nombre,@autor,@editorial,@generoId,@publicacion,@pais,@idioma,@estadoId)
end

execute insertarLibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2003,'EE.UU','Español',4
select * from proyecto.libros

-- Consulta de la tabla libros
select li.idLibro as Codigo, li.nombre as NombreLibro, li.autor, li.editorial, ge.nombre, li.publicacion, li.pais, li.idioma, es.estado from proyecto.libros as li
inner join proyecto.genero as ge on ge.idGenero = li.generoId
inner join proyecto.EstadoLibro as es on es.idEstado = li.estadoId

---------- MODIFICAR LIBROS ------------------------------------
alter procedure ModificarLibros
	@idLibro as int,
	@nombre as varchar(40),
	@autor as varchar(30),
	@editorial  varchar(40),
	@generoId int,
	@publicacion int,
	@pais varchar(30),
	@idioma varchar(30)
	as begin 
		if exists(select @idLibro from proyecto.libros where idLibro=@idLibro)
		update proyecto.libros set idLibro=@idLibro,nombre=@nombre, autor=@autor,editorial=@editorial, generoId=@generoId, publicacion=@publicacion, pais=@pais, idioma=@idioma where idLibro=@idLibro
		 else
		 raiserror('Este codigo No existe,Accion denegada',16,1) 
	end
	execute ModificarLibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2003,'EE.UU','Español'

	---------- ELIMINAR o cambiar de estado ------------------------------------
alter procedure eliminarLibro(
@idLibro int)
as begin 
  if exists(select idLibro from proyecto.libros where idLibro=@idLibro and estadoId=7)
   raiserror('Este codigo ya fue eliminado eliminar,Accion denegada',16,1)
  else
  update proyecto.libros set estadoId = 7 where idLibro=@idLibro 
end
execute eliminarLibro 123

-- Buscar Libro
alter procedure BuscarLibro
as begin 
select li.idLibro as Codigo, li.nombre as NombreLibro, li.autor as Autor, li.editorial as Editorial, ge.nombre as Genero, li.publicacion as Publicacion, li.pais as Pais, li.idioma as Idioma, es.estado as Estado from proyecto.libros as li
inner join proyecto.genero as ge on ge.idGenero = li.generoId
inner join proyecto.EstadoLibro as es on es.idEstado = li.estadoId
end
execute BuscarLibro

-- buscar 1 libro
alter procedure BuscarLibrouno(
@idLibro int
) 
as begin 
if exists(select @idLibro from proyecto.libros where idLibro=@idLibro)
select idLibro as Codigo, nombre as NombreLibro, autor as NombreAutor, editorial as Editorial, generoId as Genero, publicacion as AñoPublicacion, pais as Pais, idioma as Idioma from proyecto.libros where idLibro=@idLibro
else
  raiserror('Este codigo No existe,Accion denegada',16,1)
end
execute BuscarLibrouno 123
------------------------------------------------------------------------- LIBROS final--------------------------------------------------------------------------------------------------
