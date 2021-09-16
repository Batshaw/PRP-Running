namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateOfWeeks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (1, 'Sunday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (2, 'Monday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (3, 'Tuesday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (4, 'Wednesday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (5, 'Thursday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (6, 'Friday')");
            Sql("INSERT INTO DateOfWeeks (Id, Name) VALUES (7, 'Saturday')");
        }
        
        public override void Down()
        {
        }
    }
}
