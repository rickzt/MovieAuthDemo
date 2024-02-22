using BlazorAuthDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthDemo.Classes;

public class ShoppingCart
{
    public string Id { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public List<MovieShoppingCart> ShoppingCarts { get; set; } = new();


}
