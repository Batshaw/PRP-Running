namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastRaceDistanceToTrainingDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingDays", "LastRaceDistance", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainingDays", "LastRaceDistance");
        }
    }
}
