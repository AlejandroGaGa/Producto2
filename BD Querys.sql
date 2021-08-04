
insert into Carnicero 
values ('Alejandro',2221346310,'alejandroGa71@gmail.com',1);
insert into Carnicero 
values ('Luis',2221108976,'luis71@gmail.com',2);
insert into Carnicero 
values ('Carlos',2222508970,'Carlosw23@gmail.com',1);
insert into Carnicero 
values ('Roberto',2222346578,'Rob33@gmail.com',4);

insert into Carnicero 
values ('Jose',2222346578,'Rob33@gmail.com',4);

--Procedimiento almacenado para insertar Carnicero

create procedure InsertCarn(@Nom varchar(190), @Cel varchar(20),@Correo varchar(150), @Exp smallint)
as
insert into Carnicero
values (@Nom, @Cel ,@Correo,@Exp);
go

select * from Pedido
--Procedimiento almacnado para eliminar carnicero
create procedure DeleteCarni(@idCarn int)
as
delete from Carnicero where id_Carnicero = @idCarn;
go

delete from Carnicero where id_Carnicero = 6

--Procedimiento almacenado para actualizar Carnicero
create procedure UpdateCarni(@idcarn int,@Nom varchar(190), @Cel varchar(20),@Correo varchar(150), @Exp smallint)
as 
update Carnicero set Nombre=@Nom,Celular=@Cel, Correo=@Correo,Exp_anios=@Exp where id_Carnicero = @idcarn
go

update Carnicero set Nombre = 'Juan',Celular= 2221334477,Correo = 'juan88@gmail.com',Exp_anios=2 where id_Carnicero = 7

select * from Pedido

--***********************************************************************************
insert into Cliente
values ('Itzel','Prado','Cuautle',2225743690,'Itzel72@gmail.com');

--Procedimiento almacenado para insertar cliente
create procedure InsertClient(@Nom varchar(90),@ApP varchar(90), @ApM varchar(90), @Cel varchar(20),@Correo varchar(150))
as
insert into Cliente
values (@Nom,@ApP,@ApM, @Cel ,@Correo);
go
--Procedimiento almacenado para eliminar cliente
create procedure DeleteClient(@idClient int)
as
delete from Cliente where id_Cliente = @idClient;
go

--Procedimiento almacenado para actualizar Cliente
create procedure UpdateClient(@idclient int, @Nom varchar(90),@ApP varchar(90), @ApM varchar(90), @Cel varchar(20),@Correo varchar(150))
as 
update Cliente set Nombre=@Nom,App=@ApP, ApM=@ApM, Celular=@Cel, Correo= @Correo where id_Cliente = @idclient
go

select * from Cliente

--***********************************************************************************
insert into EntregaPedido
values (1,1,GETDATE(),GETDATE(),'Bueno');

--Procedimiento almacenado para insertar EntregaPedido
create procedure InsertEntPed(@Fped int, @fRep int, @FechSalida date, @FechEntre date, @Estado varchar(50))
as
insert into EntregaPedido
values (@Fped, @fRep ,@FechSalida,@FechEntre,@Estado);
go

--Procedimiento almacenado para eliminar EntregaPedido
create procedure DeleteEntPed(@idEntrega int)
as
delete from EntregaPedido where id_Entrega = @idEntrega;
go

--Procedimiento almacenado para actualizar EntregaPedido
create procedure UpdateEntPed(@idEnt int ,@Fped int, @fRep int, @FechSalida date, @FechEntre date, @Estado varchar(50))
as 
update EntregaPedido set F_Pedido=@Fped, F_Repartidor=@fRep,Salida=@FechSalida,SeEntrego=@FechEntre, Estado=@Estado where id_Entrega = @idEnt
go

select * from EntregaPedido;

--***********************************************************************************
insert into Pedido
values (GETDATE(),1,1,1,'Efectivo');

insert into Pedido
values (GETDATE(),1,1,1,'$200');

insert into Pedido
values (GETDATE(),1,3,1,'$200');

--Procedimiento almacenado para insertar Pedido
create procedure InsertPedido(@FHra date, @fCliente int, @FCarn int, @Envio bit, @Pago varchar(50))
as
insert into Pedido
values (@FHra, @fCliente ,@FCarn,@Envio,@Pago);
go

--Procedimiento almacenado para eliminar Pedido
create procedure DeletePed(@idPed int)
as
delete from Pedido where id_Pedido = @idPed;
go

--Procedimiento almacenado para actualizar pedido
create procedure UpdatePed(@idped int, @FHra date, @fCliente int, @FCarn int, @Envio bit, @Pago varchar(50))
as 
update Pedido set FechaHora=@FHra, F_Cliente=@fCliente,F_Carnicero=@FCarn,Envio=@Envio, Pago=@Pago where id_Pedido = @idped
go

select * from Pedido;

