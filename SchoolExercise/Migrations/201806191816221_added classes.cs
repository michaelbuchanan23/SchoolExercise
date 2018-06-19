namespace SchoolExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        MajorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Majors", t => t.MajorId, cascadeDelete: true)
                .Index(t => t.MajorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "MajorId", "dbo.Majors");
            DropIndex("dbo.Classes", new[] { "MajorId" });
            DropTable("dbo.Classes");
        }
    }
}
