namespace Application.DTO.Authors
{
    public class AuthorInputDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
