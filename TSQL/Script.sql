CREATE DATABASE SQLSAT906_Demo01
GO
USE SQLSAT906_Demo01
GO
DROP TABLE IF EXISTS dbo.Clientes
GO
CREATE TABLE dbo.Clientes(
	Id INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(100),
	CpfCnpj VARCHAR(14),
	DataCadastro DATE,
	LimiteCredito DECIMAL(10,2)
)
GO
INSERT INTO dbo.Clientes(Nome,CpfCnpj,DataCadastro,LimiteCredito)
SELECT FirstName,'11111111111111',GETDATE(),0 FROM AdventureWorks2017.Person.Person
GO 5

CREATE INDEX idx_cliente_nome ON Clientes(Nome)
GO

exec sp_executesql N'SELECT 
    [Extent1].[Id] AS [Id], 
    [Extent1].[Nome] AS [Nome], 
    [Extent1].[CpfCnpj] AS [CpfCnpj], 
    [Extent1].[DataCadastro] AS [DataCadastro], 
    [Extent1].[LimiteCredito] AS [LimiteCredito]
    FROM [dbo].[Clientes] AS [Extent1]
    WHERE [Extent1].[Nome] LIKE @p__linq__0 ESCAPE N''~''',N'@p__linq__0 nvarchar(4000)',@p__linq__0=N'Marcel%'


exec sp_executesql N'SELECT 
    [Extent1].[Id] AS [Id], 
    [Extent1].[Nome] AS [Nome], 
    [Extent1].[CpfCnpj] AS [CpfCnpj], 
    [Extent1].[DataCadastro] AS [DataCadastro], 
    [Extent1].[LimiteCredito] AS [LimiteCredito]
    FROM [dbo].[Clientes] AS [Extent1]
    WHERE [Extent1].[Nome] LIKE @p__linq__0 ESCAPE ''~''',N'@p__linq__0 varchar(8000)',@p__linq__0='Marcel%'