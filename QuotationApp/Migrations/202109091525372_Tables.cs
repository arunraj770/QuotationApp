namespace QuotationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DetailName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuotationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuotationId = c.Int(nullable: false),
                        Detail1 = c.Int(nullable: false),
                        Detail2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuotationDetails");
            DropTable("dbo.ItemDetails");
        }
    }
}
