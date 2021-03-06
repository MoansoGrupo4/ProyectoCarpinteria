CREATE DATABASE CARPINTERIA
USE CARPINTERIA
--Password VARCHAR(20) UNIQUE,

create table FUNCION_EMPLEADO(
CodFuncion varchar(6) constraint PK_CodFuncion primary key nonclustered(CodFuncion) not null,
DesFuncion varchar(20) not null,
)
GO
CREATE TABLE EMPLEADO(
IdEmpleado varchar(5)  CONSTRAINT IdEmpleado_PK PRIMARY KEY (IdEmpleado),
NomEmpleado VARCHAR(100) not null,
FuncionEmpleado varchar(6) not null,
DirEmpleado varchar(50),
DNIEmpleado int,
EdadEmpleado int,
FechaEmpleado date,
Numero int,
estEmpleado bit,
password VARCHAR(20)
constraint FK_FuncionEmpleado foreign key(FuncionEmpleado) references FUNCION_EMPLEADO(CodFuncion)
)
GO
CREATE TABLE CLIENTE(
CodCLiente int IDENTITY constraint idCliente_PK Primary key nonclustered(CodCLiente) not null,
NombreCliente varchar(100) not null,
RazonSocialCliente varchar(200),
dirCliente varchar(50),
FechaRegCliente date,
telefono int,
EstadoCliente bit,
)
go
CREATE TABLE INSUMOS(
CodInsumo varchar(6)   CONSTRAINT CodInsumo_PK PRIMARY KEY nonclustered (CodInsumo) not null,
CategoriaInsumo varchar(100) not null,
NomInsumo varchar(100) not null,
CantInsumo int not null,
EmisionInsumo datetime ,
CUnitarioInsumo float not null,
VencImiento datetime not null,
CTInsumo float not null,
EstInsumo bit
)
GO
create table UNIDADMEDIDAMP(
codUnidadMedida varchar(4) constraint PK_CodUnidadMedida primary key(CodUnidadMedida) not null,
DesUnidadMedida varchar(20) not null
)
GO
CREATE TABLE TIPOMADERAMP(
CodTipoMadera varchar(6)   CONSTRAINT CodTipoMadera_PK PRIMARY KEY nonclustered (CodTipoMadera) not null,
DesTipoMadera varchar(30) not null
)
GO
CREATE TABLE MPRIMA(
CodMPrima varchar(6) primary key not null,
NombreMPrima varchar(50) not null,
cantMPrima int not null,
TipogMPrima varchar(6) not null,
tamMPrima varchar(50) not null,
DimAMPrima float not null,
DimBMPrima float not null,
DimCMPrima float not null,
MedidaMPrima varchar (4)not null,
fechaIngresMPrima datetime  not null,
CUMPrima DECIMAL(17,2) not null,
CTMPrima DECIMAL(17,2),
EstMPrima bit,
constraint FK_MedidaMPrima foreign key(MedidaMPrima) references UNIDADMEDIDAMP(codUnidadMedida),
constraint FK_TipogMPrima foreign key(TipogMPrima)references TIPOMADERAMP(CodTipoMadera)
)
GO
CREATE TABLE TIPOMUEBLE(
CodTipoMueble varchar(6)   CONSTRAINT CodTipoMueble_PK PRIMARY KEY nonclustered (CodTipoMueble) not null,
DesTipoMueble varchar(30) not null
)
GO

