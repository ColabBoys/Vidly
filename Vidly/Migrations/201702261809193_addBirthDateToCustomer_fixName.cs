namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthDateToCustomer_fixName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Bithdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Bithdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
