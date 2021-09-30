using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using netcore.Data;
using System;
using System.Linq;

namespace netcore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "When Harry Met Sally",
                        Time = DateTime.Parse("1989-2-12"),
                        Description = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "Very good"
                    },

                    new Product
                    {
                        Name = "Ghostbusters ",
                        Time = DateTime.Parse("1984-3-13"),
                        Description = "Comedy",
                        Price = 8.99M,
                        Rating = "Very good"
                    },

                    new Product
                    {
                        Name = "Ghostbusters 2",
                        Time = DateTime.Parse("1986-2-23"),
                        Description = "Comedy",
                        Price = 9.99M,
                        Rating = "Very good"
                    },

                    new Product
                    {
                        Name = "Rio Bravo",
                        Time = DateTime.Parse("1959-4-15"),
                        Description = "Western",
                        Price = 3.99M,
                        Rating = "Very good"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
