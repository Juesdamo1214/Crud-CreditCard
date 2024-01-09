namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CreditCards");
            AddPrimaryKey("dbo.CreditCards", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CreditCards");
            AddPrimaryKey("dbo.CreditCards", "CardNumber");
        }
    }
}
