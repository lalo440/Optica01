namespace Optica01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        telefono = c.Int(nullable: false),
                        sexo = c.String(),
                        edad = c.Int(nullable: false),
                        graduacion = c.Int(nullable: false),
                        sucursal = c.String(),
                        direccion = c.String(),
                        observaciones = c.String(),
                        fecha = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
