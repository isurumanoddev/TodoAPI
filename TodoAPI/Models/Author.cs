using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string HomeNumber { get; set; }
        [MaxLength(100)]
        
        public string Street { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(100)]
        public string Job { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
