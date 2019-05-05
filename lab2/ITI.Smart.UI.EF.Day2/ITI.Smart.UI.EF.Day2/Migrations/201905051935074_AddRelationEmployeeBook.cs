namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationEmployeeBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmpBooks",
                c => new
                    {
                        Fk_EmployeeId = c.Int(nullable: false),
                        Fk_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Fk_EmployeeId, t.Fk_BookId })
                .ForeignKey("dbo.Employee", t => t.Fk_EmployeeId)
                .ForeignKey("dbo.Books", t => t.Fk_BookId)
                .Index(t => t.Fk_EmployeeId)
                .Index(t => t.Fk_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpBooks", "Fk_BookId", "dbo.Books");
            DropForeignKey("dbo.EmpBooks", "Fk_EmployeeId", "dbo.Employee");
            DropIndex("dbo.EmpBooks", new[] { "Fk_BookId" });
            DropIndex("dbo.EmpBooks", new[] { "Fk_EmployeeId" });
            DropTable("dbo.EmpBooks");
            DropTable("dbo.Books");
        }
    }
}
