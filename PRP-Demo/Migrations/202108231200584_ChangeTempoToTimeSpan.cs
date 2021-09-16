namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTempoToTimeSpan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingDays", "InitialPaceInMinKm", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.TrainingDays", "InitialTempoInMinKm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainingDays", "InitialTempoInMinKm", c => c.Byte(nullable: false));
            DropColumn("dbo.TrainingDays", "InitialPaceInMinKm");
        }
    }
}
