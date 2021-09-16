namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTrainingDays : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TrainingTypes (Id, Name) VALUES (1, 'Easy')");
            Sql("INSERT INTO TrainingTypes (Id, Name) VALUES (2, 'Speed')");
            Sql("INSERT INTO TrainingTypes (Id, Name) VALUES (3, 'Threshold')");
            Sql("INSERT INTO TrainingTypes (Id, Name) VALUES (4, 'Long')");
        }
        
        public override void Down()
        {
        }
    }
}
