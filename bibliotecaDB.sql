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

insert into proyecto.EstadoLibro (idEstado,estado) values (7,'Vencido')
select * from proyecto.EstadoLibro 

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
-- drop table proyecto.Usuarios
create table proyecto.Usuarios(
	id int primary key not null,
	UserName varchar(30) not null,
	contrasena varchar(20) not null,
	Nombre varchar(25) not null,
	Apellido varchar(30) not null,
	Edad int not null,
	Puesto char(15) not null,
	Correo varchar (45) not null,
	estado varchar(15)
)
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
	idAlumno varchar(15) primary key not null,
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
	idEstado int foreign key references proyecto.EstadoLibro(idEstado),
)

insert into proyecto.Prestamo(idPrestamo, alumnoid,libroid,fechaPrestamo,fechaVencimiento) values ('1001','0313-2001-00279','123','09-09-2020','01-08-2020')
insert into proyecto.Prestamo(idPrestamo, alumnoid,libroid,fechaPrestamo,fechaVencimiento) values ('2001','0313-2001-00279','124','09-09-2020','01-08-2020')

select * from proyecto.Prestamo

--------------- Retornos ----------------------
create table proyecto.Retornos(
	idretorno int primary key not null,
	alumnoid varchar(15) foreign key references proyecto.Alumno(idAlumno),
	libroid int foreign key references proyecto.libros(idLibro),
	prestamoid int foreign key references proyecto.Prestamo(idPrestamo),
	fechaRetorno date not null,
	multa float not null,
	estadoMulta varchar(45) not null
)

--------------- Facturas -------------------------
create table proyecto.Facturas(
idFactura int identity primary key not null,
idretorno int foreign key references proyecto.Retornos(idretorno),
alumnoid varchar(15) foreign key references proyecto.Alumno(idAlumno),
montoFactura float not null,
fecha date not null,
descripcion varchar(45) not null
)


insert into proyecto.Retornos (idretorno, alumnoid, libroid, prestamoid, fechaRetorno) values (1, '0313-2001-00279','123','1001','02-08-2020')
insert into proyecto.Retornos (idretorno, alumnoid, libroid, prestamoid, fechaRetorno) values (2, '0313-2001-00279','124','2001','01-08-2020')

select * from proyecto.Retornos 

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
------------------------------------------------------------------------- INSERTAR LIBROS ------------------------------------------------------------------------------------
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
execute insertarLibros 124,'Calculo I','Jenny Yasmin Andonie','McGRAW-HILL INTERAMERICANA EDITORES','4',2019,'Mexico','Español',3
execute insertarLibros 125,'Ética desde la UNICAH hacia el mundo','Claudia Guity','McGRAW-HILL INTERAMERICANA EDITORES','4',2019,'Mexico','Español',3
execute insertarLibros 126,'Hush Hush','Becca Fitzpatrick','Ediciones B','3',2009,'España','Español',3
execute insertarLibros 127,'Bajo la misma estrella','John Green','Dutton Books','3',2012,'Estados Unidos','Español',3
execute insertarLibros 128,'El amor en los tiempos de cólera','Gabriel Garcia Marquez','Penguin Random House','3',1985,'Colombia','Español',3
execute insertarLibros 129,'Orgullo y Perjuicio','Jane Austen','Thomas Egerton','3',1813,'Reino de Gran Bretaña','Ingles',3
execute insertarLibros 130,'La sociedad desescolarizada','Iván Illich','Godot','4',2001,'Argentina','Español',3
execute insertarLibros 131,'Ser Maestro','Raúl Bermejo','Plataforma Testimonio','4',2008,'Mexico','Español',3
execute insertarLibros 132,'La pedagogía de la Liberación','Ana María Freire','Graó','4',2011,'Chile','Español',3
execute insertarLibros 133,'Calculo II','Ana María Freire','McGRAW-HILL INTERAMERICANA EDITORES','4',2020,'Mexico','Español',3
execute insertarLibros 134,'Top Notch 3','Joan Saslow/Allen Ascher','Pearson','4',2015,'Estados Unidos','Ingles',3
select * from proyecto.libros

