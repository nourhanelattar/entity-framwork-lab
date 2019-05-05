namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCover : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.cover");
            AlterColumn("dbo.cover", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.cover", "Id");
            CreateIndex("dbo.cover", "Id");
            AddForeignKey("dbo.cover", "Id", "dbo.Books", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cover", "Id", "dbo.Books");
            DropIndex("dbo.cover", new[] { "Id" });
            DropPrimaryKey("dbo.cover");
            AlterColumn("dbo.cover", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.cover", "Id");
        }
    }
}
