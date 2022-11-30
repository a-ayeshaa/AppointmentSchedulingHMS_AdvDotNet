namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorCreatedWithVal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Specialization = c.String(nullable: false, maxLength: 100),
                        Degree = c.String(nullable: false, maxLength: 100),
                        VisitingDays = c.String(nullable: false, maxLength: 100),
                        Appointment_Fees = c.Single(nullable: false),
                        Net_Earnings = c.Single(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
