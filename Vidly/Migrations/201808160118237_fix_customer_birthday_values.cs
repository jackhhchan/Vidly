namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_customer_birthday_values : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = 1/1/1980 WHERE Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