create table OrdenEntrada(
	idOrdenEntrada varchar(6) constraint idOrdenEntrada_PK primary key (idOrdenEntrada) NOT NULL,
	CodPedido varchar(6),
	CodTipoMadera varchar(6),
	CodInsumo varchar(6)
)
GO
create table MODELO(
CodModelo varchar(6)  CONSTRAINT CodModelo_PK PRIMARY KEY nonclustered (CodModelo) not null,
DesModelo varchar(50),
CodTipoMadera varchar(6) not null,
ColorModelo varchar(10)not null,
PrecioVentaPU float not null,
PrecioVentaPM float not null,
CodTipoMueble varchar(6) not null,
EstadoModelo bit,
constraint FK_CodTipoMadera foreign key(CodTipoMadera) references TIPOMADERAMP(CodTipoMadera),
constraint FK_CodTipoMueble foreign key(CodTipoMueble) references TIPOMUEBLE(CodTipoMueble)
)
GO
create table PEDIDO(
CodPedido varchar(6) CONSTRAINT IdPedido_PK PRIMARY KEY (CodPedido) NOT NULL,
fecha date not null,
CodCliente1 int not null,
total DECIMAL(17,2) not null,
constraint FK_IdCliente foreign key(CodCLiente1) references CLIENTE (CodCliente)
)
GO
CREATE TABLE ORDENPPRODUCCION(

CodCLiente int not null,
CodModelo varchar(6)not null,
CodOP varchar(6) primary key not null,
CodPedido_OP varchar(6) not null,
InicioOP datetime not null,
EstOP bit not null
constraint FK_CodCLiente foreign key (CodCLiente) references CLIENTE(CodCLiente),
constraint FK_CodModelo foreign key (CodModelo) references MODELO(CodModelo),
constraint FK_CodPedido_OP foreign key (CodPedido_OP) references PEDIDO(CodPedido)
)
go

create table DETALLEPEDIDO(
CodDetPedido varchar(6)CONSTRAINT IdDetPedido_PK PRIMARY KEY (CodDetPedido) NOT NULL,
CodPedido varchar(6) not null,
cantidad int not null,
precio DECIMAL(10,2) not null,
CodModelo varchar(6) not null,
constraint FK_IdPedido foreign key(CodPedido) references PEDIDO (CodPedido),
constraint FK_IdModelo foreign key(CodModelo) references MODELO (CodModelo)

)

GO
---------------DATOS MODELO----------------------------
insert into MODELO values('MO001','Para salitas','TMR001','Caoba',120.0,100.2,'TMB001','1')
go
------------DATOS TIPOS MODELO DE MUEBLE---------------
insert into TIPOMUEBLE values('TMB001','1. Mesa')
insert into TIPOMUEBLE values('TMB002','2. Puerta')
insert into TIPOMUEBLE values('TMB003','3. Escritorio')
insert into TIPOMUEBLE values('TMB004','4. Repostero')
insert into TIPOMUEBLE values('TMB005','5. Sofa')
GO
------------DATOS TIPOS DE MADERA ---------------------
insert into TIPOMADERAMP values('TMR001','1. Cedro')
insert into TIPOMADERAMP values('TMR002','2. Caoba')
insert into TIPOMADERAMP values('TMR003','3. Tornillo')
GO
------------DATOS UNIDAD DE MEDIDA---------------------
insert into UNIDADMEDIDAMP values('UM01','Centimetros')
insert intO UNIDADMEDIDAMP values('UM02','1. Centimetros')
insert intO UNIDADMEDIDAMP values('UM03','2. Metros')
insert intO UNIDADMEDIDAMP values('UM04','3. Pulgadas')
insert intO UNIDADMEDIDAMP values('UM05','4. Pies')
GO
------------DATOS MATERIA PRIMA------------------------
insert into MPRIMA values('M00001','Madera fina',100,'TMR002','Grande',5.5,0.5,0.5,'UM02','15/06/2022',1200.5,120000.5,'1')

