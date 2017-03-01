namespace handycareappService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class azure2 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Familiar", "FamParentesco", "dbo.Parentesco");
            //DropIndex("dbo.Familiar", new[] { "FamParentesco" });
            //DropIndex("dbo.Parentesco", new[] { "Id" });
            //DropPrimaryKey("dbo.Parentesco");
            //AlterColumn("dbo.Familiar", "FamParentesco", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.Parentesco", "Id", c => c.String(nullable: false, maxLength: 128));
            //AddPrimaryKey("dbo.Parentesco", "Id");
            //CreateIndex("dbo.Familiar", "FamParentesco");
            //AddForeignKey("dbo.Familiar", "FamParentesco", "dbo.Parentesco", "Id");
            AddColumn("dbo.TipoCuidador", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoCuidador", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoCuidador", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.TipoCuidador", "Deleted", c => c.Boolean(nullable: true));
        }
        
        //public override void Down()
        //{
        //    DropForeignKey("dbo.Familiar", "FamParentesco", "dbo.Parentesco");
        //    DropIndex("dbo.Familiar", new[] { "FamParentesco" });
        //    DropPrimaryKey("dbo.Parentesco");
        //    AlterColumn("dbo.Parentesco", "Id", c => c.String(nullable: false, maxLength: 36));
        //    AlterColumn("dbo.Familiar", "FamParentesco", c => c.String(nullable: false, maxLength: 36));
        //    AddPrimaryKey("dbo.Parentesco", "Id");
        //    CreateIndex("dbo.Parentesco", "Id");
        //    CreateIndex("dbo.Familiar", "FamParentesco");
        //    AddForeignKey("dbo.Familiar", "FamParentesco", "dbo.Parentesco", "Id");
        //}
    }
}
