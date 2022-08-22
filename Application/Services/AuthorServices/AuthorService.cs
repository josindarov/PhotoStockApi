using Application.Interfaces.Repositories;
using AutoMapper;

namespace Application.Services.AuthorServices
{
    public partial class AuthorService
    {
        private readonly IMapper mapper;
        private readonly IAuthorRepository authorRepository;

        public AuthorService(IMapper mapper, IAuthorRepository authorRepository)
        {
            this.mapper = mapper;
            this.authorRepository = authorRepository;
        }
    }
}
