namespace Domain
{
    public class BaseModel<T> where T : struct
    {
        public T Id { get; set; }
    }
}
