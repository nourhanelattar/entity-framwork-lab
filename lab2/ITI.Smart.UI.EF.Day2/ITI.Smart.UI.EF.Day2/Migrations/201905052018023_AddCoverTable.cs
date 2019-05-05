namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoverTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cover",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cover");
        }
    }
}
