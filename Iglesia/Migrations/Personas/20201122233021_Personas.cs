using Microsoft.EntityFrameworkCore.Migrations;

namespace Iglesia.Migrations.Personas
{
    public partial class Personas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genero = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    apellido = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    telefonoPer = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    celular = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    correo = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    TipoDocumento = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    DocuIdentidad = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    fechaNacimiento = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    PaisNacimiento = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    CiudadNacimiento = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    PaisResidencia = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    CiudadResidencia = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Direccion = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Hijos = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Profesion = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    NombreEmpresa = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Ocupacion = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    TelefonoEmp = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    FechaConversion = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    FechaBautismo = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    FechaAceptado = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Denominacion = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    NombreIglesia = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    IglesiaAnterior = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    NombrePastor = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Disciplinado = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Causas = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Funciones = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Ministerios = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    MinisterioMayorFruto = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    MinisterioLlamado = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Metas = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Respaldo = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    NivelEstudio = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    ExpulsadoIns = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    Razon = table.Column<string>(type: "Nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.PersonaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
