namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaintenanceClassOfIssues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaintenanceClassOfIssues");
        }
    }
}
