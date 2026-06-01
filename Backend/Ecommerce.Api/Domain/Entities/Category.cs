namespace Ecommerce.Api.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        protected Category() { }
        public Category(int id, string name, string description, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}
