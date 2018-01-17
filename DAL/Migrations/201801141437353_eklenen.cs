namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eklenen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yetkis",
                c => new
                    {
                        yetkiID = c.Int(nullable: false, identity: true),
                        yetki = c.String(),
                    })
                .PrimaryKey(t => t.yetkiID);
            
            AddColumn("dbo.Makales", "EklenmeTarihi", c => c.DateTime(nullable: false));
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.yetki",
                c => new
                    {
                        YetkiID = c.Int(nullable: false),
                        yetki = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.YetkiID);
            
            DropColumn("dbo.Makales", "EklenmeTarihi");
           
        }
    }
}
