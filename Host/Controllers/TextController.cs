using Application.DTO.Text;
using Application.Services.TextServices;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Application.DTO.Texts;

namespace Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextController : ControllerBase
    {
        private readonly TextService textService;

        public TextController(TextService textService)
        {
            this.textService = textService;
        }
        [HttpGet]
        public ActionResult<IQueryable<TextDto>> GetAll()
        {
            var text = this.textService.GetAllText();
            return Ok(text);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TextDto>> GetByIdAsync(Guid id)
        {
            var textContext = await this.textService.GetTextById(id);
            if(textService != null)
            {
                return Ok(textContext);
            }
            return NotFound();
            
        }
        [HttpPost]
        public async Task<ActionResult<TextDto>> AddText(
            [FromBody][Required] TextInputDto payload)
        {
            var text = await this.textService.AddNewText(
                new CreateTextRequest(payload));
            return Ok(text);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var response = await this.textService.DeleteTextAsync(id);
            var message = "Object is successfully deleted!";
            if(!response)
            {
                message = "Something went wrong, please try again!";
                return BadRequest(message);
            }
            return Ok(message);
        }

    }
}
