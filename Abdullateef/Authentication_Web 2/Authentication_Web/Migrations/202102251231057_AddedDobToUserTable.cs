namespace Authentication_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDobToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Dob", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Dob");
        }
    }
}
