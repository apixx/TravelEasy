using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TravelEasy.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "New York",
                        Description = "The Big Apple, 7 nights, breakfast included",
                        Category = "United States",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Bali",
                        Description = "4 nights, charter",
                        Category = "Indonesia",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Cappadocia",
                        Description = "5 nights, charter",
                        Category = "Asia",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "London",
                        Description = "3 nights, breakfast included",
                        Category = "Europe",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Dubai",
                        Description = "7 nights stay in a 5 star hotel",
                        Category = "United Arab Emirates",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Paris",
                        Description = "4 nigths, Eiffel Tower tour included",
                        Category = "Europe",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Abu Dhabi",
                        Description = "6 nights stay",
                        Category = "United Arab Emirates",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Miami",
                        Description = "10 nights stay",
                        Category = "United States",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Hong-Kong",
                        Description = "7 nights, charter",
                        Category = "Asia",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
