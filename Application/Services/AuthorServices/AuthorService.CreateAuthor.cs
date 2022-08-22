using Application.DTO.Authors;
using Domain;

namespace Application.Services.AuthorServices
{
    public class CreateAuthorRequest
    {
        public AuthorInputDto Payload { get; }
            
        public CreateAuthorRequest(AuthorInputDto authorInputDto)
        {
            Payload = authorInputDto;
        }
    }
    public partial class AuthorService
    {
        public async Task<Author> AddAuthor(CreateAuthorRequest request)
        {
            var author = this.mapper.Map<Author>(request.Payload);

            author.DateOfRegistration = DateTimeOffset.UtcNow;

            author = this.authorRepository.Add(author);
            
            await this.authorRepository.SaveChangesAsync();

            return author;
        }
    }
}
