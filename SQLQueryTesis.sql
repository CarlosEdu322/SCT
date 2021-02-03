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
Especialidad varchar(60) check (Especialidad in ('AUDITORIA EN REDES','INGENIERIA DE SOFTWARE','TECNOLOGIAS DE INFORMACION Y COMUNICACION','CIENCIAS DE LA COMPUTACION')),
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
Tipo varchar(100),
-- especificacion de claves
primary key (CodTramite),
)
go

create table TRequisito
( -- lista de atributos
CodRequisito varchar(6),
TipoRequisito varchar(100),

-- especificacion de claves
primary key (CodRequisito),
)
go


create table TRequisitoXTramite
(
CodTramite varchar(6),
CodRequisito varchar(6),
foreign key (CodTramite) references TTramite,
foreign key (CodRequisito) references TRequisito
)


select * from TRequisitoXTramite
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




----------------------------------------
-- INSERTAMOS DATOS A LAS TABLA DOCENTE --
---------------------------------------
insert into TDocente values('D00001','ALZAMORA PAREDES','ROBERT WILBERT','robert.alzamora@unsaac.edu.pe','984632900','24589812','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00002','VILLAFUERTE SERNA','RONY','rony.villafuerte@unsaac.edu.pe','998562389','24589689','NOMBRADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00003','CHOQUE SOTO','VANESA MARIBEL','maribel.choque@unsaac.edu.pe','989862347','70349636','NOMBRADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00004','IBARRA ZAMBRANO','WALDO ELIO','waldo.ibarra@unsaac.edu.pe','984596398','24586688','NOMBRADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00005','ZAMALLOA PARO','WILLIAM','william.zamalloa@unsaac.edu.pe','994562385','70589696','CONTRATADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00006','CARRASCO POBLETE','EDWIN','edwin.carrasco@unsaac.edu.pe','984562347','74589636','NOMBRADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00007','CUTIPA ARAPA','EFRAINA GLADYS','efraina.cutipa@unsaac.edu.pe','999525389','24559933','CONTRATADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00008','RIVAS PUGA','ABDON','abdon.rivas@unsaac.edu.pe','984562347','74589636','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00009','CARDENAS MAYTA','ANA ROCIO','ana.cardenas@unsaac.edu.pe','937562347','74590636','CONTRATADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00010','CANDIA OVIEDO','DENIS IVAN','denis.candia@unsaac.edu.pe','912562947','24589622','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00011','PALOMINO OLIVERA','EMILIO','emilio.palomino@unsaac.edu.pe','984562347','74969633','NOMBRADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00012','GAMARRA SALDIVAR','ENRIQUE','enrique.gamarra@unsaac.edu.pe','988588345','70589636','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00013','PACHECO VASQUEZ','ESTER CRISTINA','ester.pacheco@unsaac.edu.pe','914562396','74582635','CONTRATADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00014','TICON PARI','GUZMAN','guzman.ticona@unsaac.edu.pe','912562348','24989636','NOMBRADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00015','DUEÑAS DE LA CRUZ','HENRY SAMUEL','henry.dueñas@unsaac.edu.pe','916282325','24589631','CONTRATADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')
insert into TDocente values('D00016','MEDRANO VALENCIA','IVAN CESAR','ivan.medrano@unsaac.edu.pe','918562342','70589521','NOMBRADO','INGENIERIA DE SOTWARE','Ninguno')
insert into TDocente values('D00017','ROZAS HUACHO','JAVIER ARTURO','javir.rozas@unsaac.edu.pe','919562347','74589696','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00018','CHAVEZ CENTENO','JAVIER DAVID','javier.chavez@unsaac.edu.pe','984562347','70589634','NOMBRADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00019','PILLCO QUISPE','JOSE MAURO','jose.pillco@unsaac.edu.pe','976562347','24589666','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00020','MEDINA MIRANDA','KARELIA','karelia.medina@unsaac.edu.pe','984562325','74589961','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00021','ENCISO RODAS','LAURO','lauro.enciso@unsaac.edu.pe','994562398','74589656','NOMBRADO','AUDITORIA EN REDES','Ninguno')
insert into TDocente values('D00022','FLORES PACHECO','LINO PRISCILIANO','lino.pacheco@unsaac.edu.pe','984662007','74589200','NOMBRADO','CIENCIAS DE LA COMPUTACION','Ninguno')
insert into TDocente values('D00023','PALMA TITO','LUIS BELTRAN','luis.palma@unsaac.edu.pe','984562347','70589056','NOMBRADO','INGENIERIA DE SOFTWARE','Ninguno')
insert into TDocente values('D00024','ACURIO USCA','NILA SONIA','nila.acurio@unsaac.edu.pe','996523479','72529622','NOMBRADO','TECNOLOGIAS DE INFORMACION Y COMUNICACION','Ninguno')


