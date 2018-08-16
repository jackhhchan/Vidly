namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_customer_birthday_values : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = 1980-01-01 WHERE Name = 'John Smith'");
            Sql("UPDATE Customers SET Birthday = null WHERE Name = 'Mary Williams'");
        }
        
        public override void Down()
        {
        }
    }
}