GO
------------DATOS INSUMOS------------------------------
insert into INSUMOS values('I00001','Adhesivos','Cola sintetica Tekno 1kg','3','12/11/2019','13','12/10/2025','39','1')
insert into INSUMOS values('I00002','Acabados','Baeniz Marino Tekno 1gl','2','12/11/2016','94.5','12/10/2023','189','1')
insert into INSUMOS values('I00003','Clavos','Clavos 1/8','150','12/11/2019','0.25','12/10/2025','90.0','1')
GO
------------DATOS CLIENTE------------------------------
INSERT INTO CLIENTE VALUES('Javier Alexander flores','Flor de Loto','Los sauses N?? 165','22/03/2022',931524687,'1')
INSERT INTO CLIENTE VALUES('yulissa Perez','Escuela 1021','San Camilo','22/04/2022',931512687,'1')
go
-------------DATOS EMPLEADO-----------------------------
insert into EMPLEADO values ('1', 'Gilmer ', 'Jefe Ventas', 'San Isidro', 27668825,20,'10/02/2022',987456542,'1', 'Admin');
insert into EMPLEADO values ('2', 'Elvis ', 'Gerente General', 'San Isidro',74295700 ,20,'10/01/2022',984657456,'1', 'AdminP');
insert into EMPLEADO values ('3', 'Jose ', 'Administrador', 'El porvenir',85726958 ,20,'15/06/2022',985368741,'1', 'Admin1');
go
------Para combobox Empleado-Funcion---------
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('1','1.Gerente General')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('2','2.Jefe de Ventas')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('3','3.Jefe Administracion')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('4','4.Jefe de Produccion')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('5','5.Jefe de compras')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('6','6.Vendedor')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('7','7.Encargado almacen')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('8','8.Carpintero')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('9','9.Tapicero')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('10','10.Barnizador')
insert into FUNCION_EMPLEADO(CodFuncion,DesFuncion)values('11','11.Lijador')
GO
--------SELECT PARA INGRESAR USUSUARIO------------------


declare @Usuario varchar =' 1';
declare @Contra varchar(20)= 'Admin'

select* from   EMPLEADO where  IdEmpleado = @Usuario and Password = @Contra;
GO
--------------------------------------------------------EMPLEADO-----------------------------------------
--BUSCAR EMPLEADO 
create procedure spBucarEmpleado
@nomEmpleado varchar(100)
as
begin
select IdEmpleado,NomEmpleado, FuncionEmpleado, DirEmpleado, DNIEmpleado,EdadEmpleado,
	   FechaEmpleado,numero,estEmpleado from Empleado where NomEmpleado like @NomEmpleado + '%' and estEmpleado = 1
end
go
--INSERTAR EMPLEADO
CREATE PROCEDURE spInsertarEmpleado(
	@IdEmpleado varchar(5) ,@NomEmpleado VARCHAR(100) ,@FuncionEmpleado varchar(6),
	@DirEmpleado varchar(50),@DNIEmpleado int,@EdadEmpleado int,@FechaEmpleado date,
	@numero int,@estEmpleado bit
)
as
begin 
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(IdEmpleado) from EMPLEADO)
	set @codmax = ISNULL(@codmax,'E0000')
	set @codnuevo = 'E'+ RIGHT(RIGHT(@codmax,4)+ 10001,4) 
	insert into EMPLEADO(IdEmpleado,NomEmpleado, FuncionEmpleado, DirEmpleado,DNIEmpleado,EdadEmpleado,FechaEmpleado,numero,estEmpleado)
	values	(@codnuevo, @NomEmpleado,@FuncionEmpleado, @DirEmpleado,
			@DNIEmpleado,@EdadEmpleado,@FechaEmpleado,@numero,@estEmpleado)
end
GO
--LISTAR EMPLEADO
CREATE PROCEDURE spListarEmpleado
AS
	SELECT IdEmpleado, NomEmpleado, FuncionEmpleado, DirEmpleado, DNIEmpleado, EdadEmpleado,FechaEmpleado,numero,estEmpleado
	from Empleado
             where estEmpleado='1'
GO
--Editar EMPLEADO
create  PROCEDURE spEditaEmpleado(
	@IdEmpleado varchar(5),	@NomEmpleado VARCHAR(50) ,@FuncionEmpleado varchar(6),
	@DirEmpleado varchar(50),@DNIEmpleado int,@EdadEmpleado int,@FechaEmpleado date,
	@numero int,@estEmpleado bit
	)
