namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eklenen4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "TotalRate", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makales", "TotalRate");
        }
    }
}
