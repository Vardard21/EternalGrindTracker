namespace EternalGrindTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBCreation1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eternals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stage = c.String(),
                        Element = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Elements");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Eternals");
        }
    }
}
