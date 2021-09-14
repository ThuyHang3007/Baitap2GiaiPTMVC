namespace Baitap2MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Company", c => c.String());
            AddColumn("dbo.People", "Address", c => c.String());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.People", "PersonName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PersonName", c => c.String());
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.People", "Company");
        }
    }
}
