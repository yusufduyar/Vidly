namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomersBirthDates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate=CAST('1989-06-28' AS DATETIME) WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
