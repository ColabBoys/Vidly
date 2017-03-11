namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Bridesmaids', 1, GETDATE(), '01/01/2011', 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Expendables', 2, GETDATE(), '01/01/2010', 15)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Pacifier', 3, GETDATE(), '01/01/2011', 8)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Notebook', 4, GETDATE(), '01/01/2006', 7)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Anabelle', 5, GETDATE(), '01/01/2014', 4)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('John Wick', 2, GETDATE(), '01/01/2017', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
