namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationCityCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cities", "country_Id", c => c.Int());
            CreateIndex("dbo.cities", "country_Id");
            AddForeignKey("dbo.cities", "country_Id", "dbo.countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cities", "country_Id", "dbo.countries");
            DropIndex("dbo.cities", new[] { "country_Id" });
            DropColumn("dbo.cities", "country_Id");
        }
    }
}
