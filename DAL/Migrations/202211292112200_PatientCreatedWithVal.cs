namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCreatedWithVal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        RegisteredAt = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(maxLength: 15),
                        BloodGroup = c.String(nullable: false, maxLength: 3),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "UserId", "dbo.Users");
            DropIndex("dbo.Patients", new[] { "UserId" });
            DropTable("dbo.Patients");
        }
    }
}
