namespace TPTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtext_fbprofile_createdatestring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.questions", "NewText", c => c.String());
            AddColumn("dbo.questions", "FBProfileUrl", c => c.String());
            AddColumn("dbo.questions", "CreateDateString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.questions", "CreateDateString");
            DropColumn("dbo.questions", "FBProfileUrl");
            DropColumn("dbo.questions", "NewText");
        }
    }
}
