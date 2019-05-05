namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Dept_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Dept_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Department");
        }
    }
}
