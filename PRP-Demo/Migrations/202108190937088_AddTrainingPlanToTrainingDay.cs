namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainingPlanToTrainingDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingDays", "TrainingPlan_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TrainingDays", "TrainingPlan_Id");
            AddForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans");
            DropIndex("dbo.TrainingDays", new[] { "TrainingPlan_Id" });
            DropColumn("dbo.TrainingDays", "TrainingPlan_Id");
        }
    }
}