as
begin 
	update  EMPLEADO set 
	NomEmpleado = @NomEmpleado,FuncionEmpleado = @FuncionEmpleado,DirEmpleado = @DirEmpleado,
	DNIEmpleado = @DNIEmpleado,EdadEmpleado = @EdadEmpleado,FechaEmpleado = @FechaEmpleado,
	numero = @numero,estEmpleado = @estEmpleado
	where IdEmpleado = @IdEmpleado	
end
GO
--DESHABILITAR Empleado
create  PROCEDURE spDeshabilitarEmpleado(
@IdEmpleado varchar(5),
 @estEmpleado bit
)
as
begin 
	update  EMPLEADO set 
	estEmpleado = 0
	where IdEmpleado = @IdEmpleado
end
GO
----listar Funcion
create procedure [dbo].[spListarFuncion]
as
   SELECT CodFuncion, DesFuncion
	from FUNCION_EMPLEADO
GO

--------------------------------------CLIENTE--------------------------------------------------------------
--select* from CLIENTE  DROP TABLE CLIENTE
-- buscar cliente
create procedure spBuscarCliente
@NombreCliente varchar(100)
as
begin
SELECT *from CLIENTE where NombreCliente like @NombreCliente + '%' and  EstadoCliente = 1;
end
go
--INSERTAR EMPLEADO
CREATE PROCEDURE spInsertarCliente(
	@NombreCliente VARCHAR(100) ,@RazonSocialCliente varchar(100),@dirCliente varchar(50),
	@FechaRegCliente date,@telefono int,@EstadoCliente bit
)
as
begin 
	insert into CLIENTE (NombreCliente, RazonSocialCliente,dirCliente, FechaRegCliente, telefono, EstadoCliente)
	values	( @NombreCliente,@RazonSocialCliente, @dirCliente,@FechaRegCliente,@telefono,@EstadoCliente)
end 
go
--LISTAR cliente
CREATE PROCEDURE spListarCliente
AS
	SELECT CodCLiente, NombreCliente, RazonSocialCliente,dirCliente, FechaRegCliente, telefono, EstadoCliente
	from CLIENTE
             where EstadoCliente='1'
go
--Editar EMPLEADO
create  PROCEDURE spEditarCliente(
	@CodCLiente int,@NombreCliente VARCHAR(100) ,@RazonSocialCliente varchar(100),
	@dirCliente varchar(50),@FechaRegCliente date,@telefono int,@EstadoCliente bit
	)
as
begin 
	update  CLIENTE set 
	NombreCliente = @NombreCliente,RazonSocialCliente = @RazonSocialCliente,
	dirCliente = @dirCliente,FechaRegCliente = @FechaRegCliente,
	telefono = @telefono,EstadoCliente = @EstadoCliente
	where CodCLiente = @CodCLiente	
end
go
--DESHABILITAR CLIENTE
create  PROCEDURE spDeshabilitarCliente(
@CodCLiente int,
 @EstadoCliente bit
)
as
begin 
	update  CLIENTE set 
	EstadoCliente = 0
	where CodCLiente = @CodCLiente
