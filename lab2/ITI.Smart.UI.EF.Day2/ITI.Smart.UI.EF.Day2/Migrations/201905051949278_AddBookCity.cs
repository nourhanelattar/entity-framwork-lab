namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpBooks", "Fk_BookId", "dbo.Books");
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "Id");
            CreateIndex("dbo.Books", "Id");
            AddForeignKey("dbo.Books", "Id", "dbo.cities", "Id");
            AddForeignKey("dbo.EmpBooks", "Fk_BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpBooks", "Fk_BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "Id", "dbo.cities");
            DropIndex("dbo.Books", new[] { "Id" });
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Books", "Id");
            AddForeignKey("dbo.EmpBooks", "Fk_BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
