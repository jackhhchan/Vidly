namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_customer_mary_membershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET MembershipTypeId = 2 WHERE Name = 'Mary Williams'");
        }
        
        public override void Down()
        {
        }
    }
}
