using System.ComponentModel.DataAnnotations;

namespace Control_de_personal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Max length is 30")]
        public string Username { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Max length is 30")]
        public string Password { get; set; }
        public string Workstation { get; set; } = "Undefined";
        [Required]
        [Range(1, 10000000, ErrorMessage = "Price must be between $1 and $10000000")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Salary { get; set; }
        public DateTime EndContract { get; set; }
        [Required]
        public string DNI { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Max length is 40")]
        public string email { get; set; }
        public List<Schedules> Schedules { get; set; }
        public int Admin { get; set; } = 0; // If this is a 100 the user is a admin, and hace diferents privs 
    }
}
