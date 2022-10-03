using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TodoAPI.Models;

namespace TodoAPI.Services.Models
{
    public class CreateAuthorDTO
    {

        public string Name { get; set; }
        
        public string HomeNumber { get; set; }

        public string Street { get; set; }
        
        public string City { get; set; }
       
        public string Job { get; set; }

    }
}
