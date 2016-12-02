 

drop table reserva;
drop table habitacio;
drop table client;
drop table hotel;

create table hotel 
(
	htl_codi decimal(10) constraint PK_HOTEL  primary key,
	htl_nom varchar(20),
	htl_poblacio varchar(100)
);

create table client
(
	cli_NIF char(9) constraint PK_client primary key ,
	cli_nom varchar(100) not null,
	cli_poblacio varchar(100)  not null,
	cli_data_naix date  not null
);

create table habitacio
(
	hab_htl_codi decimal(10),
	hab_numero decimal(10),
	hab_cli_NIF char(9),
	hab_data_entrada date,
	hab_max_persones decimal(1),
	hab_planta decimal(2),
	constraint PK_HABITACIO  primary key 
	(hab_htl_codi, hab_numero),
	constraint FK_HAB_HOT foreign key  (hab_htl_codi) references hotel(htl_codi),
	constraint FK_HAB_OCU foreign key  (hab_cli_NIF) references client(cli_NIF)
);


create table reserva (
	rsv_htl_codi decimal(10),
	rsv_hab_numero decimal(10),
	rsv_cli_NIF char(9),
	rsv_data_entrada date,
	rsv_dies_estansa decimal(3),
	constraint PK_RESERVA  primary key (rsv_htl_codi, rsv_hab_numero, rsv_data_entrada ),
	constraint FK_RSV_OCU foreign key  (rsv_cli_NIF) references client(cli_NIF),
	constraint FK_RSV_HAB foreign key  (rsv_htl_codi, rsv_hab_numero) references habitacio(hab_htl_codi, hab_numero)
);



insert into hotel values (1, 'Hotel California', 'Igualada');
insert into hotel values (2, 'Hotel Majestic', 'New York');
insert into hotel values (3,'Hotel Sakura' ,'Tokyo' );
insert into hotel values (4, 'Hotel Majestic', 'Tokyo');

insert into client values ('11111111H', 'Pere Botero', 'New York', '1945-12-10');
insert into client values ('22222222N', 'Imma Pastor', 'Salamanca',  '1980-02-22');
insert into client values ('33333333K', 'Pere Mas', 'Igualada',  '1950-11-19');
insert into client values ('44444444N', 'Joan Carles Saler', 'Madrid',  '1965-08-02');
insert into client values ('55555555L', 'Maria Gutierrez', 'Tokyo', '1954-05-04');
insert into client values ('66666666T', 'Ana Maria Simó', 'Barcelona',  '1923-08-09');

insert into habitacio values (1,101,NULL, NULL, 2, 1);
insert into habitacio values (1,102,NULL, NULL, 2, 1);
insert into habitacio values (1,103,NULL, NULL, 2, 1);
insert into habitacio values (1,201,NULL, NULL, 3, 2);
insert into habitacio values (1,	202,NULL, NULL, 3, 2);
insert into habitacio values (1,203,NULL, NULL, 4, 2);
insert into habitacio values (1,301,NULL, NULL, 3, 3);
insert into habitacio values (1,302,NULL, NULL, 3, 3);
insert into habitacio values (1,303,NULL, NULL, 3, 3);
insert into habitacio values (1,304,NULL, NULL, 3, 3);
insert into habitacio values (1,305,NULL, NULL, 3, 3);

insert into habitacio values (2,101,NULL, NULL, 2, 1);
insert into habitacio values (2,102,NULL, NULL, 2, 1);
insert into habitacio values (2,103,NULL, NULL, 2, 1);
insert into habitacio values (2,201,'22222222N', 	date('now','-3 days') , 4, 2);
insert into habitacio values (2,202,NULL, NULL, 4, 2);
insert into habitacio values (2,203,'55555555L', date('now','-10 days'), 4, 2);

insert into habitacio values (3,101,'11111111H', date('now'), 2, 1);
insert into habitacio values (3,102,'33333333K', date('now','-2 days'), 2, 1);
insert into habitacio values (3,103,'44444444N', date('now','-1 days'), 2, 1);
insert into habitacio values (3,104,'44444444N', date('now','-1 days'), 2, 1);
insert into habitacio values (3,201,NULL, NULL, 3, 2);
insert into habitacio values (3,202,NULL, NULL, 3, 2);
insert into habitacio values (3,203,NULL, NULL, 4, 2);
insert into habitacio values (3,301,NULL, NULL, 3, 3);
insert into habitacio values (3,302,NULL, NULL, 3, 3);
insert into habitacio values (3,303,NULL, NULL, 3, 3);

insert into reserva values ( 2, 202, '66666666T', date('now','+20 days'), 4);
insert into reserva values ( 3, 103, '44444444N', date('now','+50 days'), 10);
insert into reserva values ( 3, 303, '44444444N', date('now','+25 days'), 2);
insert into reserva values ( 1, 301, '22222222N', date('now','+200 days'), 3);
insert into reserva values ( 1, 301, '22222222N', date('now','+100 days'), 2);
insert into reserva values ( 1, 301, '22222222N', date('now','+50 days'), 2);
insert into reserva values ( 1, 301, '22222222N', date('now','+25 days'), 2);

 
 