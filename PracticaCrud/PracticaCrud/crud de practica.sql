create database colegioDB;
use colegioDB;
create table alumnos (
codigo int IDENTITY (1,1) PRIMARY KEY NOT NULL,
dni nvarchar(8),
nombres nvarchar(50),
apellidos nvarchar(50),
edad int,
);

select * from alumnos;
insert into alumnos (dni,nombres,apellidos,edad)
values ('8096','Pedro','Perez','86');
insert into alumnos (dni,nombres,apellidos,edad)
values ('3333','Jose','Mendoza','12');
insert into alumnos (dni,nombres,apellidos,edad)
values ('5645','will','Lopez','23');
insert into alumnos (dni,nombres,apellidos,edad)
values ('5945','Carrillo','Perez','20');
insert into alumnos (dni,nombres,apellidos,edad)
values ('5888','PEpe','Ramirez','4');

UPDATE alumnos set alumnos.dni = '2334445', alumnos.nombres = 'Nely', alumnos.apellidos = 'Prado', alumnos.edad= 18 WHERE alumnos.codigo = 2;
DELETE FROM alumnos WHERE alumnos.codigo= 3; 