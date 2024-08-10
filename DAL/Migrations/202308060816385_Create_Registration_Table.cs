namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Registration_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Registration_ID = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                        Semester_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Registration_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
