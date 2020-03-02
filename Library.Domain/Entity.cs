namespace Library.Domain
{
    public class Entity
    {
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
    }
}
