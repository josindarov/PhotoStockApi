using Application.DTO.Text;
using AutoMapper;
using Domain;

namespace Application.DTO.Texts
{
    public class TextProfile : Profile
    {
        public TextProfile()
        {
            CreateMap<TextInputDto, Domain.Text>();

            CreateMap<Domain.Text, TextDto>()
                .ForMember(dest => dest.FirstName, configs => configs.MapFrom(src => src.Author.FirstName))
                .ForMember(dest => dest.NickName, configs => configs.MapFrom(src => src.Author.NickName));
        }
    }
}
