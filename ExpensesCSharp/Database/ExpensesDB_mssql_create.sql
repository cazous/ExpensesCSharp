CREATE TABLE [Expense] (
	id int NOT NULL,
	data datetime NOT NULL,
	descricao varchar(1000) NOT NULL,
	pagamento varchar(30) NOT NULL,
	valor decimal(10,2) NOT NULL,
  CONSTRAINT [PK_EXPENSE] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

