namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTempoInMinKmToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainingDays", "TempoInMinKm", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingDays", "TempoInMinKm", c => c.Byte(nullable: false));
        }
    }
}
