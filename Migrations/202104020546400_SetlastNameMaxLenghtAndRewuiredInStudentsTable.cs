namespace Diary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetlastNameMaxLenghtAndRewuiredInStudentsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbp.Students", "LastName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbp.Students", "LastName", c => c.String());
        }
    }
}
