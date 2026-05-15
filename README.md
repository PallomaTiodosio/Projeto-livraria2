Dupla: Lavinia e Palloma
Banco de dados:
create database bdEmprestimo;
use bdEmprestimo;

create table tbUsuario(
codUsu int primary key auto_increment,
nomeUsu varchar(50)
);
create table tbLivro(
codLivro int primary key auto_increment,
nomeLivro varchar(50),
imagemLivro varchar(255)
);
create table tbEmprestimo(
codEmp int primary key auto_increment,
dataEmp varchar(20),
dataDev varchar(20),
codUsu int references tbUsuario(codUsu)
);
create table itensEmp(
codItem int primary key auto_increment,
codEmp int references tbEmprestimo(codEmp),
codLivro int references tbLivro(codLivro)
);
create table Categoria(
Nome varchar(100) not null,
Id int primary key
);
select * from itensEmp;
insert into tbUsuario values(default, 'Nilson'), (default, 'Bruno');
select * from tbUsuario;
select * from tbLivro;

select * from tbEmprestimo;
select * from itensEmp;
/*
create or replace view ViewTotal as
select 
u.codUsu,
l.nomeLivro,
l.ImagemLivro,
e.dataEmp,
e.dataDev,
from tbUsuario u
inner join tbLivro l

*/
