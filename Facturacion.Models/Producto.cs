using System.ComponentModel.DataAnnotations;

namespace Facturacion.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio unitario es requerido")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "La cantidad en existencia del producto es requerida")]
        public int CantidadExistencia { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
