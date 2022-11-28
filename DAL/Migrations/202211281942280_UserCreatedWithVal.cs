namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCreatedWithVal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
        }
    }
}