--***********************************************************************************
insert into Producto
values ('Rebeye', 2.5 , 1 , 150.00, 'Filetedo',1);
insert into Producto
values ('beefsteak', 3 , 2 , 200.00, 'Aplanado',1);

insert into Producto
values ('Longaniza', 1 , 1 , 50.00, 'De Toluca',2);

--Procedimiento almacenado para insertar Producto
create procedure InsertProd(@NomProd varchar(90), @Peso int, @Cant smallint, @Preciofin float, @Nota varchar(150), @fPed int)
as
insert into Producto
values (@NomProd, @Peso,@Cant,@Preciofin,@Nota, @fPed);
go

--Procedimiento almacenado para eliminar Producto
create procedure DeleteProd(@idProd int)
as
delete from Producto where id_prod = @idProd;
go

--Procedimiento almacenado para actualizar Producto
create procedure UpdateProd(@idprod int,@NomProd varchar(90), @Peso int, @Cant smallint, @Preciofin float, @Nota varchar(150), @fPed int)
as 
update Producto set NombreProd=@NomProd, Peso=@Peso,Cantidad=@Cant,PrecioFinal=@Preciofin, NotaEspecial=@Nota, F_Pedido= @fPed where id_prod = @idprod
go


select * from Producto;

--***********************************************************************************
insert into Repartidor
values ('Guillermo',2221847496,'Automovil');

--Procedimiento almacenado para insertar Repartidor
create procedure InsertRep(@nom varchar(200), @Celular varchar(20), @Licencia varchar(40))
as
insert into Repartidor
values (@nom, @Celular, @Licencia);
go

--Procedimiento almacenado para eliminar Repartidor
create procedure DeleteRep(@idRep int)
as
delete from Repartidor where id_Repartidor = @idRep;
go

--Procedimiento almacenado para actualizar repartidor
create procedure UpdateRep(@idrep int,@nom varchar(200), @Celular varchar(20), @Licencia varchar(40))
as 
update Repartidor set Nombre=@nom, Celular=@Celular,Licencia=@Licencia where id_Repartidor = @idrep
go

select * from Repartidor;

--***********************************************************************************
insert into Ubicacion
values ('san felipe', 'vicente guerrero 53', 'puebla', 'puebla','Autopista México-Puebla', 'Casa Amarilla', '72030' , 1);

--Procedimiento almacenado para insertar Ubicación
create procedure InsertUbi(@Col varchar(120), @CalleNum varchar(120),@Mun varchar(90), @Ciud varchar(90), @ref varchar(120) , @carac varchar(100),@Cp varchar(10),@FCli int)
as
insert into Ubicacion
values (@Col, @CalleNum ,@Mun,@Ciud,@ref, @carac, @Cp ,@FCli);
go

--Procedimiento almacenado para eliminar ubicación
create procedure DeleteUbi(@idUbi int)
as
delete from Ubicacion where id_ubicacion = @idUbi;
go

--Procedimiento almacenado para actualizar repartidor
create procedure UpdateUbi(@idubi int,@Col varchar(120), @CalleNum varchar(120),@Mun varchar(90), @Ciud varchar(90), @ref varchar(120) , @carac varchar(100),@Cp varchar(10),@FCli int)
as 
update Ubicacion set Colonia=@Col, Calleynumero=@CalleNum,Municipio=@Mun, Ciudad=@Ciud, Referencia=@ref, Caracteristica=@carac, CP=@Cp, F_Cliente= @FCli where id_ubicacion = @idubi
go

select * from Cliente

--***********************************************************************************

--De un cliente mostrar todos sus pedidos realizados

create procedure ShowPedido(@nameclient varchar(100))
as
select cli.Nombre, cli.App, cli.ApM,ped.FechaHora, prod.NombreProd, prod.Peso, prod.Cantidad, prod.PrecioFinal
from Cliente as cli
inner join Pedido as ped on cli.id_Cliente = ped.F_Cliente
inner join Producto as prod on ped.id_Pedido = prod.F_Pedido
where cli.Nombre = 'GUILLERMO'
go

select *from Producto
select * from Pedido
insert into Pedido values (GETDATE(),2,1,1,'$40')
insert into Producto values ('Longaniza',2,3,10.2,'Para el viejo', 1010)

--De un pedido, saber quien fue el carnicero que atendio el pedido
create procedure carniceroPedido(@idpedido int)
as
select ped.id_Pedido,carn.Nombre
from Pedido as ped
inner join Carnicero as carn on ped.F_Carnicero = carn.id_Carnicero
where ped.id_Pedido = @idpedido
go

--Conocer los pagos que se hicieron a un determinado repartidor

create procedure pagodelivery(@namedelivery int)
as
select ped.Pago, rep.Nombre
from Pedido as ped
inner join EntregaPedido as EPed on ped.id_Pedido = EPed.F_Pedido
inner join Repartidor as rep on EPed.F_Repartidor = rep.id_Repartidor
where rep.Nombre = @namedelivery
go

