namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMorePropertiesToTrainingDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingDays", "Hour10k", c => c.Byte(nullable: false));
            AddColumn("dbo.TrainingDays", "Min10k", c => c.Byte(nullable: false));
            AddColumn("dbo.TrainingDays", "Sec10k", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainingDays", "Sec10k");
            DropColumn("dbo.TrainingDays", "Min10k");
            DropColumn("dbo.TrainingDays", "Hour10k");
        }
    }
}
