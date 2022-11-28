create database adminE;
go
use adminE;
go
create table empleados(
id int not null primary key,
nombre varchar(50),
correo varchar(30),		
cargo varchar(20),
fecha_inicio Date
	)