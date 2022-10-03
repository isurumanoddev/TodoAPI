using System.ComponentModel.DataAnnotations;
using System;
using TodoAPI.Models;

namespace TodoAPI.Services.Models
{
    public class CreateTodoDTO
    {
     
        
        public string Title { get; set; }
       
        public string Discription { get; set; }
       
        public DateTime Created { get; set; }
       
        public DateTime Due { get; set; }
        
        public string Status { get; set; } // New , Inprogress, Completed

   
      
    }
}
