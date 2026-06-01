namespace Ecommerce.Api.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public decimal PriceatPurchase { get; set; }
        protected OrderItem() { }

        public OrderItem(int id, int orderId, int productId, int quantity, decimal priceatPurchase)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            PriceatPurchase = priceatPurchase;
        }
    }
}
