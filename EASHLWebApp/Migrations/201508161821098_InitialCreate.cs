namespace EASHLWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        Gamertag = c.String(),
                        Name = c.String(),
                        City = c.String(),
                        Number = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Type = c.String(),
                        Strength = c.String(),
                        Style = c.String(),
                        Position = c.String(),
                        Eaid = c.String(),
                    })
                .PrimaryKey(t => t.PlayerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
