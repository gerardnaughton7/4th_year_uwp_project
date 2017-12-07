namespace GPWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pub = c.String(),
                        Name = c.String(),
                        YourReview = c.String(),
                        BevRating = c.Int(nullable: false),
                        AtmosRating = c.Int(nullable: false),
                        CraicRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
