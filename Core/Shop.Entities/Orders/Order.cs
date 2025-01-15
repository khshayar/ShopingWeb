namespace Shop.Entities.Orders;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
}