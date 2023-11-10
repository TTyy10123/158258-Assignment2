namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuisines = c.String(),
                        CuisinesId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Taste = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cuisine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cuisines", t => t.Cuisine_Id)
                .Index(t => t.Cuisine_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "Cuisine_Id", "dbo.Cuisines");
            DropIndex("dbo.Dishes", new[] { "Cuisine_Id" });
            DropTable("dbo.Dishes");
            DropTable("dbo.Cuisines");
        }
    }
}
