namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCustomerInTrainingPlanUnrequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TrainingPlans", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.TrainingPlans", new[] { "Customer_Id" });
            AlterColumn("dbo.TrainingPlans", "Customer_Id", c => c.Int());
            CreateIndex("dbo.TrainingPlans", "Customer_Id");
            AddForeignKey("dbo.TrainingPlans", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingPlans", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.TrainingPlans", new[] { "Customer_Id" });
            AlterColumn("dbo.TrainingPlans", "Customer_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TrainingPlans", "Customer_Id");
            AddForeignKey("dbo.TrainingPlans", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
