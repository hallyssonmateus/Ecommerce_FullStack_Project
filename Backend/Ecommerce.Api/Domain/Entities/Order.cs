namespace Ecommerce.Api.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
        // Chave estrangeira
        public int CustomerId { get; set; }
        public User? Customer { get; set; }
        // Lista de itens do pedido
        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        protected Order(){}

        public Order(int id, DateTime orderDate, decimal totalAmount, string status, int customerId)
        {
            Id = id;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = status;
            CustomerId = customerId;
        }

    }
}
