namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInitialTempoToTrainingDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingDays", "InitialTempoInMinKm", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainingDays", "InitialTempoInMinKm");
        }
    }
}
