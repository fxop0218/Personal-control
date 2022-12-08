namespace Control_de_personal.Models
{
    public class Schedules
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime[] Day { get; set; }
        public DateTime[] Start { get; set; }
        public DateTime[] Finish { get; set; }
    }
}
