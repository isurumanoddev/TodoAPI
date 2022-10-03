using System.ComponentModel.DataAnnotations;
using System;
using TodoAPI.Models;

namespace TodoAPI.Services.Models
{
    public class UpdateTodoDTO
    {
        [Required(ErrorMessage = "Enter Title")]
        public string Title { get; set; }
        
        public string Discription { get; set; }
        
        public DateTime Created { get; set; }
        
        public DateTime Due { get; set; }
        
        public TodoStatus Status { get; set; }
    }
}
