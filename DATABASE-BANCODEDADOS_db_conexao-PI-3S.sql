--ABRIR O SQL SERVER MANAGEMENTE STUDIO E CRIAR A DATABASE DE NOME db_conexao

/*1.Nome Banco de dados :db_conexao

2.Realizar a criacao das tabelas
- marca 
- produto
- estoque
- vendas 
- registro_venda
*/

==========COMANDOS DE CRIACAO DAS TABELAS========

--TABELA MARCA 

	CREATE TABLE marca(
		idmarca int identity,
		cod_marca smallint ,
		marca varchar (30) ,
		primary key (idmarca,cod_marca)
	)
	GO



--TABELA PRODUTO

CREATE TABLE produto(
		idproduto int identity,
		nome_produto varchar (30) ,
		cod_item int ,
		fk_pro_marca smallint
		valor_unitario varchar(10)
	)
GO

--TABELA ESTOQUE

CREATE TABLE estoque(
	idestoque int identity,
	fk_est_cod_item int not null ,
	fk_est_marca smallint not null,
    qtde_estoque int,
	primary  key (idestoque,fk_est_cod_item,fk_est_marca)
)
GO


--TABELA VENDAS


CREATE TABLE vendas (
	idvendas int IDENTITY,
	fk_ven_cod_item int ,
	qtde_vendas smallint,
	data_venda varchar (10),
	primary key (idvendas,fk_ven_cod_item)
)
GO

--TABELA REGISTRO_VENDA

CREATE TABLE registro_venda (
		fk_cod_item int,
		qtde int,
		valor_compra DECIMAL (10,2),
		nf varchar,
		data varchar (10)
)
GO




