namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenders : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (Id, Name) VALUES (1, 'Male')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (2, 'Female')");
        }
        
        public override void Down()
        {
        }
    }
}
