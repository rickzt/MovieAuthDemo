using BlazorAuthDemo.Classes;
using Microsoft.AspNetCore.Identity;

namespace BlazorAuthDemo.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ShoppingCart Cart { get; set; }
    }

}
