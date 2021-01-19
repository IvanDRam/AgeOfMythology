create database aom;
use aom;
create table Units
(
Unidad int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
Costo varchar(255),
Puntos_Resis int,
Velocidad float,
Coste_Poblacion int,
Alcance_Max int,
Arm_Anticontundente int ,
Arm_Anticortante int,
Arm_Antiproyectiles int,
Dam_Cortante int,
Dam_Perforante int,
Dam_Demoledor int,
Civilizacion varchar(15),
Edad varchar(15),
Tipo varchar(15)
)



BULK INSERT Units
FROM 'C:\Users\ibege\Desktop\crud\aom.csv'
WITH (FIRSTROW = 2,
		 FIELDTERMINATOR = ',',
		ROWTERMINATOR='\n',
		MAXERRORS=5);	

delete from Units;
select * from Units

Drop database aom;

create proc insertar_unidad
@Nombre as varchar(max),
@Costo as varchar(max),
@Puntos_resis as int,
@Velocidad as float,
@Coste_poblacion as int,
@Alcance_max as int,
@Arm_anticontundente as int,
@Arm_anticortante as int,
@Arm_antiperforante as int,
@Dam_Cortante as int,
@Dam_Perforante as int,
@Dam_Demoledor as int,
@Civilizacion as varchar(max),
@Edad as varchar(max),
@Tipo as varchar(max)
as 
if Exists(Select Nombre from Units where Nombre=@Nombre)
Raiserror('Usuario Registrado',16,1)
else
Insert into Units
values (@Nombre,@Costo,@Puntos_resis,@Velocidad,@Coste_poblacion,@Alcance_max,@Arm_anticontundente,@Arm_anticortante,@Arm_antiperforante,@Dam_Cortante,@Dam_Perforante,@Dam_Demoledor,@Civilizacion,@Edad,@Tipo)

create proc borrar_unidad
@Unidad as int 
as 
if Exists(select Nombre from Units where Unidad=@Unidad)
delete Units where Unidad=@Unidad
else
Raiserror('Usuario no Existente',16,1)

create proc actualizar_unidad
@Unidad as varchar(max),
@Nombre as varchar(max),
@Costo as varchar(max),
@Puntos_resis as int,
@Velocidad as float,
@Coste_poblacion as int,
@Alcance_max as int,
@Arm_anticontundente as int,
@Arm_anticortante as int,
@Arm_antiperforante as int,
@Dam_Cortante as int,
@Dam_Perforante as int,
@Dam_Demoledor as int,
@Civilizacion as varchar(max),
@Edad as varchar(max),
@Tipo as varchar(max)
as 
if Exists(Select Nombre from Units where Unidad=@Unidad)
update Units set Nombre=@Nombre, Puntos_Resis=@Puntos_resis,Velocidad=@Velocidad,Coste_Poblacion=@Coste_poblacion,
				Alcance_Max=@Alcance_max,Arm_Anticontundente=@Arm_anticontundente,Arm_Anticortante=@Arm_anticortante,
				Arm_Antiproyectiles=@Arm_antiperforante,Dam_Cortante=@Dam_Cortante,Dam_Perforante=@Dam_Perforante,
				Dam_Demoledor=@Dam_Demoledor,Civilizacion=@Civilizacion,Edad=@Edad,Tipo=@Tipo
where Unidad=@Unidad
else
raiserror('Usuario no encontrado',16,1)


create proc mostrar_unidad
as 
select * from Units