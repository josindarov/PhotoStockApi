using Application.DTO.Texts;
using Domain;

namespace Application.Services.TextServices
{
    public partial class TextService
    {
        public async Task<TextDto> GetTextById(Guid id)
        {
            var text = this.mapper.Map<TextDto>(await this.textrepository.GetByIdAsync(id));
            return text;
        }
    }
}
