namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) Values('Comedy')");
            Sql("INSERT INTO Genres (Name) Values('Action')");
            Sql("INSERT INTO Genres (Name) Values('Family')");
            Sql("INSERT INTO Genres (Name) Values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
