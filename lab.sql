create table cliente(
nombre varchar(25),
apellido1 varchar(25),
apellido2 varchar(25),
correo varchar(50),
direccion varchar(100),
id nvarchar(128),
cedula char(10),
foreign key (id) references AspNetUsers(Id),
primary key(cedula)
);

create table telefono(
numero char(10),
cedula char(10),
primary key (numero),
foreign key (cedula) references cliente(cedula)
);

create table cuenta(
numero char(10),
tipo varchar(15),
cedula char(10),
primary key (numero),
foreign key (cedula) references cliente(cedula)
);

alter table cliente
add id nvarchar(128) references AspNetUsers