-- Consulta de la tabla libros
select li.idLibro as Codigo, li.nombre as NombreLibro, li.autor, li.editorial, ge.nombre, li.publicacion, li.pais, li.idioma, es.estado from proyecto.libros as li
inner join proyecto.genero as ge on ge.idGenero = li.generoId
inner join proyecto.EstadoLibro as es on es.idEstado = li.estadoId

---------------------------------------------------------------------- MODIFICAR LIBROS -------------------------------------------------------------------------------------
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
	execute ModificarLibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2002,'EE.UU','Español','4'
	execute ModificarLibros 126,'Hush Hush','Becca Fitzpatrick','Ediciones B','3',2009,'España',Español,3

execute Modificarlibros 123,'Harry Potter y la Orden del Fenix','J.K Rowling','Ediciones Salamandra','1',2003,'EE.UU','Español',7
execute ModificarLibros 124,'Calculo I','Jenny Yasmin Andonie','McGRAW-HILL INTERAMERICANA EDITORES','4',2019,'Mexico','Español', 0

------------------------------------------------------------------------- ELIMINAR o cambiar de estado -----------------------------------------------------------------------
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
-- delete from proyecto.libros where idLibro=123

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
---------------------------------------------------------------- Mostrar datos tabla alumno ------------------------------------------------------------------------------------
create procedure llenarAlumno

as begin
	select alu.idAlumno as NumeroCuenta, concat(nombre, ' ', apellido) as NombreCompleto,alu.Edad, fa.nombreFacultad as Facultad, es.Estado from proyecto.Alumno as alu
	inner join proyecto.Facultad as fa on fa.idFacultad=alu.facultadid
	inner join proyecto.EstadoAlumnos as es on es.id=alu.estadoid
end 

execute llenarAlumno 

----------------------------------------------------------------- Procedimiento Insertar ------------------------------------------------------------------------------------ 
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

-------------------------------------------------------------------------- Modificar ----------------------------------------------------------------------------------------
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

----------------------------------------------------------------------------- Eliminar ---------------------------------------------------------------------------------------

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

----------------------------------------------------------------------------- Buscar ----------------------------------------------------------------------------------------

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

------------------------------------------------------------------------- Libros Vencidos Inicio --------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------  Sandra Jackelin calderon --------------------------------------------------------------------------------------------------
 create procedure mostrarLibrosVencidos
    as begin
        select alu.idAlumno,concat(alu.nombre,' ', alu.apellido) as Nombrecompleto, pre.fechaVencimiento as FechaPrestamo, 
           re.fechaRetorno as fechaRetorno, li.nombre as NombreLibro, es.estado as EstadoLibro from proyecto.Retornos as re
           inner join proyecto.Prestamo as pre on re.prestamoid=pre.idPrestamo
           inner join proyecto.Alumno as alu on  alu.idAlumno=pre.alumnoid
           inner join proyecto.libros as li on li.idLibro=pre.libroid
           inner join proyecto.EstadoLibro as es on es.idEstado=li.estadoId
           where li.estadoId=7
    end

    execute mostrarLibrosVencidos

