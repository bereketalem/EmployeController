namespace EmployeController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Genre_Id = c.Int(),
                        TaskName_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.TaskName_Id)
                .Index(t => t.Genre_Id)
                .Index(t => t.TaskName_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "TaskName_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Employees", new[] { "TaskName_Id" });
            DropIndex("dbo.Employees", new[] { "Genre_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Employees");
        }
    }
}
