namespace St.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSiteConfigSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteConfigs",
                c => new
                    {
                        SiteConfigId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        PartnerPhones = c.String(nullable: false),
                        ClientPhones = c.String(nullable: false),
                        PartnerEmails = c.String(nullable: false),
                        ClientEmails = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        PostCode = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        OpenHours = c.String(nullable: false),
                        CloseHours = c.String(nullable: false),
                        WorkingDaysString = c.String(nullable: false),
                        WorkingDays = c.String(nullable: false),
                        OfficialLicence = c.String(nullable: false),
                        OfficialInfo = c.String(nullable: false),
                        Copyright = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SiteConfigId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteConfigs");
        }
    }
}