alter procedure buscarLibrosVencidos
	@idAlumno as varchar(15) 
    as begin
	if exists (select alumnoid from proyecto.Retornos as re
		   inner join proyecto.libros as li on li.idLibro=re.libroid
           inner join proyecto.EstadoLibro as es on es.idEstado=li.estadoId
		   where li.estadoId=7 and re.alumnoid = @idAlumno )	 

        select alu.idAlumno,concat(alu.nombre,' ', alu.apellido) as Nombrecompleto, pre.fechaVencimiento as FechaPrestamo, 
           re.fechaRetorno as fechaRetorno, li.nombre as NombreLibro, es.estado as EstadoLibro from proyecto.Retornos as re
           inner join proyecto.Prestamo as pre on re.prestamoid=pre.idPrestamo
           inner join proyecto.Alumno as alu on  alu.idAlumno=pre.alumnoid
           inner join proyecto.libros as li on li.idLibro=pre.libroid
           inner join proyecto.EstadoLibro as es on es.idEstado=li.estadoId
           where li.estadoId=7 and alu.idAlumno = @idAlumno  

	else raiserror ('Este IDAlumno no existe, Accion Denegada',16,1)
    end

	execute buscarLibrosVencidos '0313-2001-00279'

------------------------------------------------------------------------- Libros Prestados Final --------------------------------------------------------------------------------------------------



----------------------------------------------------------------- USUARIOS INICIO -------------------------------------------------------------------------------------
---------------------------------------------------------- Gloria Andrea Murillo --------------------------------------------------------------------------------------------
------------------------------------------------ PROCEDIMIENTO PARA INGRESAR USUARIOS ----------------------------------------------------------------------------------------
create procedure insertarUsuarios
	@id int, @UserName varchar(30), @contrasena varchar(20), @Nombre varchar(25), @Apellido varchar(30), @Edad int, @Puesto char(15), @Correo varchar(45), @estado varchar(15)
as begin
	if exists (select UserName from proyecto.Usuarios where UserName=@UserName)
		raiserror ('Ya existe un registro con ese usuario, porfavor ingrese uno nuevo',16,1)
		else
		insert into proyecto.Usuarios values(@id, @UserName, @contrasena, @Nombre, @Apellido, @Edad, @Puesto, @Correo, @estado) 
end

drop procedure insertarUsuarios

execute insertarUsuarios 3, 'gMurillo', '7575', 'Gloria', 'Murillo', '19', 'Admin', 'gMurillo@gmail.com', 'activo'
execute insertarUsuarios 4, 'oRivera', '2828', 'Oscar', 'Rivera', '19', 'Admin', 'oRivera@gmail.com', 'activo'
execute insertarUsuarios 5, 'aBarahona', '2626', 'Abril', 'Barahona', '19', 'Admin', 'aBarahona@hotmail.com', 'activo'
execute insertarUsuarios 6, 'gCerrato', '2727', 'Genesis', 'Cerrato', '20', 'Admin', 'gCerrato@yahoo.com', 'activo'
execute insertarUsuarios 7, 'dGuerrera', '2020', 'Denisse', 'Guerra', '21', 'Admin', 'dGuerrera@hotmail.com', 'activo'
execute insertarUsuarios 8, 'fReyes', '1879', 'Francisco', 'Reyes', '22', 'Pasante', 'fReyes@gmail.com', 'activo'

select * from proyecto.Usuarios
-- drop procedure insertarUsuarios
---------------------------------------------------------- PROCEDIMIENTO DE UPDATE(EDITAR) USUARIOS -------------------------------------------------------------------------
create procedure editarUsuarios
	@id int, @UserName varchar(30), @contrasena varchar(20), @Nombre varchar(25), @Apellido varchar(30), @Edad int, @Puesto char(15), @Correo varchar(45)
as begin
	if exists(select UserName,id from proyecto.Usuarios where 
					(UserName = @UserName and id <> @id) or 
					(Nombre=@Nombre and id <> @id))
		raiserror ('Usuario esta en uso, utiliza otro por favor', 16,1)
		else
		update proyecto.Usuarios set contrasena = @contrasena, Nombre = @Nombre, Apellido =@Apellido, Edad = @Edad, Puesto = @Puesto, Correo = @Correo
		where id = @id
	end

-- drop procedure editarUsuarios
execute editarUsuarios 7, 'dGuerrera', '2020', 'Merlin', 'Guerra', '21', 'Admin', 'dGuerrera@hotmail.com'

