namespace SchoolExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEnrolled : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrolleds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.StudentId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrolleds", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrolleds", "ClassId", "dbo.Classes");
            DropIndex("dbo.Enrolleds", new[] { "ClassId" });
            DropIndex("dbo.Enrolleds", new[] { "StudentId" });
            DropTable("dbo.Enrolleds");
        }
    }
}
