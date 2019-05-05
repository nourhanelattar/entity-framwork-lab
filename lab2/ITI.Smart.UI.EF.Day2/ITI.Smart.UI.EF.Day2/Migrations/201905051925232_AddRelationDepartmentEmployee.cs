namespace ITI.Smart.UI.EF.Day2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationDepartmentEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "FK_DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "FK_DepartmentId");
            AddForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department", "Dept_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "FK_DepartmentId" });
            DropColumn("dbo.Employee", "FK_DepartmentId");
        }
    }
}
