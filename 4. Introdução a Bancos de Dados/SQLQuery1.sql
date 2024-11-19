
SELECT * FROM Clientes -- Seleciona tudo da tabela do banco de dados

WHERE Nome= 'Adam' AND Sobrenome = 'Reynolds' -- Traz apenas Adam Reynolds
ORDER By Nome, Sobrenome


ORDER BY Nome, Sobrenome DESC -- Chama os nomes na ordem descrecente

WHERE Nome LIKE 'G%' --- começa com a letra g
ORDER BY Nome, Sobrenome


WHERE Nome LIKE '%G%' --- todos que começam com g no nome
ORDER BY Nome, Sobrenome

INSERT INTO Clientes (Nome,Sobrenome,Email,AceitaComunicados, DataCadastro) --Adicionar alguem
VALUES('Leonardos','Buta', 'email@email.com',1,GETDATE())


INSERT INTO Clientes  VALUES('Leonardo','Buta', 'email@email.com', 1, GETDATE())
--SELECT * FROM Clientes
----BREGIN TRAN --- codigo faz com que tenho um backup do programa paos rodas isso
----ROLLBACK

--INSERT INTO Clientes(Sobrenome, Nome, Email,AceitaComunicados,DataCadastro)
--VALUES ('Buta','Leonardo', 'email@email.com', 1, GETDATE())

--SELECT * FROM Clientes WHERE Nome = 'Rob'

--UPDATE Clientes
--SET Email = 'emaildatualizado@email.com',
--	AceitaComunicados = 0
--WHERE Id = 4


--Deletar o registro
-- DELETE Clientes
--WHERE Id = 4 --> Delete sem o where eu apago tudo, cuidado




--CREATE TABLE Produtos (
--	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, --Preenchimento obrigatório
--	Nome varchar(255) NOT NULL, -- String de até 255 de casas
--	Cor varchar(50) NULL,
--	Preço decimal(13,2) NOT NULL, --(Qt de numero,Casas decimais)
--	Tamanho varchar(5) NULL, -- 
--	Genero char(1) NULL--String DE 1 casa
--)


--DROP TABLE IF EXISTS dbo.Produtos -- Exclui a tabela produtos


--Manipulando dados

--Built-int fuctions

SELECT * FROM Produtos

--Contagem
SELECT COUNT(*) QuantidadeProdutos FROM Produtos -- todas as linhas do meu banco de dados

SELECT COUNT(*) QuantidadeProdutosM FROM Produtos WHERE Tamanho ='M'

SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'  -- Soma a quantidade de uma coluna


SELECT Max(Preco) ProdutoMaisCaro FROM Produtos -- Valor máximo da  coluna
SELECT Max(Preco) ProdutoMaisCaroM FROM Produtos WHERE Tamanho = 'M'

SELECT Min(Preco) ProdutoMaisBarato FROM Produtos

SELECT AVG(Preco) MediaDosProdutos FROM Produtos


--Concatenando colunas
SELECT 
	Nome +', Cor: '+ Cor+ '-' + Genero
ColunaNova FROM Produtos

--Upper e Lower

SELECT 
	Nome +', Cor: '+ Cor+ '-' + Genero ColunaNova,
	UPPER(Nome) Nome,
	LOWER(Cor) Cor
FROM Produtos

--Criando nova coluna
SELECT * FROM Produtos

ALTER TABLE Produtos -- Adicionando coluna
ADD DataCadastro DATETIME2

ALTER TABLE Produtos -- Removendo coluna
DROP COLUMN DataCadastro


UPDATE Produtos SET DataCadastro = GETDATE()


--FORMATANDO UMA DATA
SELECT
FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') DataFormatada -- HH24 hh12
FROM Produtos

--Entendendo o GROUP BY
--Agrupando dados iguais e contar quantos tenho
SELECT
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC
-- M - 7
-- G - 10




--Primary Key e Foreign Key

-- Primary Key: Chave única que identifica cada registro na tabela
-- Foreign Key: Chave que identifica um registro existente em outra tabela




--CREATE TABLE Enderecos (
--	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL, --Preenchimento obrigatório
--	IdCliente int NULL, -- inteiro
--	Rua varchar(255) NULL,
--	Bairro varchar(255) NULL, 
--	Cidade varchar(255) NULL, 
--	Estado char(2) NULL--String DE 2 casa

--	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente) --Uso Foreign key
--	REFERENCES Clientes(Id) --Coluna a qual o IdCliente de endereço vai refencia da tabela cliente
--)

SELECT * FROM Enderecos
SELECT * FROM Clientes

INSERT INTO Enderecos VALUES(4, 'Rua Teste','Bairro Teste', 'Cidade Teste', 'SP') -- Adicionou o endereço para o cliente de id 4 na tabela cliente


SELECT * FROM Clientes WHERE Id = 4
SELECT * FROM Enderecos WHERE IdCliente = 4


-- Realizando um INNER JOIN
--No exemplo anterior usamos 2 selects para levantar as informações do cliente e endereço, no join eu consigo trazer ambas juntas de uma vez
--Veja o exemplo abaixo:

SELECT
*
FROM
	Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4

--ou

SELECT
--Clientes.Nome,
--Clientes.Sobrenome,
--Clientes.Email,
--Enderecos.Rua,
--Enderecos.Bairro,
--Enderecos.Cidade,
--Enderecos.Estado

C.Nome,
C.Sobrenome,
C.Email,
E.Rua,
E.Bairro,
E.Cidade,
E.Estado
FROM
	Clientes C
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 4