namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNewTestCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, WeightsInKg, GenderId, DateOfBirth) VALUES ('Quang Dang', 63, 1, CAST('1992-02-25' AS DATETIME))");
            Sql("INSERT INTO Customers (Name, WeightsInKg, GenderId, DateOfBirth) VALUES ('Anh Nguyen', 59, 2, CAST('1991-11-23' AS DATETIME))");
        }
        
        public override void Down()
        {
        }
    }
}
