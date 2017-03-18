namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('John Snow', 1, 2, 01/01/2000)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Metro Boomin', 1, 3, 01/01/2002)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Want Some', 1, 4, 01/01/2003)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('More Nigga', 0, 2, 01/01/2004)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Nguy Dep', 0, 2, 01/01/2005)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Duma May', 0, 3, 01/01/2006)");
            Sql("INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Ned Stark', 1, 1, 01/01/2007)");
        }
        
        public override void Down()
        {
        }
    }
}
