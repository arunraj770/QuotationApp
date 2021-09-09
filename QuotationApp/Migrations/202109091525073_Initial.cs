namespace QuotationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotations",
                c => new
                    {
                        QuotationId = c.Int(nullable: false, identity: true),
                        QuotationDate = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.QuotationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quotations");
        }
    }
}
