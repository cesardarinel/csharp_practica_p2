CREATE TABLE empresa (
    rnc_emp NCHAR(15) PRIMARY KEY,
    ide_emp NCHAR(40),
    dir_emp NCHAR(30),
    sec_emp NCHAR(30),
    pro_emp NCHAR(30),
    tel_emp NCHAR(15),
    ema_emp NCHAR(30)
);

CREATE TABLE usuario (
    cod_usu INT PRIMARY KEY,
    nom_usu NCHAR(30),
    tip_usu INT,
    cla_usu NCHAR(10),
    cel_usu NCHAR(10),
    cor_usu NCHAR(30)
);

CREATE TABLE nomina (
    cod_emp INT PRIMARY KEY,
    nom_emp NCHAR(30),
    ape_emp NCHAR(30),
    sue_bas DECIMAL(18, 2),
    afp_emp DECIMAL(18, 2),
    ars_emp DECIMAL(18, 2),
    isr_emp DECIMAL(18, 2),
    tde_emp DECIMAL(18, 2),
    sue_net DECIMAL(18, 2)
);

CREATE TABLE Calificacion (
    mat_est INT PRIMARY KEY,
    nom_est NCHAR(20),
    ape_est NCHAR(20),
    asi_est NCHAR(50),
    poe INT,
    pf INT,
    ap INT,
    va INT,
    pef INT,
    nf INT,
    L NCHAR(1),
    con NCHAR(15)
);




create table Productos 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)

insert into Productos 
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarProductos
as
select *from Productos
go

--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)
go

------------------------ELIMINAR
create proc EliminarProducto
@idpro int
as
delete from Productos where Id=@idpro
go
------------------EDITAR

create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
go
