namespace Fact.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbfacturacion.articulo")]
    public partial class articulo
    {
        [Key]
        [DisplayName("ID del Articulo")]
        public int IdArticulo { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción es requerida.")]
        [StringLength(59)]
        public string DescripcionArticulo { get; set; }

        [DisplayName("Precio Unitario")]
        [Required(ErrorMessage = "Precio Unitario es requerido.")]
        public decimal? PrecioUnitario { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
