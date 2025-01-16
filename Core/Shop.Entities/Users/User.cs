namespace Shop.Entities.Users;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Order> Orders { get; set; }
    public Cart Cart { get; set; }
    public ICollection<Review> Reviews { get; set; }
}