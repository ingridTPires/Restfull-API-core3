using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            _courseLibraryRepository = courseLibraryRepository ??
                throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            return Ok(authorsFromRepo);
        }
        [HttpGet("{authorId}")]
        public IActionResult GetAuthor(Guid authorId)
        {
            // já que é utilizada ao final do método, não é certo usar um método Exists do reposíitório 
            var authorFromRepo = _courseLibraryRepository.GetAuthor(authorId);

            if (authorId == null)
            {
                return NotFound();
            }
            return Ok(authorFromRepo);
        }
    }
}
