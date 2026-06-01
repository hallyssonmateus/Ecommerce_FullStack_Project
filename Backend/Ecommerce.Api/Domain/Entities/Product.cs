namespace Ecommerce.Api.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        //Adicionando relacionamento com Categoria
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        protected Product(){ }

        public Product(int id, string name, string description, decimal price, int stockQuantity, bool isActive, DateTime createdAt, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            IsActive = isActive;
            CreatedAt = createdAt;
            CategoryId = categoryId;
        }
    }
}
