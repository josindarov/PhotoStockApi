namespace Domain
{
    public class Author : BaseModel<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public DateTimeOffset DateOfRegistration { get; set; }
        //public List<Photo> Photos { get; set; }
    }
}
