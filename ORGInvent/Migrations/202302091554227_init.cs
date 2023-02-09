namespace ORGInvent.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CPU",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        ChipsetName = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataStorage",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        TotalVolume = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        GeneralInformationId = c.Long(nullable: false),
                        CPU_Id = c.Long(),
                        DataStorage_Id = c.Long(),
                        MB_Id = c.Long(),
                        OS_Id = c.Long(),
                        RAM_Id = c.Long(),
                        VideoCard_Id = c.Long(),
                        Workers_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CPU", t => t.CPU_Id)
                .ForeignKey("dbo.DataStorage", t => t.DataStorage_Id)
                .ForeignKey("dbo.GeneralInformation", t => t.GeneralInformationId, cascadeDelete: true)
                .ForeignKey("dbo.MB", t => t.MB_Id)
                .ForeignKey("dbo.OS", t => t.OS_Id)
                .ForeignKey("dbo.RAM", t => t.RAM_Id)
                .ForeignKey("dbo.VideoCard", t => t.VideoCard_Id)
                .ForeignKey("dbo.Workers", t => t.Workers_Id);
            
            CreateTable(
                "dbo.GeneralInformation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Model = c.String(maxLength: 2147483647),
                        InventoryNumber = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        IpAddress = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MB",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        ChipsetName = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OS",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        DateOfInstall = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RAM",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        TotalVolume = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoCard",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Manufacturer = c.String(maxLength: 2147483647),
                        VideoMemorySize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 2147483647),
                        Floor = c.Int(nullable: false),
                        Cabinet = c.String(maxLength: 2147483647),
                        Department = c.String(maxLength: 2147483647),
                        Function = c.String(maxLength: 2147483647),
                        Phone = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modernization",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(maxLength: 2147483647),
                        Date = c.DateTime(nullable: false),
                        TypeOfWork = c.Int(nullable: false),
                        Equipment_Id = c.Long(),
                        User_Id = c.Long(),
                        Worker_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Password = c.String(nullable: false, maxLength: 2147483647),
                        FullName = c.String(nullable: false, maxLength: 2147483647),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Moving",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(maxLength: 2147483647),
                        Date = c.DateTime(nullable: false),
                        TypeOfWork = c.Int(nullable: false),
                        Equipment_Id = c.Long(),
                        User_Id = c.Long(),
                        Worker_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Moving", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.Moving", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Moving", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Modernization", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.Modernization", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Modernization", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Equipments", "Workers_Id", "dbo.Workers");
            DropForeignKey("dbo.Equipments", "VideoCard_Id", "dbo.VideoCard");
            DropForeignKey("dbo.Equipments", "RAM_Id", "dbo.RAM");
            DropForeignKey("dbo.Equipments", "OS_Id", "dbo.OS");
            DropForeignKey("dbo.Equipments", "MB_Id", "dbo.MB");
            DropForeignKey("dbo.Equipments", "GeneralInformationId", "dbo.GeneralInformation");
            DropForeignKey("dbo.Equipments", "DataStorage_Id", "dbo.DataStorage");
            DropForeignKey("dbo.Equipments", "CPU_Id", "dbo.CPU");
            DropTable("dbo.Moving");
            DropTable("dbo.Users",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Login",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Modernization");
            DropTable("dbo.Workers");
            DropTable("dbo.VideoCard");
            DropTable("dbo.RAM");
            DropTable("dbo.OS");
            DropTable("dbo.MB");
            DropTable("dbo.GeneralInformation");
            DropTable("dbo.Equipments");
            DropTable("dbo.DataStorage");
            DropTable("dbo.CPU");
        }
    }
}
