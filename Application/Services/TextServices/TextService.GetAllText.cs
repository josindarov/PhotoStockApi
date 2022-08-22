using Application.DTO.Texts;
using Domain;

namespace Application.Services.TextServices
{
    public partial class TextService
    {
        public IQueryable<TextDto> GetAllText()
        {
            var TextDtos = this.mapper.ProjectTo<TextDto>(this.textrepository.GetAll());
            return TextDtos;
        }
    }
}
