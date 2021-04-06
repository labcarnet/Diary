namespace Diary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFirstNameMaxLenghtAndRequierdInStudentsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbp.Students", "FirstName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbp.Students", "FirstName", c => c.String());
        }
    }
}
