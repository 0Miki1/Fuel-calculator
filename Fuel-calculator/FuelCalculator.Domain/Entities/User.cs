#nullable enable

using System.ComponentModel.DataAnnotations;

namespace FuelCalculator.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string UserName { get; set; } = string.Empty;

        [Required, MaxLength(60)]
        public string Password { get; set; } = string.Empty;
    }
}
