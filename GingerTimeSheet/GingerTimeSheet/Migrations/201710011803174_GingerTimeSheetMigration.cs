namespace GingerTimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GingerTimeSheetMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Status = c.Short(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Assignee_Id = c.Int(),
                        Client_Id = c.Int(),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Assignee_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.AccountDetails", t => t.Parent_Id)
                .Index(t => t.Assignee_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SurName = c.String(),
                        Designation = c.String(),
                        Status = c.Short(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Short(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountDetails", "Parent_Id", "dbo.AccountDetails");
            DropForeignKey("dbo.AccountDetails", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.AccountDetails", "Assignee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Parent_Id", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Parent_Id" });
            DropIndex("dbo.AccountDetails", new[] { "Parent_Id" });
            DropIndex("dbo.AccountDetails", new[] { "Client_Id" });
            DropIndex("dbo.AccountDetails", new[] { "Assignee_Id" });
            DropTable("dbo.Clients");
            DropTable("dbo.Employees");
            DropTable("dbo.AccountDetails");
        }
    }
}
