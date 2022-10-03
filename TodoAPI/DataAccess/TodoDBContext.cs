using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }    // DBset (databse tables ) , Entity Type > toodo
        public DbSet<Author> Authors { get; set; }
        // table name = Todos

        //* databse connect  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=IM\\SQLEXPRESS;Initial Catalog=abc;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }
        // when create model (add data to database table when creating)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, Name = "isuru", HomeNumber ="1", Street = "A", City = "Q",Job = "Devoloper"},
                new Author { Id = 2, Name = "Alex", HomeNumber ="1", Street = "S", City = "H", Job = "Engineer"},
                new Author { Id = 3, Name = "Ann" ,HomeNumber ="1", Street = "D", City = "W",Job = "Investor"},
                new Author { Id = 4, Name = "Max",HomeNumber ="1", Street = "F", City = "T" ,Job = "Designer"},
                new Author { Id = 5, Name = "tony",HomeNumber ="1", Street = "G", City = "E" , Job = "Devoloper"},
                new Author { Id = 6, Name = "liee",HomeNumber ="1", Street = "H", City = "C" , Job = "Investor"},
                new Author { Id = 7, Name = "las" ,HomeNumber ="1", Street = "K", City = "VC", Job = "Devoloper"},
                new Author { Id = 8, Name = "Bee" ,HomeNumber ="1", Street = "H", City = "R", Job = "Investor"},
                new Author { Id = 9, Name = "mac",HomeNumber ="1", Street = "Q", City = "C" , Job = "Engineer"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
          {
              new Todo{Id = 1,
                  Title = "Drink water",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed,
                  AuthorId = 1
              },
              new Todo{Id = 2,
                  Title = "DMake Tea",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed,AuthorId = 2

              },
              new Todo{Id = 3,
                  Title = "Toilet",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed, AuthorId = 3

              },
              new Todo{Id = 4,
                  Title = "Brush Teeth",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed, AuthorId = 4

              },
              new Todo{Id = 5,
                  Title = "Breakfast",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed, AuthorId =2},
              new Todo{Id = 6,
                  Title = "Breakfast",
                  Discription = "Drink 1 liter after workout",
                  Created = DateTime.Now,
                  Due = DateTime.Now,
                  Status = TodoStatus.Completed, AuthorId =2}

          });
        }
    }
}
