namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewClassesForTrainingDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateOfWeeks",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrainingDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistanceInKm = c.Byte(nullable: false),
                        TempoInMinKm = c.Byte(nullable: false),
                        TrainingTypeId = c.Byte(nullable: false),
                        DateOfWeekId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DateOfWeeks", t => t.DateOfWeekId, cascadeDelete: true)
                .ForeignKey("dbo.TrainingTypes", t => t.TrainingTypeId, cascadeDelete: true)
                .Index(t => t.TrainingTypeId)
                .Index(t => t.DateOfWeekId);
            
            CreateTable(
                "dbo.TrainingTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingDays", "TrainingTypeId", "dbo.TrainingTypes");
            DropForeignKey("dbo.TrainingDays", "DateOfWeekId", "dbo.DateOfWeeks");
            DropIndex("dbo.TrainingDays", new[] { "DateOfWeekId" });
            DropIndex("dbo.TrainingDays", new[] { "TrainingTypeId" });
            DropTable("dbo.TrainingTypes");
            DropTable("dbo.TrainingDays");
            DropTable("dbo.DateOfWeeks");
        }
    }
}
