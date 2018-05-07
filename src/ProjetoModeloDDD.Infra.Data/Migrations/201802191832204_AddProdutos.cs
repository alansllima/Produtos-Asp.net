namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProdutos : DbMigration
    {
        public override void Up()
        {
           // DropPrimaryKey("dbo.Clientes");
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
          //  AddColumn("dbo.Clientes", "ClienteId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
          //  AddPrimaryKey("dbo.Clientes", "ClienteId");
          //  DropColumn("dbo.Clientes", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "ClientId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Produtos", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Produtos", new[] { "ClienteId" });
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "ClienteId");
            DropTable("dbo.Produtos");
            AddPrimaryKey("dbo.Clientes", "ClientId");
        }
    }
}