end 
go
------------------------------------- INSUMOS-------------------------------------------------------------------------------------------------------
-- buscar usuario
create procedure spBuscarInsumo
@NomInsumo char(100)
as
begin
SELECT *from INSUMOS where NomInsumo like @NomInsumo + '%' and  EstInsumo = 1
end
GO
--INSERTAR INSUMOS
CREATE PROCEDURE spInsertarInsumo(
	@CodInsumo varchar(6), @CategoriaInsumo varchar(100) ,@NomInsumo varchar(100),
	@CantInsumo int,@EmisionInsumo datetime,@CUnitarioInsumo float,
	@VencImiento datetime,@CTInsumo float,@EstInsumo bit
)
as
begin 
	declare @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(CodInsumo) from INSUMOS)
	set @Icodmax = ISNULL(@Icodmax,'I00000')
	set @Icodnuevo = 'I'+ RIGHT(RIGHT(@Icodmax,5)+ 100001,5) 
	insert into INSUMOS(CodInsumo,CategoriaInsumo,NomInsumo, CantInsumo, EmisionInsumo,CUnitarioInsumo,VencImiento,CTInsumo,EstInsumo)
	values			   (@Icodnuevo, @CategoriaInsumo,@NomInsumo,@CantInsumo,@EmisionInsumo,@CUnitarioInsumo,@VencImiento,@CTInsumo,@EstInsumo)
end
go
--LISTAR INSUMOS
CREATE PROCEDURE spListarInsumo
AS
	SELECT  * from INSUMOS where EstInsumo='1'
GO
--Editar INSUMOS
create  PROCEDURE spEditarInsumo(
	@CodInsumo varchar(6),@CategoriaInsumo varchar(100) ,@NomInsumo varchar(100),
	@CantInsumo int,@EmisionInsumo datetime,@CUnitarioInsumo float,
	@VencImiento datetime,@CTInsumo float,@EstInsumo bit
	)
as
begin 
	update  INSUMOS set 
	CodInsumo = @CodInsumo,CategoriaInsumo = @CategoriaInsumo,NomInsumo = @NomInsumo,
	CantInsumo = CantInsumo,EmisionInsumo = @EmisionInsumo,CUnitarioInsumo = @CUnitarioInsumo,
	VencImiento = @VencImiento,CTInsumo = @CTInsumo,EstInsumo = @EstInsumo
	where CodInsumo = @CodInsumo
end
GO
--DESHABILITAR INSUMOS
 CREATE  PROCEDURE [dbo].[spDeshabilitarInsumo](
@CodInsumo varchar(6),
 @EstInsumo bit
)
as
begin 
	update  INSUMOS set 
	@EstInsumo = 0 where CodInsumo = @CodInsumo
end
GO
--------------------------------------------MATERIA PRIMA-------------------------------------------
-- BUSCAR MATERIA PRIMA
create procedure spBuscarMPrima
@NombreMPrima varchar(50)
as
begin
SELECT *from MPRIMA where NombreMPrima like @NombreMPrima + '%'
end
GO
-- INSERTAR MATERIA PRIMA
CREATE PROCEDURE spInsertarMPrima(

	@CodMPrima varchar(6),@NombreMPrima varchar(50),@cantMPrima int,
	@CUMPrima DECIMAL(17,2) ,@TipogMPrima varchar(6), @tamMPrima varchar(50),
	@DimAMPrima float,@DimBMPrima float,@DimCMPrima float,
	@MedidaMPrima varchar(4),@fechaIngresMPrima datetime,@CTMPrima DECIMAL(17,2),@EstMPrima bit
)
as
begin 
	declare @codnuevo varchar(6), @codmax varchar(6)
	set @codmax = (select max(CodMPrima) from MPRIMA)
	set @codmax = ISNULL(@codmax,'M00000')
	set @codnuevo = 'M'+ RIGHT(RIGHT(@codmax,5)+ 100001,5) 
	insert into MPRIMA(CodMPrima,NombreMPrima,cantMPrima, CUMPrima, TipogMPrima,tamMPrima,DimAMPrima,DimBMPrima,
					   DimCMPrima,MedidaMPrima,fechaIngresMPrima,CTMPrima,EstMPrima)
	values			   (@codnuevo, @NombreMPrima,@cantMPrima,@CUMPrima,@TipogMPrima,@tamMPrima,@DimAMPrima,@DimBMPrima,
						@DimCMPrima,@MedidaMPrima,@fechaIngresMPrima,@CTMPrima,@EstMPrima)
