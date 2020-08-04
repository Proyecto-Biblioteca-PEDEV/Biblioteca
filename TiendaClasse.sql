create database TiendaClase2
go

use TiendaClase2
go 


create table Usuario(
	idUsuario int primary key not null,
	nombre varchar(25) not null,
	apellido varchar(25),
	nombreUsuario varchar(25) not null,
	pw varchar(40) not null,
	rol char(15) not null,
	estado char(20) not null,correo varchar(50) 
)
alter table Usuario add correo varchar(50) 

-- Procedimientos Almacenados CRUD----------------------------------
------------------------------ INSERTAR -----------------------------------------------------------
create procedure insertarUsuario(
	@IdUsuario as int,
	@nombre as varchar(25),
	@apellido as varchar(25),
	@userName  varchar(25),
	@psw varchar(25),
	@rol  char(15),
	@estado char(20),
	@correo varchar(50)
	)
	as begin
		if exists (select nombreUsuario from Usuario where nombreUsuario=@userName and estado='activo')
		raiserror('Ya existe un registro con ese usuario, por Favor ingrese uno nuevo',16,1)
	else
	insert into Usuario values(@IdUsuario,@nombre,@apellido,@userName,@psw,@rol,@estado,@correo)
end

execute insertarUsuario 1,'Sandra','Calderon','Jackelin','Calder0n','admin','activo','sandra21jackelin@gmail.com'
execute insertarUsuario 2,'Rigo','Cardona','RigoC','mai','admin','activo','albert22@gmail.com'
execute insertarUsuario 3,'Jackelin','Ramirez','Jacky','Rami123','admin','activo','Jacky26h@gmail.com'
execute insertarUsuario 6,'David','Castro','dCastro','dac123','cajero','activo','davidc@gmail.com'
execute insertarUsuario 5,'Elmer','Chandia','Chandi17','Holamundo2020','Admin','activo','Elmerchandia0615@gmail.com'


---------- MODIFICAR ------------------------------------
Create procedure ModificarUsuario
	@IdUsuario as int, @nombre as varchar(25), @apellido as varchar(25), @userName  varchar(25), @psw varchar(25), @rol  char(15), @correo varchar(50)
	as begin 
		if exists(select nombreUsuario,idUsuario from Usuario where 
		(nombreUsuario = @userName and idUsuario <> @IdUsuario and estado='activo') or
		(nombre=@nombre and idUsuario <> @IdUsuario and estado= 'activo'))
		raiserror('Usuario en uso, utilice otro por favor',16,1)
		else
		update usuario set nombre=@nombre, apellido=@apellido, pw=@psw, rol=@rol, correo=@correo where idUsuario=@IdUsuario
	end
---------- ELIMINAR o cambiar de estado ------------------------------------
create procedure eliminarUsuario(
@IdUsuario int)
as begin 
if exists(select idUsuario from Usuario where idUsuario=@IdUsuario and rol = 'admin')
		raiserror('El usuario *Admin* no se puede eliminar,Accion denegada',16,1)
  else
  update Usuario set estado ='eliminado' where idUsuario=@IdUsuario and rol <> 'admin'
end

execute eliminarUsuario 6
execute eliminarUsuario 3
select * from Usuario
go

alter procedure BuscarNombre(
@nombre as varchar(25)
) 
as begin 
select CONCAT(nombre,' ',apellido) as 'Nombre completo',nombreUsuario as 'Usuario', pw as 'Password'  from Usuario where nombre like  concat('%',@nombre,'%')
end

execute BuscarNombre 'E'


--------------------- Buscar por nombre ------------------------------------
-------------- nombre --> Usuario
-------------- apellido + nombre --> Nombre Completo
-------------- TAREA encriptar base de datos desde visual studio (Conjunto de caracteres aleatorios) en la contraseña-------------------------------