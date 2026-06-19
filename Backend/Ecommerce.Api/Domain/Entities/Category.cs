namespace Ecommerce.Api.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // Relacionamento 1:N (Uma Categoria, Muitos Produtos)
        public ICollection<Product> Products { get; set; } = new List<Product>();
        protected Category() { }
        public Category(int id, string name, string description, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = createdAt == default ? DateTime.Now : createdAt;
        }
    }
}
