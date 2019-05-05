namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForiegnKeyToCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.cities", "country_Id", "dbo.countries");
            DropIndex("dbo.cities", new[] { "country_Id" });
            RenameColumn(table: "dbo.cities", name: "country_Id", newName: "countryId");
            AlterColumn("dbo.cities", "countryId", c => c.Int(nullable: false));
            CreateIndex("dbo.cities", "countryId");
            AddForeignKey("dbo.cities", "countryId", "dbo.countries", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cities", "countryId", "dbo.countries");
            DropIndex("dbo.cities", new[] { "countryId" });
            AlterColumn("dbo.cities", "countryId", c => c.Int());
            RenameColumn(table: "dbo.cities", name: "countryId", newName: "country_Id");
            CreateIndex("dbo.cities", "country_Id");
            AddForeignKey("dbo.cities", "country_Id", "dbo.countries", "Id");
        }
    }
}