select *from Repartidor
select * from Producto

--Aclaración sobre un pedido en especifico de un cliente
create procedure pedidoaclaración(@idprod int)
as
select cli.Nombre, cli.App, cli.ApM,ped.FechaHora, prod.NombreProd, prod.Peso, prod.Cantidad, prod.PrecioFinal
from Cliente as cli
inner join Pedido as ped on cli.id_Cliente = ped.F_Cliente
inner join Producto as prod on ped.id_Pedido = prod.F_Pedido
where prod.id_prod = 2;
go

--///////////////////////////////////************************************//////////////////////////////

--Procedimiento almacenado para eliminar carnicero
create procedure DeleteCarni(@idCarn int)
as
delete from Carnicero where id_Carnicero = @idCarn;
go

--Procedimiento almacenado para eliminar cliente
create procedure DeleteClient(@idClient int)
as
delete from Cliente where id_Cliente = @idClient;
go

--Procedimiento almacenado para eliminar EntregaPedido
create procedure DeleteEntPed(@idEntrega int)
as
delete from EntregaPedido where id_Entrega = @idEntrega;
go


--Procedimiento almacenado para eliminar Pedido
create procedure DeletePed(@idPed int)
as
delete from Pedido where id_Pedido = @idPed;
go

--Procedimiento almacenado para eliminar Producto
create procedure DeleteProd(@idProd int)
as
delete from Producto where id_prod = @idProd;
go

--Procedimiento almacenado para eliminar Repartidor
create procedure DeleteRep(@idRep int)
as
delete from Repartidor where id_Repartidor = @idRep;
go

--Procedimiento almacenado para eliminar ubicación
create procedure DeleteUbi(@idUbi int)
as
delete from Ubicacion where id_ubicacion = @idUbi;
go

--////////////////////////////**************************///////////////////////////

--Procedimiento almacenado para actualizar Carnicero
create procedure UpdateCarni(@idcarn int,@Nom varchar(190), @Cel varchar(20),@Correo varchar(150), @Exp smallint)
as 
update Carnicero set Nombre=@Nom,Celular=@Cel, Correo=@Correo,Exp_anios=@Exp where id_Carnicero = @idcarn
go

--Procedimiento almacenado para actualizar Cliente
create procedure UpdateClient(@idclient int, @Nom varchar(90),@ApP varchar(90), @ApM varchar(90), @Cel varchar(20),@Correo varchar(150))
as 
update Cliente set Nombre=@Nom,App=@ApP, ApM=@ApM, Celular=@Cel, Correo= @Correo where id_Cliente = @idclient
go

--Procedimiento almacenado para actualizar EntregaPedido
create procedure UpdateEntPed(@idEnt int ,@Fped int, @fRep int, @FechSalida date, @FechEntre date, @Estado varchar(50))
as 
update EntregaPedido set F_Pedido=@Fped, F_Repartidor=@fRep,Salida=@FechSalida,SeEntrego=@FechEntre, Estado=@Estado where id_Entrega = @idEnt
go

--Procedimiento almacenado para actualizar pedido
create procedure UpdatePed(@idped int, @FHra date, @fCliente int, @FCarn int, @Envio bit, @Pago varchar(50))
as 
update Pedido set FechaHora=@FHra, F_Cliente=@fCliente,F_Carnicero=@FCarn,Envio=@Envio, Pago=@Pago where id_Pedido = @idped
go

--Procedimiento almacenado para actualizar Producto
create procedure UpdateProd(@idprod int,@NomProd varchar(90), @Peso int, @Cant smallint, @Preciofin float, @Nota varchar(150), @fPed int)
as 
update Producto set NombreProd=@NomProd, Peso=@Peso,Cantidad=@Cant,PrecioFinal=@Preciofin, NotaEspecial=@Nota, F_Pedido= @fPed where id_prod = @idprod
go

--Procedimiento almacenado para actualizar repartidor
create procedure UpdateRep(@idrep int,@nom varchar(200), @Celular varchar(20), @Licencia varchar(40))
as 
update Repartidor set Nombre=@nom, Celular=@Celular,Licencia=@Licencia where id_Repartidor = @idrep
go


--Procedimiento almacenado para actualizar repartidor
create procedure UpdateUbi(@idubi int,@Col varchar(120), @CalleNum varchar(120),@Mun varchar(90), @Ciud varchar(90), @ref varchar(120) , @carac varchar(100),@Cp varchar(10),@FCli int)
as 
update Ubicacion set Colonia=@Col, Calleynumero=@CalleNum,Municipio=@Mun, Ciudad=@Ciud, Referencia=@ref, Caracteristica=@carac, CP=@Cp, F_Cliente= @FCli where id_ubicacion = @idubi
go