namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTestCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, Age, WeightsInKg, GenderId) VALUES ('Quang Dang', 29, 63, 1)");
            Sql("INSERT INTO Customers (Name, Age, WeightsInKg, GenderId) VALUES ('Anh Nguyen', 30, 59, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