----------------------------------------------------------- PROCEDIMIENTO PARA BUSCAR LOS USUARIOS ---------------------------------------------------------------------------
create procedure buscarUsuarios
@UserName varchar(30)
as begin
    if exists (select UserName from proyecto.Usuarios where UserName=@UserName)
	select id as Idusuario,Nombre, Apellido,edad as Edad,Puesto as 'Puesto', Correo as 'Correo',contrasena as Contraseña, UserName as 'NombreUsuario'
	from proyecto.Usuarios
	where UserName=@UserName
	else
	raiserror('El usuario No existe!!!, Accion Denegada', 16,1)
end
------------------------------------------------------------------------------ Mostrar --------------------------------------------------------------------------------------
-- select CONCAT(Nombre, ' ', Apellido) as 'Nombre Completo', UserName as 'UserName', Puesto as 'Puesto', Correo as 'Correo', contrasena as Contraseña
	--from proyecto.Usuarios
create procedure mostrarUsuario
as begin
	
	select id as Idusuario,Nombre, Apellido,edad as Edad,Puesto as 'Puesto', Correo as 'Correo',contrasena as Contraseña, UserName as 'NombreUsuario'
	from proyecto.Usuarios
end

execute mostrarUsuario
execute buscarUsuarios 'gMurillo'

------------------------------------------------------------- PROCEDIMIENTO PARA BORRAR USUARIOS	-------------------------------------------------------------------------
create procedure eliminarUsuarios
	@id int, @Puesto char(15)
as Begin 
	if exists (select UserName from proyecto.Usuarios where @Puesto = 'Admin')
	raiserror('El usuario *Admin* no se puede eliminar, Accion Denegada', 16,1)
	else 
		update proyecto.Usuarios set estado = 'Eliminado'
		where id = @id and Puesto <> 'Admin'
end

select * from proyecto.Usuarios

execute eliminarUsuarios 7, 'Admin'
execute eliminarUsuarios 8, 'Pasante'

--------------------------------------------------------------------------------- USUARIOS FINAL --------------------------------------------------------------------------------

--------------------------------------------------------------------------------- LIBROS PRESTADOS --------------------------------------------------------------------------------
--------------------------------------------------------------------------   OLMAN JOSUE GARCIA CABRERA  -----------------------------------------------------------------------------
alter procedure BuscarLibrosPrestados
@idPrestamo as int
as begin
	if exists (Select idPrestamo from proyecto.Prestamo where idPrestamo = @idPrestamo)
	select pre.idprestamo as CodigoPrestamo, pre.alumnoid as IDAlumno, CONCAT(alu.nombre, ' ', alu.apellido) as NombreAlumno, lib.nombre as NombreLibro, pre.fechaPrestamo as FechaPrestamo, pre.fechaVencimiento as FechaVencimiento from proyecto.prestamo as pre 
	inner join proyecto.alumno as alu on alu.idAlumno=pre.alumnoid
	inner join proyecto.libros as lib on lib.idLibro=pre.libroid
	where idPrestamo like @idPrestamo 
	else raiserror ('Este ID Prestamo no existe, Accion Denegada', 16,1)
end

execute BuscarLibrosPrestados 1001

create procedure MostrarLibrosPrestados
as begin
	select pre.idprestamo as CodigoPrestamo, pre.alumnoid as IDAlumno, CONCAT(alu.nombre, ' ', alu.apellido) as NombreAlumno, lib.nombre as NombreLibro, pre.fechaPrestamo as FechaPrestamo, pre.fechaVencimiento as FechaVencimiento from proyecto.prestamo as pre 
inner join proyecto.alumno as alu on alu.idAlumno=pre.alumnoid
inner join proyecto.libros as lib on lib.idLibro=pre.libroid
end





