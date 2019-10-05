exec sp_executesql N'SELECT 
    [Extent1].[Id] AS [Id], 
    [Extent1].[Nome] AS [Nome], 
    [Extent1].[CpfCnpj] AS [CpfCnpj], 
    [Extent1].[DataCadastro] AS [DataCadastro], 
    [Extent1].[LimiteCredito] AS [LimiteCredito]
    FROM [dbo].[Clientes] AS [Extent1]
    WHERE [Extent1].[Nome] LIKE @p__linq__0 ESCAPE N''~''',N'@p__linq__0 nvarchar(4000)',@p__linq__0=N'Marcel%'