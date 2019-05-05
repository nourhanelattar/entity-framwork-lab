namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationCityUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usercities",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        city_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.user_Id, t.city_Id })
                .ForeignKey("dbo.users", t => t.user_Id, cascadeDelete: true)
                .ForeignKey("dbo.cities", t => t.city_Id, cascadeDelete: true)
                .Index(t => t.user_Id)
                .Index(t => t.city_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usercities", "city_Id", "dbo.cities");
            DropForeignKey("dbo.usercities", "user_Id", "dbo.users");
            DropIndex("dbo.usercities", new[] { "city_Id" });
            DropIndex("dbo.usercities", new[] { "user_Id" });
            DropTable("dbo.usercities");
        }
    }
}
