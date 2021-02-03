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
Categoria varchar(20) check (Categoria  in ('Contratado','Nombrado')),
Especialidad varchar(60) check (Especialidad in ('Auditoria en Redes','Ingenieria de Software','Gestion de Tecnologias de la Informacion','Ciencias de la Computacion')),
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
Tipo varchar(40),
-- especificacion de claves
primary key (CodTramite),
)
go


create table TRequisitoXTramite
(
CodTramite varchar(6),
CodRequisito varchar(6),
foreign key (CodTramite) references TTramite,
foreign key (CodRequisito) references TRequisito
)



create table TRequisito
( -- lista de atributos
CodRequisito varchar(6),
TipoRequisito varchar(10),

-- especificacion de claves
primary key (CodTramite),
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
insert into TDocente values('D00001','Valdez Fernandez','Antonio','antonio.fernandez@unsaac.edu.pe','984562347','74589636','Nombrado','Auditoria en Redes','Ninguno')

insert into TTesista values ('162531','Zarate Garcia','Alfredo','162531@unsaac.edu.pe','965789025','72634545')



insert into TTesis values('T00001','162531','D00001','Infraestructura Tecnologica 1','Dictamen','Ninguno')

select * from TTesis



insert into TTramite values ('TR0001','Nombramiento de Asesor e Inscripcion de Plan de Tesis')
insert into TTramite values ('TR0002','Solicitar Nombramiento de la Comision Revisora y su posterior Revision')
insert into TTramite values ('TR0003','Solicitar Nombramiento de dictaminadores de Tesis y su posterior Revision')
insert into TTramite values ('TR0004','Determinacion de Fecha, Hora y Lugar para Sustentacion de Tesis')


insert into TRequisitoXTramite values('TR0001' ,'REQ001')
insert into TRequisitoXTramite values('TR0001' ,'REQ002')
insert into TRequisitoXTramite values('TR0001' ,'REQ003')
insert into TRequisitoXTramite values('TR0001' ,'REQ004')

insert into TRequisitoXTramite values('TR0002' ,'REQ001')
insert into TRequisitoXTramite values('TR0002' ,'REQ002')
insert into TRequisitoXTramite values('TR0002' ,'REQ003')

insert into TRequisitoXTramite values('TR0003' ,'REQ001')
insert into TRequisitoXTramite values('TR0003' ,'REQ005')
insert into TRequisitoXTramite values('TR0003' ,'REQ006')
insert into TRequisitoXTramite values('TR0003' ,'REQ007')
insert into TRequisitoXTramite values('TR0003' ,'REQ008')
insert into TRequisitoXTramite values('TR0003' ,'REQ009')

insert into TRequisitoXTramite values('TR0004' ,'REQ001')
insert into TRequisitoXTramite values('TR0004' ,'REQ010')
insert into TRequisitoXTramite values('TR0004' ,'REQ011')
insert into TRequisitoXTramite values('TR0004' ,'REQ009')


--Nombramiento de Asesor e Inscripcion de Plan de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
--insert into TRequisito values ('REQ003','Carta de Aceptacion del Asesor')
--insert into TRequisito values ('REQ004','Ficha de Seguimiento Academico')

--Solicitar Nombramiento de la Comision Revisora y su posterior Revision
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
--insert into TRequisito values ('REQ003','Carta de Aceptacion del Asesor')

--Nombramiento de dictaminadores de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ005','Informe del Asesor')
--insert into TRequisito values ('REQ006','Resolucion de Aprobacion de Expediente de Titulo')
--insert into TRequisito values ('REQ007','Dos Ejemplares de Tesis Anillado')
--insert into TRequisito values ('REQ008','Certificado de Originalidad de la Tesis, firmado por el Asesor')
--insert into TRequisito values ('REQ009','Pago Por Derechos De Tramite')

--Determinacion de Fecha, Hora y Lugar para Sustentacion de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ010','Copia de Resolucion de Aprobacion de Dictamen de Tesis')
--insert into TRequisito values ('REQ011','05 ejemplares de tesis ')
--insert into TRequisito values ('REQ009','Pago por Derechos de Tramite')


insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
insert into TRequisito values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
insert into TRequisito values ('REQ003','Carta de Aceptacion del Asesor')
insert into TRequisito values ('REQ004','Ficha de Seguimiento Academico')
insert into TRequisito values ('REQ005','Informe del Asesor')
insert into TRequisito values ('REQ006','Resolucion de Aprobacion de Expediente de Titulo')
insert into TRequisito values ('REQ007','Dos Ejemplares de Tesis Anillado')
insert into TRequisito values ('REQ008','Certificado de Originalidad de la Tesis, firmado por el Asesor')
insert into TRequisito values ('REQ009','Pago Por Derechos De Tramite')
insert into TRequisito values ('REQ010','Copia de Resolucion de Aprobacion de Dictamen de Tesis')
insert into TRequisito values ('REQ011','05 ejemplares de tesis ')