-------------------------------------------------------------------------------------- FINAL --------------------------------------------------------------------------------
--------------------------------------------------------------------- RETORNOS INICIO ---------------------------------------------------------------------------------------
---------------------------------------------------------------- SVEN ALESSANDRO RODRIGUEZ MEZA -----------------------------------------------------------------------------
--Procedimiento para mostrar la tabla de Préstamos--
alter procedure mostrarPrestamos
as begin
select idPrestamo as 'ID Préstamo', alumnoid as 'ID Alumno', concat(a.nombre,' ',a.apellido) as 'Nombre Alumno', 
libroid as 'ID Libro', l.nombre as 'Nombre Libro', fechaPrestamo as 'Fecha Préstamo', fechaVencimiento as 'Fecha de Vencimiento' 
from proyecto.Prestamo as p inner join proyecto.Alumno as a on a.idAlumno = p.alumnoid inner join proyecto.libros as l on
l.idLibro = p.libroid
end

--------------------------------------------------------------------Procedimiento para mostrar la tabla de Retornos----------------------------------------------------------
alter procedure mostrarRetornos
as begin
select idretorno as 'ID Retorno', alumnoid as 'ID Alumno', concat(a.nombre, ' ', a.apellido) as 'Nombre Alumno', libroid as 'ID Libro',
l.nombre as 'Nombre Libro', prestamoid as 'ID Préstamo', fechaRetorno as 'Fecha Retorno', r.multa as 'Multa', estadoMulta as 'Estado Multa'
from proyecto.Retornos as r inner join proyecto.Alumno as a on a.idAlumno = r.alumnoid inner join proyecto.libros as l on l.idLibro = r.libroid
end

-------------------------------------------------------Procedimiento para insertar un retorno--------------------------------------------------------------------------------
alter procedure insertarRetorno 
@idretorno int, @alumnoid varchar(15), @libroid int, @prestamoid int, @fechaRetorno date, @multa float, @estadoMulta varchar(45)
as begin
if exists (select idretorno, prestamoid from proyecto.Retornos where idretorno = @idretorno or prestamoid = @prestamoid)
		raiserror ('ID retorno o ID Préstamo ya existe. Ingrese un ID diferente',16,1)
		else
insert into proyecto.Retornos values (@idretorno, @alumnoid, @libroid, @prestamoid, @fechaRetorno, @multa, @estadoMulta)
update proyecto.libros set estadoId = 1 where idLibro = @libroid
if (@multa > 0 and @estadoMulta = 'No Pagado')
update proyecto.Alumno set estadoid = 2, multa = @multa
else if (@multa = 0 or @estadoMulta = 'Pagado')
update proyecto.Alumno set estadoid = 1, multa = 0
end

--------------------------------------------------------------------Procedimiento para buscar un retorno---------------------------------------------------------------------
alter procedure buscarRetorno 
@idretorno int
as begin
select idretorno as 'ID Retorno', alumnoid as 'ID Alumno', concat(a.nombre, ' ', a.apellido) as 'Nombre Alumno', libroid as 'ID Libro', 
l.nombre as 'Nombre Libro', prestamoid as 'ID Préstamo', fechaRetorno as 'Fecha de Retorno', r.multa as 'Multa', estadoMulta as 'Estado Multa' 
from proyecto.Retornos as r inner join proyecto.Alumno as a on a.idAlumno = r.alumnoid inner join proyecto.libros as l on l.idLibro = r.libroid
where idretorno like @idretorno
end

-----------------------------------------------------------------Procedimiento para editar un retorno------------------------------------------------------------------------
alter procedure editarRetorno
@idretorno int, @estadoMulta varchar(45) 
as begin
if exists (select idretorno, estadoMulta from proyecto.Retornos where estadoMulta = 'Pagado' and idretorno = @idretorno)
raiserror ('La multa ya fue pagada',16,1)
else
update proyecto.Retornos set estadoMulta = @estadoMulta where idretorno = @idretorno
update proyecto.Alumno set multa = 0
end

