namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropproduto : DbMigration
    {
        public override void Up()
        {
            DropTable("Produto");
        }
        
        public override void Down()
        {
            
        }
    }
}