insert into TTesis values('TES001','124813','D00001','TITULO DE TESIS 1','REVISION','NINGUNO')
insert into TTesis values('TES002','124219','D00002','TITULO DE TESIS 2','REVISION','NINGUNO')
insert into TTesis values('TES003','150409','D00003','TITULO DE TESIS 3','REVISION','NINGUNO')
insert into TTesis values('TES004','134544','D00004','TITULO DE TESIS 4','REVISION','NINGUNO')
insert into TTesis values('TES005','113553','D00005','TITULO DE TESIS 5','REVISION','NINGUNO')
insert into TTesis values('TES006','141670','D00006','TITULO DE TESIS 6','REVISION','NINGUNO')
insert into TTesis values('TES007','151827','D00007','TITULO DE TESIS 7','REVISION','NINGUNO')
insert into TTesis values('TES008','110125','D00008','TITULO DE TESIS 8','REVISION','NINGUNO')
insert into TTesis values('TES009','155184','D00009','TITULO DE TESIS 9','REVISION','NINGUNO')
insert into TTesis values('TES010','154637','D00010','TITULO DE TESIS 10','REVISION','NINGUNO')
insert into TTesis values('TES011','141674','D00011','TITULO DE TESIS 11','REVISION','NINGUNO')
insert into TTesis values('TES011','133959','D00011','TITULO DE TESIS 11','REVISION','NINGUNO')

SELECT  * FROM TTesis
----------------------------------------
-- INSERTAMOS DATOS A LAS TABLA TESISTA --
---------------------------------------
insert into TTesista values ('124813','DE LA CRUZ QUISPE','ALEX ALBERTO','124813@unsaac.edu.pe','996789497','24632532')
insert into TTesista values ('124219','VALLE HUAMAN','MARIA ANGELA','124219@unsaac.edu.pe','973789025','72634545')
insert into TTesista values ('150409','TTITO RAMOS','MANUEL DARIO','150409@unsaac.edu.pe','965783029','74234575')
insert into TTesista values ('134544','ZUNIGA HUAMAN','EDI FRAI','134544@unsaac.edu.pe','937159085','24632515')
insert into TTesista values ('113553','FLORES YUCRA','IGNACIO','113553@unsaac.edu.pe','928089096','74362845')
insert into TTesista values ('141670','HALIRE HUAMAN','JAIME ANDRE','141670@unsaac.edu.pe','915786032','24634198')
insert into TTesista values ('151827','LEVA SALAS ','RENAN FERDINANDN','151827@unsaac.edu.pe','918781227','70621528')
insert into TTesista values ('110125','LOPINTA HUAMAN','CRISTIAN RODRIGO','110125@unsaac.edu.pe','989289025','24769542')
insert into TTesista values ('155184','MAMANI CCANAHUIREL','LALO LEONEL','155184@unsaac.edu.pe','981789018','70625583')
insert into TTesista values ('154637','NINA PONCE','JOSUE JOSE','154637@unsaac.edu.pe','992789035','70689502')
insert into TTesista values ('141674','VILCA PANTIGOSO','KAROL BERLIZN','141674@unsaac.edu.pe','921793025','24689572')
insert into TTesista values ('133959','ANCCO PERALTA','JUAN ABEL','133959@unsaac.edu.pe','924398918','72964555')
insert into TTesista values ('151833','CONDE CHURA','YURI FERNANDO','151833@unsaac.edu.pe','925789088','24689354')
insert into TTesista values ('160893','OLAZABAL CALLER','LETICIA GIULIANA','160893@unsaac.edu.pe','919078902','70344501')
insert into TTesista values ('164240','ESCOBEDO DURAN','ROBERTO CARLOS','164240@unsaac.edu.pe','985783621','24615545')
insert into TTesista values ('155185','PEZUA CERNADES','ARACELY','155185@unsaac.edu.pe','912689087','70384588')
insert into TTesista values ('144993','IBARRA HUAMAN','ALEXANDER PAVEL','144993@unsaac.edu.pe','918709095','79625845')
insert into TTesista values ('160545','NAOLA PEREYRA','ALEXANDER YERIM','160545@unsaac.edu.pe','973989025','70656582')
insert into TTesista values ('150389','CONDE SALLO','JHACK STEVEN','150389@unsaac.edu.pe','923789089','24684582')
insert into TTesista values ('150543','DONGO ESQUIVEL','DIEGO YOSHIRO','150543@unsaac.edu.pe','912589025','72634565')




select * from TTesista



insert into TTramite values ('TR0001','Nombramiento de Asesor e Inscripcion de Plan de Tesis')
insert into TTramite values ('TR0002','Solicitar Nombramiento de la Comision Revisora y su posterior Revision')
insert into TTramite values ('TR0003','Solicitar Nombramiento de dictaminadores de Tesis y su posterior Revision')
insert into TTramite values ('TR0004','Determinacion de Fecha, Hora y Lugar para Sustentacion de Tesis')



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

insert into TRequisitoXTramite values('TR0001' ,'REQ001')
insert into TRequisitoXTramite values('TR0001' ,'REQ002')
insert into TRequisitoXTramite values('TR0001' ,'REQ003')
insert into TRequisitoXTramite values('TR0001' ,'REQ004')

insert into TRequisitoXTramite values('TR0002' ,'REQ001')
insert into TRequisitoXTramite values('TR0002' ,'REQ002')
insert into TRequisitoXTramite values('TR0002' ,'REQ003')

select * from TRequisitoXTramite where CodTramite='TR0002'

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

select c.CodTramite,c.Tipo,a.CodRequisito,TipoRequisito 
from TRequisitoXTramite a,TRequisito b,TTramite c 
where a.CodRequisito=b.CodRequisito and c.CodTramite='TR0002' and c.CodTramite=a.CodTramite 


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


