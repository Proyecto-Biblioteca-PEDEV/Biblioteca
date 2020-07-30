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
	idEstado int primary key not null,
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
	idFacultad int primary key not null,
	nombreFacultad varchar(50) not null
)

-------------- Usuarios -----------

-- create table proyecto.Usuarios(
-- 	id int primary key not null,
-- 	UserName varchar(30) not null,
--	contrasena varchar(20) not null
-- )

----------------- libros ---------
 -- drop table proyecto.libros
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
	id int primary key identity not null,
	idAlumno varchar(15) not null,
	nombre varchar(25) not null,
	apellido varchar(25) not null,
	edad int not null,
	facultadid int foreign key references proyecto.Facultad(idFacultad) null,
	estadoid int foreign key references proyecto.EstadoAlumnos(id) null,
	multa int null
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
insert into proyecto.EstadoLibro (idEstado, estado) values (0,'Retornado'),(1,'No Retornado'),(2,'Extraviado'),(3,'Libre'),(4,'Ocupado'),(5,'Dañado'),(6,'Elimado')
select * from proyecto.EstadoLibro


----- inserciones estado Alumno ------
insert into proyecto.EstadoAlumnos (estado) values ('Disponible'),('Denegado'),('Eliminado')
select * from proyecto.EstadoAlumnos


