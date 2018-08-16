namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_customers_john_mary : DbMigration
    {
        public override void Up()
        {
            Sql( "INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('John Smith', 1, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNEwsLetter, MembershipTypeId) VALUES ('Mary Williams', 1, 1)");

        }
        
        public override void Down()
        {
        }
    }
}
