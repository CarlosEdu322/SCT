use Master
go
---------------------------------------
-- CREACION DE LA BASE DE DATOS --
---------------------------------------
if exists (select * from dbo.sysdatabases where name='BDControlPlanDeTesis')
drop database BDControlPlanDeTesis
go
create database BDControlPlanDeTesis
go
---------------------------------------
-- CREACION DE LAS TABLAS --
---------------------------------------
use BDControlPlanDeTesis
go
create table TTesista
( -- lista de atributos
CodTesista varchar(6) check (CodTesista like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
Apellidos varchar(20),
Nombres varchar(20),
Correo varchar(20),
Telefono varchar(20),
DNI varchar(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
-- especificacion de claves
primary key (CodTesista)
)
go

create table TDocente
( -- lista de atributos
CodDocente varchar(6) check (CodDocente like '[D][0-9][0-9][0-9][0-9][0-9]'),
Apellidos varchar(20),
Nombres varchar(20),
Correo varchar(40),
Telefono varchar(20),
DNI varchar(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Categoria varchar(20) (Categoria like in('Contratado','Nombrado')),
Impedimento varchar(20),
-- especificacion de claves
primary key (CodDocente)
)
go

--------------------------------------------------
create table TTesis
( -- lista de atributos
CodTesis varchar(6),
CodTesista varchar(6),
CodDocente varchar(6),
Titulo varchar(40),
Estado varchar(20),
Observaciones varchar(20),
-- especificacion de claves
primary key (CodTesis),
foreign key (CodTesista) references TTesista,
foreign key (CodDocente) references TDocente
)
go



--------------------------------------------------
create table TTramite
( -- lista de atributos
CodTramite varchar(6),
TipoTramite varchar(10),
CodTesista varchar(6),
FechaTramite datetime,
-- especificacion de claves
primary key (CodTramite),
foreign key (CodTesista) references TTesista
)
go





create table TRequisitos
( -- lista de atributos
CodRequisitos varchar(6),
TipoTramite varchar(10),

-- especificacion de claves
primary key (CodTramite),
foreign key (CodTesista) references TTesista
)
go


--------------------------------------------------
--------------------------------------------------


create table TComisionRevisora
( -- lista de atributos
CodEvaluacionPlanDeTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
primary key (CodEvaluacionPlanDeTesis),
foreign key (CodDocente) references TDocente
)
go

create table TDictaminantesDeTesis
( -- lista de atributos
CodDictamenDeTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
primary key (CodDictamenDeTesis),
foreign key (CodDocente) references TDocente
)
go

create table TJuradoEvaluador
( -- lista de atributos
CodDictamenDeTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
primary key (CodDictamenDeTesis),
foreign key (CodDocente) references TDocente
)
go

create table TExpediente
( -- lista de atributos
CodExpediente varchar(6),
CodTesista varchar(6) not null,
CodTesis varchar(6) not null,
CodEvaluacionPlanDeTesis varchar(6) ,
CodDictamenDeTesis varchar(6) ,
CodSustentacionOral varchar(6) ,
Observacion varchar(40) not null,
-- especificacion de claves
primary key (CodExpediente),
foreign key (CodTesista) references TTesista,
foreign key (CodTesis) references TTesis,
foreign key (CodEvaluacionPlanDeTesis) references TComisionRevisora,
foreign key (CodDictamenDeTesis) references TDictaminantesDeTesis,
foreign key (CodSustentacionOral) references TJuradoEvaluador
)
go

create table TActaDePlanDeTesis
( -- lista de atributos
CodEvaluacionPlanDeTesis varchar(6),
CodDocente varchar(6),
CodTesis varchar(6),
CodTesista varchar(6),
NotaIdentificacionProblema int,
NotaHipotesis int,
NotaAlcanceResultados int,
NotaMetodologia int,
NotaRevisionBibliografica int,
NotaRecursosPresupuesto int,
NotaImpacto int,
NotaOrganizacionDocTesis int,
NotaPresentacionGenDocTesis int,
-- especificacion de claves
primary key (CodEvaluacionPlanDeTesis),
foreign key (CodDocente) references TDocente,
foreign key (CodTesis) references TTesista,
foreign key (CodTesista) references TTesis,
)
go



create table TActaDictamenDeTesis
( -- lista de atributos
CodDictamenDeTesis varchar(6),
CodDocente varchar(6),
CodTesis varchar(6),
CodTesista varchar(6),
NotaSuficienciaJuicio int,
-- especificacion de claves
primary key (CodDictamenDeTesis),
foreign key (CodDocente) references TDocente,
foreign key (CodTesis) references TTesista,
foreign key (CodTesista) references TTesis,
)
go


create table TActaSustentacionOral
( -- lista de atributos
CodSustentacionOral varchar(6),
CodDocente varchar(6),
CodTesis varchar(6),
CodTesista varchar(6),
NotaPresentacion int,
NotaDominio int,
NotaSintesis int,
NotaDesenvolvimientoTesis int,
NotaPresentacionTrabajo int,
NotaDominioTema int,
NotaCapacidadExposicion int,
NotaDesenvolvimientoAbsolucionPreguntas int,
-- especificacion de claves
primary key (CodSustentacionOral),
foreign key (CodTesis) references TTesista,
foreign key (CodTesista) references TTesis,
)
go

create table TNotificacionDeCargo
( -- lista de atributos
CodDocente varchar(6),
FechaNombramiento varchar(6),
Cargo varchar(6),
Estado varchar(6),
foreign key (CodDocente) references TDocente,
)


create table TTesista
( -- lista de atributos
CodTesista varchar(6) check (CodTesista like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
Apellidos varchar(20),
Nombres varchar(20),
Correo varchar(20),
Telefono varchar(20),
DNI varchar(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
-- especificacion de claves
primary key (CodTesista)
)
go



create table TTesis
( -- lista de atributos
CodTesis varchar(6),
CodTesista varchar(6),
CodDocente varchar(6),
Titulo varchar(40),
Estado varchar(20),
Observaciones varchar(20),
-- especificacion de claves
primary key (CodTesis),
foreign key (CodTesista) references TTesista,
foreign key (CodDocente) references TDocente
)
go

---------------------------------------
-- INSERTAMOS DATOS A LAS TABLAS --
---------------------------------------
insert into TDocente values('D00001','Valdez Fernandez','Antonio','antonio.fernandez@unsaac.edu.pe','984562347','74589636','Nombrado','Ninguno')

insert into TTesista values ('162531','Zarate Garcia','Alfredo','162531@unsaac.edu.pe','965789025','72634545')



insert into TTesis values('T00001','162531','D00001','Infraestructura Tecnologica 1','Dictamen','Ninguno')

select * from TTesis