namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CounterpartyModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counterparties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        ShortCode = c.String(nullable: false, maxLength: 10),
                        ClearingCode = c.String(nullable: false, maxLength: 30),
                        CPartyAddress_Street = c.String(maxLength: 255),
                        CPartyAddress_City = c.String(maxLength: 50),
                        CPartyAddress_State = c.String(maxLength: 50),
                        CPartyAddress_Country = c.String(nullable: false, maxLength: 50),
                        CPartyAddress_Zip = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Counterparties");
        }
    }
}
