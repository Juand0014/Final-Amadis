using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

#nullable disable


namespace Iglesia.Models
{
    public class Persona
    {
        //Datos personales
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string genero { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string nombre { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string apellido { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string telefonoPer { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string celular { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string correo { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string TipoDocumento { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string DocuIdentidad { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public DateTime fechaNacimiento { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string PaisNacimiento { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string CiudadNacimiento { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string PaisResidencia { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string CiudadResidencia { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Direccion { get; set; }
        [Column(TypeName = "Nvarchar(100)")]

        //Datos familiares

        public string EstadoCivil { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Hijos { get; set; }
        [Column(TypeName = "Nvarchar(100)")]

        //Datos laborales

        public string Profesion { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string NombreEmpresa { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Ocupacion { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string TelefonoEmp { get; set; }
        [Column(TypeName = "Nvarchar(100)")]

        //Datos eclesiasticos

        public string FechaConversion { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string FechaBautismo { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string FechaAceptado { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Denominacion { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string NombreIglesia { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string IglesiaAnterior { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string NombrePastor { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Disciplinado { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Causas { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Funciones { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Ministerios { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string MinisterioMayorFruto { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string MinisterioLlamado { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Metas { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Respaldo { get; set; }
        [Column(TypeName = "Nvarchar(100)")]

        //Datos academicos

        public string NivelEstudio { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string ExpulsadoIns { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public string Razon { get; set; }
    }
}
