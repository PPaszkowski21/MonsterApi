namespace Kck_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Monsters", "ImageLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Monsters", "ImageLink");
        }
    }
}
