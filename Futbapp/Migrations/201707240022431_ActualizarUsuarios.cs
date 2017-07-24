namespace Futbapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizarUsuarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipoes",
                c => new
                    {
                        Nombre = c.String(nullable: false, maxLength: 128),
                        posicion = c.Int(nullable: false),
                        Puntos = c.Int(nullable: false),
                        GF = c.Int(nullable: false),
                        GC = c.Int(nullable: false),
                        Victorias = c.Int(nullable: false),
                        Empates = c.Int(nullable: false),
                        Perdidas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Nombre);
            
            AddColumn("dbo.Usuarios", "Provincia", c => c.String());
            AddColumn("dbo.Usuarios", "Ciudad", c => c.String());
            AddColumn("dbo.Usuarios", "Zona", c => c.String());
            AddColumn("dbo.Usuarios", "CumpleAnio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "GolesHechos", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "PartidosJugados", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Posicion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Posicion");
            DropColumn("dbo.Usuarios", "PartidosJugados");
            DropColumn("dbo.Usuarios", "GolesHechos");
            DropColumn("dbo.Usuarios", "CumpleAnio");
            DropColumn("dbo.Usuarios", "Zona");
            DropColumn("dbo.Usuarios", "Ciudad");
            DropColumn("dbo.Usuarios", "Provincia");
            DropTable("dbo.Equipoes");
        }
    }
}
