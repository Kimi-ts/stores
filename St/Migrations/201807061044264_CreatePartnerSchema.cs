namespace St.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePartnerSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        PartnerId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Notes = c.String(),
                        Phone = c.String(),
                        SiteUrl = c.String(),
                        Owner_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PartnerId)
                .ForeignKey("dbo.AspNetUsers", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partners", "Owner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Partners", new[] { "Owner_Id" });
            DropTable("dbo.Partners");
        }
    }
}
