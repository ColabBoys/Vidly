namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateNumberInStock : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberInStock = 100");
            Sql("UPDATE Movies SET NumberAvailable = 100");

        }
        
        public override void Down()
        {
        }
    }
}
