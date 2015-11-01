namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CakeDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cake", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cake", "Description");
        }
    }
}
