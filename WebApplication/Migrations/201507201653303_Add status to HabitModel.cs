namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddstatustoHabitModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Habits", newName: "HabitModels");
            AddColumn("dbo.HabitModels", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HabitModels", "Status");
            RenameTable(name: "dbo.HabitModels", newName: "Habits");
        }
    }
}
