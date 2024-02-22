using BlazorAuthDemo.Classes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthDemo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ShoppingCart> Carts { get; set; }
        public DbSet<MovieShoppingCart> MovieShoppingCarts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingCart>()
                .HasOne(uc => uc.ApplicationUser)
                .WithOne(u => u.Cart)
                .HasForeignKey<ShoppingCart>(uc => uc.Id);


            modelBuilder.Entity<MovieShoppingCart>()
                .HasKey(puc => new { puc.MovieId, puc.ShoppingCartId });

            modelBuilder.Entity<ShoppingCart>()
                .HasKey(uc => uc.Id);
        }
    }
}
