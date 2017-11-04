namespace Fact.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbfacturacion.empleado")]
    public partial class empleado
    {
        [Key]
        [DisplayName("Id del Empleado")]
        public int IdEmpleado { get; set; }

        [DisplayName("Nombre del Empleado")]
        [Required(ErrorMessage = "Nombre del Empleado es requerido.")]
        [StringLength(59)]
        public string NombreEmpleado { get; set; }

        [DisplayName("Porciento de Comisión")]
        [Required(ErrorMessage = "Porciento de Comisión es requerido.")]
        public decimal? PorcientoComision { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
