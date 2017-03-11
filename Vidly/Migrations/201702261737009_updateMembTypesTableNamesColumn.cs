namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembTypesTableNamesColumn : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes SET Name = 'Pay as You Go' WHERE ID = 1");
            Sql("update MembershipTypes SET Name = 'Monthly' WHERE ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
