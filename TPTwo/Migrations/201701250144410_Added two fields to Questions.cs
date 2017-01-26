namespace TPTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedtwofieldstoQuestions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.questions", "NewText", c => c.String());
            AddColumn("dbo.questions", "FBProfileUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.questions", "FBProfileUrl");
            DropColumn("dbo.questions", "NewText");
        }
    }
}
