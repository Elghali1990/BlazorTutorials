using System.ComponentModel.DataAnnotations;

namespace BlazorTutorials.Models
{
    public class StudentVM
    {
        public int Id { get; set; } = 0;

        [Required(ErrorMessage ="Give student name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Give student roll")]
        public string Roll { get; set; }
    }
}
