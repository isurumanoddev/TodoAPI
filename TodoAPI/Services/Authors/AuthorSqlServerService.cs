using System.Collections.Generic;
using System.Linq;
using TodoAPI.DataAccess;
using TodoAPI.Models;

namespace TodoAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDBContext _dbContext = new TodoDBContext();

        public List<Author> getAllAuthors()
        {
            return _dbContext.Authors.ToList();
        }



        public List<Author> getAllAuthors(string job,string search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search))
            {
                return getAllAuthors();
            }

            var authorCollection = _dbContext.Authors as IQueryable<Author>;


            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(a => a.Job == job);

            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => a.Name.Contains(search));
            }
            return authorCollection.ToList();
        }

        public Author getAuthor(int id)
        {
            return _dbContext.Authors.Find(id);
        }

        public Author AddAuthor(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
            return _dbContext.Authors.Find(author.Id);
        }




    }
}
