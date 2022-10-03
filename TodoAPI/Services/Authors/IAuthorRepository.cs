using System.Collections.Generic;
using TodoAPI.Models;

namespace TodoAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> getAllAuthors();

        public Author getAuthor(int id);

        public List<Author> getAllAuthors(string job,string search);

        public Author AddAuthor(Author author);

    }
}
