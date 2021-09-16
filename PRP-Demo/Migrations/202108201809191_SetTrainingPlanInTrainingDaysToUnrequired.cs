namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetTrainingPlanInTrainingDaysToUnrequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans");
            DropIndex("dbo.TrainingDays", new[] { "TrainingPlan_Id" });
            AlterColumn("dbo.TrainingDays", "TrainingPlan_Id", c => c.Int());
            CreateIndex("dbo.TrainingDays", "TrainingPlan_Id");
            AddForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans");
            DropIndex("dbo.TrainingDays", new[] { "TrainingPlan_Id" });
            AlterColumn("dbo.TrainingDays", "TrainingPlan_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TrainingDays", "TrainingPlan_Id");
            AddForeignKey("dbo.TrainingDays", "TrainingPlan_Id", "dbo.TrainingPlans", "Id", cascadeDelete: true);
        }
    }
}
