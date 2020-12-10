namespace MyFirstDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Attribute_10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teams", "Country", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Country", c => c.String());
            AlterColumn("dbo.Teams", "Name", c => c.String());
        }
    }
}
