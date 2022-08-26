namespace Authentication_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeLastNameAndFirstNameStringLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String());
        }
    }
}