---------------------------------------------------------------------Procedimiento para insertar una factura -----------------------------------------------------------------
alter procedure insertarFactura
@idretorno int, @alumnoid varchar(15), @montoFactura float, @fecha date
as begin
if exists (select idretorno from proyecto.Facturas as f where f.idretorno = @idretorno)
raiserror ('Factura ya existente',16,1)
else
insert into proyecto.Facturas values (@idretorno, @alumnoid, @montoFactura, @fecha, 'Pago de Multa')
end 

------------------------------------------------------------ Procedimiento para almacenar una factura desde el botón editar -------------------------------------------------
alter procedure insertarFacturaEditar
@idretorno int, @fecha date
as begin
if exists (select idretorno from proyecto.Facturas as f where f.idretorno = @idretorno)
raiserror ('Factura ya existente',16,1)
else
declare @alumnoid varchar(15), @montoFactura float
select @alumnoid = r.alumnoid from proyecto.Retornos as r where r.idretorno = @idretorno
select @montoFactura = r.multa from proyecto.Retornos as r where r.idretorno = @idretorno
insert into proyecto.Facturas values (@idretorno, @alumnoid, @montoFactura, @fecha, 'Pago de Multa')
end
-------------------------------------------------------------------- INICIOS PROCEDIMIENTOS DE PRESTAMOS -------------------------------------------------------------------------------------------
-------------------------------------------------------------------- AGREGAR EN PRETAMOS -------------------------------------------------------------------------------------------
create procedure InsertarPrestamo 
	@idPrestamo int, @idAlumno varchar (25), @idLibro int, @FechaPrestamo varchar(12) , @fechaVencimiento varchar(12), @idEstado int
	as begin 
		if exists (select idPrestamo from proyecto.Prestamo where idPrestamo = @idPrestamo and alumnoid = @idAlumno and libroid = @idLibro and fechaPrestamo = @FechaPrestamo and fechaVencimiento = @fechaVencimiento) 
			raiserror('Ya existe un registro identico',16,1)
		else 
			insert into proyecto.Prestamo values (@idPrestamo, @idAlumno, @idLibro, @FechaPrestamo, @fechaVencimiento, @idEstado) 
			update proyecto.libros set estadoId = @idEstado	where idLibro = @idLibro

	end
-------------------------------------------------------------------- EDITAR EN PRESTAMOS -------------------------------------------------------------------------------------------
	create procedure EditarPrestamo 
	@idPrestamo int, @idAlumno varchar (15), @idLibro int, @FechaPrestamo varchar(12) , @fechaVencimiento varchar(12) 
	as begin 
		if exists (select alumnoid from proyecto.Prestamo where alumnoid = @idAlumno)
			update proyecto.Prestamo set alumnoid = @idAlumno, libroid = @idLibro, fechaPrestamo = @FechaPrestamo, fechaVencimiento = @fechaVencimiento
			where idPrestamo = @idPrestamo
		else
			raiserror ('Alumno no registrado, intentelo nuevamente',16,1)
	end


create procedure EditarlibroEditado 
	@idLibro int, @estadoLibro int
	as begin
		if exists (select idLibro from proyecto.libros where idLibro = @idLibro)
			update proyecto.libros set estadoId = @estadoLibro 
			where idLibro = @idLibro
		else
			raiserror ('Libro no encontrado, intente de nuevo', 16,1)
	end

create procedure EditarLibroViejo
	@idLibro int, @estadoLibro int
	as begin
		if exists (select idLibro from proyecto.libros where idLibro = @idLibro)
			update proyecto.libros set estadoId = @estadoLibro 
			where idLibro = @idLibro
		else
			raiserror ('Libro no encontrado, intente de nuevo', 16,1)
	end

-------------------------------------------------------------------- INNER JOIN DE PRESTAMO -------------------------------------------------------------------------------------------
select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, lib.nombre as Nombre, pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid
-------------------------------------------------------------------- FINAL DE PRESTAMOS -------------------------------------------------------------------------------------------







