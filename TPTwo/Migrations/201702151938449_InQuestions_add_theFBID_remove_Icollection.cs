namespace TPTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InQuestions_add_theFBID_remove_Icollection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ThinkingOfYous", "SurveyQuestion_Id", "dbo.questions");
            DropIndex("dbo.ThinkingOfYous", new[] { "SurveyQuestion_Id" });
            AddColumn("dbo.questions", "theFBID", c => c.String());
            DropColumn("dbo.ThinkingOfYous", "SurveyQuestion_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ThinkingOfYous", "SurveyQuestion_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.questions", "theFBID");
            CreateIndex("dbo.ThinkingOfYous", "SurveyQuestion_Id");
            AddForeignKey("dbo.ThinkingOfYous", "SurveyQuestion_Id", "dbo.questions", "Id");
        }
    }
}
