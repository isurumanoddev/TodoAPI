using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TodoAPI.Models;

namespace TodoAPI.Services.Models
{
    public class AuthorDTO
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
      
        public string Address { get; set; }

        public string Job { get; set; }


    }
}
