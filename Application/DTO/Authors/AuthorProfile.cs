using AutoMapper;
using Domain;

namespace Application.DTO.Authors
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<AuthorInputDto, Domain.Author>();
            CreateMap<Domain.Author,AuthorDto>();
        }
    }
}
