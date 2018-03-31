namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityAndAddressModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        ShortCode = c.String(nullable: false, maxLength: 10),
                        ClearingCode = c.String(nullable: false, maxLength: 30),
                        EntityAddress_Street = c.String(maxLength: 255),
                        EntityAddress_City = c.String(maxLength: 50),
                        EntityAddress_State = c.String(maxLength: 50),
                        EntityAddress_Country = c.String(nullable: false, maxLength: 50),
                        EntityAddress_Zip = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entities");
        }
    }
}
