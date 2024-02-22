namespace BlazorAuthDemo.Classes;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<MovieShoppingCart> ShoppingCarts { get; set; } = new();
}
