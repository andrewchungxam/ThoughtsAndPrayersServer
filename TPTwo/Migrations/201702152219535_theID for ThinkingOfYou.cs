namespace TPTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class theIDforThinkingOfYou : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ThinkingOfYous", "theId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ThinkingOfYous", "theId");
        }
    }
}