end
go
-- LISTAR MATERIA PRIMA
CREATE PROCEDURE spListarMPrima
AS
	SELECT*  from MPRIMA
GO
-- EDITAR MATERIA PRIMA
create  PROCEDURE spEditarMPrima(
	@CodMPrima varchar(6),@NombreMPrima varchar(50),@cantMPrima int,@CUMPrima DECIMAL(17,2) ,
	@TipogMPrima varchar(6),@tamMPrima varchar(50),@DimAMPrima float,@DimBMPrima float,
	@DimCMPrima float,@MedidaMPrima varchar (4),@fechaIngresMPrima datetime,
	@CTMPrima DECIMAL(17,2),@EstMPrima bit
	)
as
begin 
	update  MPRIMA set 
	CodMPrima = @CodMPrima,NombreMPrima = @NombreMPrima,cantMPrima = @cantMPrima,
	CUMPrima = @CUMPrima,TipogMPrima = @TipogMPrima,tamMPrima = @tamMPrima,
	DimAMPrima = @DimAMPrima,DimBMPrima= @DimBMPrima,DimCMPrima = @DimCMPrima ,
	MedidaMPrima = @MedidaMPrima,fechaIngresMPrima = @fechaIngresMPrima,
	CTMPrima = @CTMPrima,EstMPrima = @EstMPrima
	where CodMPrima = @CodMPrima
end
go
-- DESHABILITAR MATERIA PRIMA
CREATE  PROCEDURE spDeshabilitarMPrima(
@CodMPrima varchar(6),
@EstMPrima bit
)
as
begin 
	update  MPRIMA set @EstMPrima = '0'where CodMPrima = @CodMPrima
end

GO

--------------------------------------unidad de medida--------------------------------------------------
create procedure [dbo].[spListarUnidadesMedida]
as
   SELECT codUnidadMedida, DesUnidadMedida
	from UNIDADMEDIDAMP
GO
------------------------------------- tipo de madera-------------------------------------------------------
create procedure [dbo].[spListarTipoMadera]
as
   SELECT CodTipoMadera, DesTipoMadera
	from TIPOMADERAMP
GO

----------------------------------------------------- Modelo---------------------------------------------------------------------
------------------------------------------------Tabla para modelo----------------------------------------

---Buscar Modelo
create procedure spBuscarModelo
@DesModelo varchar(50)
as
begin
SELECT CodModelo, DesModelo, CodTipoMadera,ColorModelo, PrecioVentaPU, PrecioVentaPM, CodTipoMueble
	from MODELO where DesModelo like @DesModelo + '%' --and --EstadoModelo=1;
end
go
--Insertar Modelo
CREATE PROCEDURE spInsertarModelo(
	@CodModelo varchar(6) ,@DesModelo varchar(50),@CodTipoMadera varchar(6),
	@ColorModelo varchar(10),@PrecioVentaPU float,@PrecioVentaPM float,
	@CodTipoMueble varchar(6),@EstadoModelo bit
)
as
begin 
	declare @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(CodModelo) from MODELO)
	set @Icodmax = ISNULL(@Icodmax,'R00000')
	set @Icodnuevo = 'R'+ RIGHT(RIGHT(@Icodmax,5)+ 100001,5) 
	insert into MODELO(CodModelo, DesModelo, CodTipoMadera,ColorModelo,PrecioVentaPU,PrecioVentaPM,CodTipoMueble,EstadoModelo)
	values	( @Icodnuevo,@DesModelo, @CodTipoMadera,
			@ColorModelo,@PrecioVentaPU,@PrecioVentaPM,@CodTipoMueble,@EstadoModelo)
end 
GO
----listar Modelo
CREATE PROCEDURE spListarModelo
AS
	SELECT CodModelo, DesModelo, CodTipoMadera,ColorModelo, PrecioVentaPU, PrecioVentaPM, CodTipoMueble,EstadoModelo
	from MODELO
             where EstadoModelo='1'
