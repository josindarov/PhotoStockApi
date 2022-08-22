using Application.DTO.Authors;
using Application.Services.AuthorServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService authorService;

        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public ActionResult<IQueryable<AuthorDto>> GetAll()
        {
            var authors = this.authorService.GetAllAuthors();
            return Ok(authors);
        }

        [HttpPost]
        public async Task<ActionResult<Domain.Author>> AddAuthor(
            [FromBody][Required] AuthorInputDto payload)
        {
            var author = await this.authorService.AddAuthor(
                new CreateAuthorRequest(payload));
            return Ok(author);
        }
    }

}
