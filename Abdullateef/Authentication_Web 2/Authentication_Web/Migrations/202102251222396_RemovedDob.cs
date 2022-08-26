namespace Authentication_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDob : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Dob");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Dob", c => c.DateTime(nullable: false));
        }
    }
}
