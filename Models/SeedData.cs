using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WorldFlags.Data;
using System;
using System.Linq;

namespace WorldFlags.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorldFlagsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WorldFlagsContext>>()))
            {
                // Look for any movies.
                if (context.Flag.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flag.AddRange(
                    new Flag
                    {
                        Continent = "Europe",
                        Country = "Belgium",
                        Price = 199.99m,
                        Colour = "Black/yellow/Red",
                        Size = "Medium",
                        rating = "4",
                    },
                    new Flag
                    {
                        Continent = "North America",
                        Country = "Canada",
                        Price = 250.99m,
                        Colour = "Red/White",
                        Size = "Small",
                        rating = "4",
                    },
                    new Flag
                    {
                        Continent = "Asia",
                        Country = "China",
                        Price = 265.99m,
                        Colour = "Red/yellow",
                        Size = "Large",
                        rating = "3",
                    },
                    new Flag
                    {
                        Continent = "Africa",
                        Country = "Chad",
                        Price = 100.99m,
                        Colour = "Blue/yellow/Red",
                        Size = "Extra Large",
                        rating = "4",
                    },
                    new Flag
                    {
                        Continent = "Europe",
                        Country = "France",
                        Price = 300.99m,
                        Colour = "Blue/White/Red",
                        Size = "Large",
                        rating = "5",
                    },
                    new Flag
                    {
                        Continent = "Europe",
                        Country = "Germany",
                        Price = 199.99m,
                        Colour = "Black/Red/yellow",
                        Size = "Medium",
                        rating = "2",
                    },
                    new Flag
                    {
                        Continent = "Europe",
                        Country = "Greece",
                        Price = 150.99m,
                        Colour = "Blue/White",
                        Size = "Extra Large",
                        rating = "1",
                    },
                    new Flag
                    {
                        Continent = "Asia",
                        Country = "India",
                        Price = 300.99m,
                        Colour = "Orange/White/Blue/Green",
                        Size = "Large",
                        rating = "3",
                    },
                    new Flag
                    {
                        Continent = "South America",
                        Country = "Guyana",
                        Price = 200.99m,
                        Colour = "Red/Yellow/Green",
                        Size = "Small",
                        rating = "5",
                    },
                    new Flag
                    {
                        Continent = "Africa",
                        Country = "Angola",
                        Price = 120.99m,
                        Colour = "Red/Yellow/Black",
                        Size = "Medium",
                        rating = "2",
                    }
               

                );
                context.SaveChanges();
            }
        }
    }
}