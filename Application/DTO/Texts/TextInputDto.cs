using Domain;

namespace Application.DTO.Text
{
    public  class TextInputDto
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public string TextContent { get; set; }
        public decimal Cost { get; set; }
        public int NumberOfSales { get; set; }

    }
}
