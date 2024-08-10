namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Student_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student_Registration",
                c => new
                    {
                        Student_Registration_ID = c.Int(nullable: false, identity: true),
                        Student_ID = c.Int(nullable: false),
                        Registration_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Student_Registration_ID)
                .ForeignKey("dbo.Registrations", t => t.Registration_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .Index(t => t.Student_ID)
                .Index(t => t.Registration_ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Student_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student_Registration", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Student_Registration", "Registration_ID", "dbo.Registrations");
            DropIndex("dbo.Student_Registration", new[] { "Registration_ID" });
            DropIndex("dbo.Student_Registration", new[] { "Student_ID" });
            DropTable("dbo.Students");
            DropTable("dbo.Student_Registration");
        }
    }
}
