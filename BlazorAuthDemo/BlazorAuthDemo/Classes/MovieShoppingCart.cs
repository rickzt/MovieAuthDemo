using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAuthDemo.Classes;

public class MovieShoppingCart
{
    [ForeignKey("Product")]
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    [ForeignKey("UserCart")]
    public string ShoppingCartId { get; set; }
    public ShoppingCart Cart { get; set; }
}
