namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_movies_hopefully_final : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenresId) VALUES ('Hangover', 5)");
            Sql("INSERT INTO Movies (Name, GenresId) VALUES ('Die Hard', 1)");
            Sql("INSERT INTO Movies (Name, GenresId) VALUES ('The Terminator', 1)");
            Sql("INSERT INTO Movies (Name, GenresId) VALUES ('Toy Story', 3)");
            Sql("INSERT INTO Movies (Name, GenresId) VALUES ('Titanic', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
