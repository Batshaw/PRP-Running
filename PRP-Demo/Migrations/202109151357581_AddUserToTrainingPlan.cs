namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToTrainingPlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingPlans", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.TrainingPlans", "User_Id");
            AddForeignKey("dbo.TrainingPlans", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingPlans", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TrainingPlans", new[] { "User_Id" });
            DropColumn("dbo.TrainingPlans", "User_Id");
        }
    }
}
