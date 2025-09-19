using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public string Rol { get; set; } = "Cliente";

        public DateTime Creado { get; set; } = DateTime.Now;

        // Navegación
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }

    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string Employee = "Empleado";
        public const string Client = "Cliente";
    }
}
