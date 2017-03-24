# Livraria

Para executar o projeto, deve-se criar um banco de dados (SQL Server) chamado Livraria e executar o comando "update-database" para que as tabelas sejam criadas automaticamente. Pois foi utilizado migration com Entity Framework para se ter um histórico das alterações de banco.

# String de conexão

Criar uma string de conexão chamada "LivrariaContexto". Exemplo:

<add name="LivrariaConexao"
    providerName="System.Data.SqlClient"
    connectionString="Data Source=localhost\sqlexpress;Initial Catalog=Livraria;Integrated Security=SSPI;MultipleActiveResultSets=True" />
