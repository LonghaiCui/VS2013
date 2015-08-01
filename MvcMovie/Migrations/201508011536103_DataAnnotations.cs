namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    //Code First ensures that the validation rules you specify on a model class are  enforced before the application saves changes in the database.
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.String());
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
