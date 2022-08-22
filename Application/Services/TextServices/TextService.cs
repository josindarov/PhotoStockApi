using Application.Interfaces.Repositories;
using AutoMapper;

namespace Application.Services.TextServices
{
    public partial class TextService
    {
        private readonly IMapper mapper;
        private readonly ITextRepository textrepository;

        public TextService(IMapper mapper, ITextRepository textrepository)
        {
            this.mapper = mapper;
            this.textrepository = textrepository;
        }
    }
}
