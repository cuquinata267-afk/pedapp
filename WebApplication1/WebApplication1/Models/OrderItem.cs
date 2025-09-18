using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int Quantity { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal => Quantity * PrecioUnitario;

        // Navegación
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