go

----editar Modelo
create  PROCEDURE spEditarModelo(
	@CodModelo varchar(6) ,@DesModelo varchar(50),@CodTipoMadera varchar(6),
	@ColorModelo varchar(10),@PrecioVentaPU float,@PrecioVentaPM float,
	@CodTipoMueble varchar(6),@EstadoModelo bit
	)
as
begin 
	update  MODELO set 
	CodModelo = @CodModelo,DesModelo = @DesModelo,	CodTipoMadera = @CodTipoMadera,
	ColorModelo = @ColorModelo,PrecioVentaPU = @PrecioVentaPU,
	PrecioVentaPM = @PrecioVentaPM,EstadoModelo=@EstadoModelo
	where CodModelo = @CodModelo	
end
GO
--deshablitar Modelo
create  PROCEDURE spDeshabilitarModelo(
@CodModelo varchar(6),
@EstadoModelo bit
)
as
begin 
	update  MODELO set 
	EstadoModelo = '0'
	where CodModelo = @CodModelo
end 
go
---------------------------------------------TIPO MUEBLE-----------------------------------------
--- listar tipo de mueble---
create procedure [dbo].[spListarTipoMueble]
as
   SELECT CodTipoMueble, DesTipoMueble
	from TIPOMUEBLE
GO
----------------------------Orden de Producci??n-------------------------------------
GO
Create procedure spIsertarOP
@CodCLiente int,@CodModelo varchar(6),@CodOP varchar(6),
@CodPedido int,@InicioOP datetime ,@EstOP bit
as
begin Transaction
Declare  @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(CodModelo) from MODELO)
	set @Icodmax = ISNULL(@Icodmax,'M0000')
	set @Icodnuevo = 'M'+ RIGHT(RIGHT(@Icodmax,5)+ 10001,5) 
	insert ORDENPPRODUCCION values(@CodCLiente,@CodModelo,@Icodnuevo,@CodPedido,@InicioOP,@EstOP)

	if @@ERROR<>0
	begin	
		ROLLBACK TRANSACTION
		return -1
	end
	COMMIT TRANSACTION 
	return @Icodnuevo
go
CREATE PROCEDURE spListarOP
AS
	SELECT *	from ORDENPPRODUCCION
go
CREATE PROCEDURE spEliminarOP
@CodOP varchar(6)
AS
begin
	delete from ORDENPPRODUCCION where CodOP = @CodOP
end
go

--ORDEN DE ENTRADA---
alter table OrdenEntrada add foreign key(CodPedido) references Pedido (CodPedido)
alter table OrdenEntrada add foreign key(CodTipoMadera) references TipoMadera (CodTipoMadera)
alter table OrdenEntrada add foreign key(CodInsumo) references Insumos (CodInsumo)
go
--PROCEDIMIENTOS ALMACENADOS
create procedure spInsertarOrdenEntrada
@codPedido varchar(6),
@codTipoMadera varchar(6),
@codInsumo varchar(6)
as
begin
Declare  @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(idOrdenEntrada) from OrdenEntrada)
	set @Icodmax = ISNULL(@Icodmax,'E00000')
	set @Icodnuevo = 'E'+ RIGHT(RIGHT(@Icodmax,5)+ 10001,5)
insert into OrdenEntrada(idOrdenEntrada,CodPedido,CodTipoMadera,CodInsumo)
VALUES( @Icodnuevo,@codPedido,@codTipoMadera,@codInsumo)
end
go
create procedure spListarOrdenEntrada
as 
select idOrdenEntrada,CodPedido,CodTipoMadera,CodInsumo from OrdenEntrada
go

create  PROCEDURE spEditaOrden(
	@idOrdenEntrada varchar(6),
	@codPedido varchar(6),
	@codTipoMadera varchar(6),
	@codInsumo varchar(6)
	)
