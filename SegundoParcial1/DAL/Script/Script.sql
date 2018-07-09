
drop database SegundoParcialDB
use SegundoParcialDB
go
create Table Vehiculos
(
VehiculoID int primary key identity (1,1),
Descripcion varchar (max),
MantenimientoTotal int
);
use SegundoParcialDB
go
create Table Talleres
(
TallerID int primary key identity (1,1),
Nombre varchar (max),

);