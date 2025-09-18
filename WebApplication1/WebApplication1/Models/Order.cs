using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime FechaPedido { get; set; } = DateTime.Now;

        [Required]
        public OrderStatus Estado { get; set; } = OrderStatus.Pendiente;

        [Range(0, double.MaxValue)]
        public decimal Total { get; set; }

        [StringLength(500)]
        public string Notas { get; set; }

        // Navegación
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public enum OrderStatus
    {
        Pendiente,
        Procesado,
        Enviado,
        Entregado,
        Cancelado
    }
}