as
begin 
	update  OrdenEntrada set 
	codPedido = @codPedido,
	codTipoMadera = @codTipoMadera,
	codInsumo = @codInsumo
	where idOrdenEntrada = @idOrdenEntrada	
end

go
------------------------Asignacion de empleado---------------
create table AsignacionEmp(
IdGrupo varchar(6) constraint Pk_IdGrupo primary key(IdGrupo) not null,
Nombre varchar(100),
Cargo varchar(6),
IdEmpleado varchar(5),
IdOp varchar(6),
HorasTrabajo int not null,
PagoHora float not null,
PagoTotal float not null
constraint Fk_idempleado foreign key(IdEmpleado) references EMPLEADO(IdEmpleado),
constraint Fk_CodOP foreign key(IdOp) references ORDENPPRODUCCION(CodOP)
)
go

CREATE PROCEDURE spInsertarAsignacion(
	@IdGrupo varchar(6),
	@Nombre varchar(100),
    @Cargo varchar(6),
    @IdEmpleado varchar(5),
    @IdOp varchar(6),
    @HorasTrabajo int,
    @PagoHora float,
    @PagoTotal float
)
as
begin 
	declare @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(IdGrupo) from AsignacionEmp)
	set @Icodmax = ISNULL(@Icodmax,'G00000')
	set @Icodnuevo = 'R'+ RIGHT(RIGHT(@Icodmax,5)+ 100001,5) 
	insert into AsignacionEmp(IdGrupo, Nombre, Cargo,IdEmpleado,IdOp,HorasTrabajo,PagoHora,PagoTotal)
	values	( @Icodnuevo,@Nombre, @Cargo,
			@IdEmpleado,@IdOp,@HorasTrabajo,@PagoHora,@PagoTotal)
end 
GO


CREATE PROCEDURE spListarAsignacionEmpleado
AS
	SELECT IdGrupo, Nombre, Cargo,IdEmpleado,IdOp,HorasTrabajo,PagoHora,PagoTotal
	from AsignacionEmp
           
go

----------------------------Alternativa Pedido---------------------------
create table Pedi(
	codPedido varchar(6)constraint PK_codPedido primary key(codPedido) not null,
	CodModelo varchar(6) foreign key references Modelo(CodModelo),
	DesModelo varchar(50),
	CodCliente int foreign key references Cliente(CodCliente),
	NombreCliente varchar(80),
	cantidad int,
	fecha date,
	total  DECIMAL(10,2)
)
go
--------------------PROCEDIMIENTOS-ALTERNATIVA PEDIDO-----------------------------
--Insertar Pedido
create procedure dbo.spInsertPedido
@CodPedido varchar(6),
@CodModelo varchar(6),
@DesModelo varchar(50),
@CodCliente int,
@NombreCliente varchar(80),
@cantidad int,
@fecha date,
@total  DECIMAL(10,2)
as
	Declare  @Icodnuevo varchar(6), @Icodmax varchar(6)
	set @Icodmax = (select max(CodPedido) from Pedi)
	set @Icodmax = ISNULL(@Icodmax,'P00000')
	set @Icodnuevo = 'P'+ RIGHT(RIGHT(@Icodmax,5)+ 00001,5)
insert into Pedi
VALUES( @Icodnuevo,@CodModelo,@DesModelo,@CodCliente,@NombreCliente,@cantidad,@fecha,@total)
go
--Buscar Pedido
create procedure spBuscPedido
@CodPedido varchar(6)
as
begin
SELECT * from Pedi where CodPedido like @CodPedido + '%';
end
go

--Listar Pedido
create procedure dbo.spListPedido
as 
select * from Pedi
go

exec spInsertPedido
	@CodPedido = '1',
	@CodModelo = 'M10001',
	@DesModelo = 'Mesa 6 personas',
	@CodCliente = 2,
	@NombreCliente = 'Mario',
	@fecha = '10/02/2020',
	@total = '120.53'








