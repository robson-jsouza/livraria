namespace Livraria.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        NomeAutor = c.String(nullable: false, maxLength: 100),
                        Assunto = c.String(nullable: false, maxLength: 150),
                        Editora = c.String(),
                        AnoPublicacao = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livro");
        }
    }
}
