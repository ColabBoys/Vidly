namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateNumberInStock2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberInStock = 20");
            Sql("UPDATE Movies SET NumberAvailable = 20");
        }
        
        public override void Down()
        {
        }
    }
}
