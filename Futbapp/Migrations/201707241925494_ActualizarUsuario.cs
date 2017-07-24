namespace Futbapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizarUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "CumpleAnio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "CumpleAnio", c => c.DateTime(nullable: false));
        }
    }
}
