namespace UFCQuixada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "Secret");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Secret", c => c.String());
        }
    }
}
