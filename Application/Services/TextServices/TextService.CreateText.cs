using Application.DTO.Text;
using Application.DTO.Texts;
using Domain;

namespace Application.Services.TextServices
{
    public class CreateTextRequest
    {
        public TextInputDto Payload { get; }
        public CreateTextRequest(TextInputDto textInputDto)
        {
            Payload = textInputDto;
        }
    }
    public partial class TextService
    {
        public async Task<TextDto> AddNewText(CreateTextRequest request)
        {
            var text = this.mapper.Map<Text>(request.Payload);
            text.DateOfCreation = DateTime.UtcNow;
            text = this.textrepository.AddText(text);
            await this.textrepository.SaveChangesAsync();
            var textDto = this.mapper.Map<TextDto>(text);
            return textDto;
        }
    }
}
