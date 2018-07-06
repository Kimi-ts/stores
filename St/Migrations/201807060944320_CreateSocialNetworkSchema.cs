namespace St.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSocialNetworkSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialNetworkItems",
                c => new
                    {
                        SocialNetworkItemId = c.String(nullable: false, maxLength: 128),
                        Type = c.String(nullable: false),
                        Url = c.String(nullable: false),
                        IconClass = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SocialNetworkItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialNetworkItems");
        }
    }
}
