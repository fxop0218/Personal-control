using System.ComponentModel.DataAnnotations;
namespace Control_de_personal.Models
{
    public class Requests
    {
        [Key]
        public int Id { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        public string DNI { get; set; }
    }
}
