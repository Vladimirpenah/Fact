namespace Fact.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbfacturacion.cliente")]
    public partial class cliente
    {
        [Key]
        [DisplayName("Id del Cliente")]
        public int IdCliente { get; set; }

        [DisplayName("Nombre Comercial")]
        [Required(ErrorMessage = "Nombre Comercial es requerido.")]
        [StringLength(59)]
        public string NombreComercial { get; set; }

        [DisplayName("Documento de Identificación")]
        [Required(ErrorMessage = "Documento de Identificación requerido.")]
        [StringLength(11, MinimumLength = 10)]
        public string DocIdentificacion { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
