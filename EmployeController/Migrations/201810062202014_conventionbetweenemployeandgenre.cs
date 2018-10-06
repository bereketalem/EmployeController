namespace EmployeController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conventionbetweenemployeandgenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Employees", "TaskName_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "Genre_Id" });
            DropIndex("dbo.Employees", new[] { "TaskName_Id" });
            AlterColumn("dbo.Employees", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "Genre_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "TaskName_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Employees", "Genre_Id");
            CreateIndex("dbo.Employees", "TaskName_Id");
            AddForeignKey("dbo.Employees", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "TaskName_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "TaskName_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Employees", new[] { "TaskName_Id" });
            DropIndex("dbo.Employees", new[] { "Genre_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Employees", "TaskName_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Employees", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Employees", "Venue", c => c.String());
            CreateIndex("dbo.Employees", "TaskName_Id");
            CreateIndex("dbo.Employees", "Genre_Id");
            AddForeignKey("dbo.Employees", "TaskName_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Employees", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
