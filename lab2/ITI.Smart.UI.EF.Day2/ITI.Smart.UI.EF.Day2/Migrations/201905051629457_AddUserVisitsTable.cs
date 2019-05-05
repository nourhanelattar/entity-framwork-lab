namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserVisitsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.usercities", "user_Id", "dbo.users");
            DropForeignKey("dbo.usercities", "city_Id", "dbo.cities");
            DropIndex("dbo.usercities", new[] { "user_Id" });
            DropIndex("dbo.usercities", new[] { "city_Id" });
            CreateTable(
                "dbo.uservisits",
                c => new
                    {
                        Fk_userId = c.Int(nullable: false),
                        Fk_cityId = c.Int(nullable: false),
                        when = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Fk_userId, t.Fk_cityId })
                .ForeignKey("dbo.cities", t => t.Fk_cityId, cascadeDelete: true)
                .ForeignKey("dbo.users", t => t.Fk_userId, cascadeDelete: true)
                .Index(t => t.Fk_userId)
                .Index(t => t.Fk_cityId);
            
            DropTable("dbo.usercities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.usercities",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        city_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.user_Id, t.city_Id });
            
            DropForeignKey("dbo.uservisits", "Fk_userId", "dbo.users");
            DropForeignKey("dbo.uservisits", "Fk_cityId", "dbo.cities");
            DropIndex("dbo.uservisits", new[] { "Fk_cityId" });
            DropIndex("dbo.uservisits", new[] { "Fk_userId" });
            DropTable("dbo.uservisits");
            CreateIndex("dbo.usercities", "city_Id");
            CreateIndex("dbo.usercities", "user_Id");
            AddForeignKey("dbo.usercities", "city_Id", "dbo.cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.usercities", "user_Id", "dbo.users", "Id", cascadeDelete: true);
        }
    }
}
