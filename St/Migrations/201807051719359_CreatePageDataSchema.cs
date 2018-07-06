namespace St.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePageDataSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PageDatas",
                c => new
                    {
                        PageDataId = c.String(nullable: false, maxLength: 128),
                        PageName = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        MetaDescription = c.String(nullable: false),
                        MetaKeywords = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PageDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PageDatas");
        }
    }
}
