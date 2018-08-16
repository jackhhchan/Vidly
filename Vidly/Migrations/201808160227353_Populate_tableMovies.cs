namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_tableMovies_Annotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: true));
        }

        public override void Down()
        {
        }
    }
}
