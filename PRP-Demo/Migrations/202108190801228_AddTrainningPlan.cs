namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainningPlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainingPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Finished = c.Boolean(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingPlans", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.TrainingPlans", new[] { "Customer_Id" });
            DropTable("dbo.TrainingPlans");
        }
    }
}
