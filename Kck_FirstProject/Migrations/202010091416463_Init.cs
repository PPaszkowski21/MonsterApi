namespace Kck_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Exp = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        MovementSpeed = c.Int(nullable: false),
                        SeeingInvisible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monsters");
        }
    }
}
