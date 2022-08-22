using Application.DTO.Authors;

namespace Application.Services.AuthorServices
{
    public partial class AuthorService
    {
        public IQueryable<AuthorDto> GetAllAuthors()
        {
           var authorDtos =  this.mapper.ProjectTo<AuthorDto>(this.authorRepository.GetAll());
           return authorDtos;
        }
    }
}
