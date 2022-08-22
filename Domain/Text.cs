namespace Domain
{
    public class Text : BaseModel<Guid>
    {
        public string Name { get; set; }
        public string TextContent { get; set; }
        public DateTimeOffset DateOfCreation { get; set; }
        public decimal Cost { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public int NumberOfSales { get; set; }
        public int Rating { get; set; }
    }
}
