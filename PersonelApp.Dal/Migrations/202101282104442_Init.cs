namespace PersonelApp.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EklenmeTarihi = c.DateTime(),
                        GüncellenmeTarihi = c.DateTime(),
                        SilinmeTarihi = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        EklenmeTarihi = c.DateTime(),
                        GüncellenmeTarihi = c.DateTime(),
                        SilinmeTarihi = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Personels", new[] { "DepartmentId" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departments");
        }
    }
}
