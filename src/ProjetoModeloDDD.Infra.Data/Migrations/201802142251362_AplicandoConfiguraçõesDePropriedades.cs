namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AplicandoConfiguraçõesDePropriedades : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clientes");
            AddColumn("dbo.Clientes", "ClienteId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddPrimaryKey("dbo.Clientes", "ClienteId");
            DropColumn("dbo.Clientes", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "ClientId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "ClienteId");
            AddPrimaryKey("dbo.Clientes", "ClientId");
        }
    }
}