----- inserciones  Facultad------
insert into proyecto.Facultad (idFacultad ,nombreFacultad) values (0,'Ing. Ciencias de la Computacion'),(1,'Ing. Industrial'),(2,'Ing. Civil'),(3,'Medicina'),(4,'Odontologia'),(5,'Enfermeria')
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
create procedure insertarLibros(
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

execute insertarLibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2003,'EE.UU','Español',3
select * from proyecto.libros

-- Consulta de la tabla libros
select li.idLibro as Codigo, li.nombre as NombreLibro, li.autor, li.editorial, ge.nombre, li.publicacion, li.pais, li.idioma, es.estado from proyecto.libros as li
inner join proyecto.genero as ge on ge.idGenero = li.generoId
inner join proyecto.EstadoLibro as es on es.idEstado = li.estadoId

---------- MODIFICAR LIBROS ------------------------------------
Create procedure ModificarLibros
	@idLibro as int,
	@nombre as varchar(40),
	@autor as varchar(30),
	@editorial  varchar(40),
	@generoId int,
	@publicacion int,
	@pais varchar(30),
	@idioma varchar(30),
	@estadoId int
	as begin 
		if exists(select idLibro from proyecto.libros where idLibro=@idLibro)
		update proyecto.libros set idLibro=@idLibro,nombre=@nombre, autor=@autor,editorial=@editorial, generoId=@generoId, publicacion=@publicacion, pais=@pais, idioma=@idioma, estadoId=@estadoId where idLibro=@idLibro
		 else
		 raiserror('Este codigo No existe,Accion denegada',16,1) 
	end
	execute ModificarLibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2002,'EE.UU','Español','1'

	---------- ELIMINAR o cambiar de estado ------------------------------------
create procedure eliminarLibro(
@idLibro int)
as begin 
  if exists(select idLibro from proyecto.libros where idLibro=@idLibro and estadoId=6)
   raiserror('Este codigo ya fue eliminado eliminar,Accion denegada',16,1)
  else
  update proyecto.libros set estadoId = 6 where idLibro=@idLibro 
end
execute eliminarLibro 123

-- Buscar Libro
Create procedure BuscarLibros
as begin 
select li.idLibro as Codigo, li.nombre as NombreLibro, li.autor as Autor, li.editorial as Editorial, ge.nombre as Genero, li.publicacion as Publicacion, li.pais as Pais, li.idioma as Idioma, es.estado as Estado from proyecto.libros as li
inner join proyecto.genero as ge on ge.idGenero = li.generoId
inner join proyecto.EstadoLibro as es on es.idEstado = li.estadoId
end
execute BuscarLibros

-- buscar 1 libro
create procedure BuscarLibrouno(
@idLibro int
) 
as begin 
if exists(select idLibro from proyecto.libros where idLibro=@idLibro)
select idLibro as Codigo, nombre as NombreLibro, autor as NombreAutor, editorial as Editorial, generoId as Genero, publicacion as AñoPublicacion, pais as Pais, idioma as Idioma, estadoId as Estado from proyecto.libros where idLibro=@idLibro
else
  raiserror('Este codigo No existe,Accion denegada',16,1)
end
execute BuscarLibrouno 123
------------------------------------------------------------------------- LIBROS final--------------------------------------------------------------------------------------------------


------------------------------------------------------------------------- ALUMNOS INICIO--------------------------------------------------------------------------------------------------
-- Procedimentos Almacenados formulario Alumnos -----
-- Olman Josue Garcia Cabrera 0313-2001-00279
------------------ Mostrar datos tabla alumno ----------------------------------------
create procedure llenarAlumno

as begin
	select alu.idAlumno as NumeroCuenta, concat(nombre, ' ', apellido) as NombreCompleto,alu.Edad, fa.nombreFacultad as Facultad, es.Estado from proyecto.Alumno as alu
	inner join proyecto.Facultad as fa on fa.idFacultad=alu.facultadid
	inner join proyecto.EstadoAlumnos as es on es.id=alu.estadoid
end 

execute llenarAlumno 

-------------------------------------------- Procedimiento Insertar ------------------------------------------ 
create procedure insertarAlumno 
	@idAlumno varchar(15), @nombre varchar(25), @apellido varchar(25), @edad int, @facultadid int, @estadoid int, @multa int
as begin
		if exists (select idAlumno from proyecto.Alumno  where idAlumno=@idAlumno)
		raiserror ('Ya existe un registro con ese ID, porfavor ingrese uno nuevo',16,1)
		else
		insert into proyecto.Alumno values (@idAlumno , @nombre, @apellido, @edad, @facultadid, @estadoid, @multa) 
end

execute insertarAlumno '1001-2001-04545','Ana', 'Euceda', '19', 0, 1,' '
execute insertarAlumno '0313-2002-14253','Rosa', 'Gonzales', '18', 1, 1,' '
execute insertarAlumno '1016-2001-03565','Samuel', 'Calix', '19', 2, 1,' '
execute insertarAlumno '1005-2000-01025','Jose', 'Murcia', '20', 3, 1,' '
execute insertarAlumno '0313-2001-00279','Olman', 'Josue', '19', 0, 1,' '
execute insertarAlumno '1201-2001-00123','Elmer', 'Sanchez', '20', 0, 1,' '
execute insertarAlumno '1016-2001-03565','Luis', 'Medina', '20', 0, 1,' '
execute insertarAlumno '0316-2000-00189','Esteban', 'Garcia', '20', 0, 1,' '
select * from proyecto.Alumno

--------------------------------------------------- Modificar -------------------------------------------------
create procedure modificarAlumno
	@idAlumno varchar(15), @nombre varchar(25), @apellido varchar(25), @edad int, @facultadid int
	as begin 
		if exists(select @idAlumno from proyecto.Alumno  where 
					(idAlumno = @idAlumno and estadoid = '1' and nombre=@nombre and apellido=@apellido and edad=@edad and facultadid=@facultadid))
		raiserror ('Usuario esta en uso, utiliza otro por favor', 16,1)
		else
		update proyecto.Alumno set  nombre = @nombre, apellido =@apellido, edad = @edad, facultadid = @facultadid
		where idAlumno = @idAlumno 
end

execute modificarAlumno '0313-2001-00279', 'Olman', 'Cabrera', 19, 0

--------------------------------------------------- Eliminar -------------------------------------------------

create procedure eliminarAlumno
	@idAlumno varchar(15)
as begin 
	if exists (select idAlumno from proyecto.Alumno where idAlumno = @idAlumno and estadoid = '2')
		raiserror ('El Alumno no se puede Eliminar, Accion denegada',16,1)
	else
		update proyecto.Alumno set estadoid = '3'
		where idAlumno = @idAlumno
end

execute eliminarAlumno '1201-2001-00123'

select * from proyecto.alumno

--------------------------------------------------- Buscar ---------------------------------------------------

Create procedure buscarAlumno
@idAlumno varchar(15)
as begin
if exists(select idAlumno from proyecto.Alumno where idAlumno=@idAlumno)
	select idAlumno as 'NumeroCuenta', nombre as 'Nombre', apellido as 'Apellido', edad as 'Edad', facultadid as 'Facultad', estadoid as 'Estado', 
	multa as 'Multa' from proyecto.Alumno where idAlumno like @idAlumno 
	else
	raiserror('Este id de Alumno No existe,Accion denegada',16,1)

end

execute buscarAlumno '0313-2001-00279'
------------------------------------------------------------------------- ALUMNOS FINAL--------------------------------------------------------------------------------------------------