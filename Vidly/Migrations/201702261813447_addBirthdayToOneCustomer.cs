namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdayToOneCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET Birthdate = '1/1/1989' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
