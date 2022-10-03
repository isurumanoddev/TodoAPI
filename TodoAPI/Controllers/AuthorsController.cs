using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;
using TodoAPI.Models;
using TodoAPI.Services.Authors;
using TodoAPI.Services.Models;

namespace TodoAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private  readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
             
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDTO>> getAllAuthors(string job, string search)
        {
            var authors = _authorRepository.getAllAuthors(job,search); //aLL atuthors

            var mappedAuthors = _mapper.Map<ICollection<AuthorDTO>>(authors);


            return Ok(mappedAuthors);
        }




        [HttpGet("{id}",Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)     // one author
        {
            var author = _authorRepository.getAuthor(id);
            if (author is null)
            {
                return NotFound();
            }
            var mappedAuthors = _mapper.Map<AuthorDTO>(author);
            return Ok(mappedAuthors);
        }

        [HttpPost]
        public ActionResult<AuthorDTO> CreateAuthor(CreateAuthorDTO author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthor = _authorRepository.AddAuthor(authorEntity);
            var authorForReturn = _mapper.Map<AuthorDTO>(newAuthor);
            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.Id }, authorForReturn);
        }
       
       

        


    }
}
