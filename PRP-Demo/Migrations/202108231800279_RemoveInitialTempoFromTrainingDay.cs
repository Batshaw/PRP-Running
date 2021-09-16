namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveInitialTempoFromTrainingDay : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TrainingDays", "InitialPaceInMinKm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainingDays", "InitialPaceInMinKm", c => c.Time(nullable: false, precision: 7));
        }
    }
}
