namespace EASHLWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_post_model : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Posts");
            RenameColumn("dbo.Posts", "PostID", "ID");
            AddColumn("dbo.Posts", "Image", c => c.String());
            AddColumn("dbo.Posts", "Youtube", c => c.String());
            AddPrimaryKey("dbo.Posts", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Posts");
            DropColumn("dbo.Posts", "Youtube");
            DropColumn("dbo.Posts", "Image");
            DropColumn("dbo.Posts", "ID");
            AddPrimaryKey("dbo.Posts", "PostID");
        }
    }
}
