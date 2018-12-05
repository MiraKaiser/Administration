namespace AdministrationTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.ClientModels",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   ContactFirstName = c.String(),
                   ContactLastName = c.String(),
                   BillingName = c.String(),
                   KvK = c.Int(nullable: false),
                   Email = c.String(),
                   Phone = c.Long(nullable: false),
                   AddressStreet = c.String(),
                   AddressNumber = c.String(),
                   AddressZip = c.String(),
                   AddressCity = c.String(),
               })
               .PrimaryKey(t => t.Id);



            CreateTable(
                "dbo.HostingModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    Price = c.Single(nullable: false),
                })
                .PrimaryKey(t => t.Id);



            CreateTable(
                "dbo.DomainModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Client_Id = c.Int(),
                    Hosting_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientModels", t => t.Client_Id)
                .ForeignKey("dbo.HostingModels", t => t.Hosting_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Hosting_Id);



            CreateTable(
                "dbo.BillModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Amount = c.Single(nullable: false),
                    SentDate = c.DateTime(nullable: false),
                    PaidDate = c.DateTime(nullable: false),
                    BillContent = c.String(),
                    Client_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientModels", t => t.Client_Id)
                .Index(t => t.Client_Id);



            CreateTable(
                "dbo.BillItemModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    AmountExBtw = c.Single(nullable: false),
                    BillModel_Id = c.Int(),
                    DomainModel_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillModels", t => t.BillModel_Id)
                .ForeignKey("dbo.DomainModels", t => t.DomainModel_Id)
                .Index(t => t.BillModel_Id)
                .Index(t => t.DomainModel_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.BillItemModels", "DomainModel_Id", "dbo.DomainModels");
            DropForeignKey("dbo.DomainModels", "Hosting_Id", "dbo.HostingModels");
            DropForeignKey("dbo.DomainModels", "Client_Id", "dbo.ClientModels");
            DropForeignKey("dbo.BillItemModels", "BillModel_Id", "dbo.BillModels");
            DropForeignKey("dbo.BillModels", "Client_Id", "dbo.ClientModels");
            DropIndex("dbo.DomainModels", new[] { "Hosting_Id" });
            DropIndex("dbo.DomainModels", new[] { "Client_Id" });
            DropIndex("dbo.BillModels", new[] { "Client_Id" });
            DropIndex("dbo.BillItemModels", new[] { "DomainModel_Id" });
            DropIndex("dbo.BillItemModels", new[] { "BillModel_Id" });
            DropTable("dbo.HostingModels");
            DropTable("dbo.DomainModels");
            DropTable("dbo.ClientModels");
            DropTable("dbo.BillModels");
            DropTable("dbo.BillItemModels");
        }
    }
}
