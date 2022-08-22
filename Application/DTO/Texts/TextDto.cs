using Application.DTO.Authors;

namespace Application.DTO.Texts
{
    public class TextDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TextContent { get; set; }
        public DateTimeOffset DateOfCreation { get; set; }
        public decimal Cost { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }
        public int NumberOfSales { get; set; }
        public int Rating { get; set; }
    }
}
