using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;



namespace LocalAutos.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutoContext(
                serviceProvider.GetRequiredService<DbContextOptions<AutoContext>>())
)
            {
                // Look for any Automobiles.
                if (context.AutoNew.Any())
                {
                    return; // DB has been seeded
                }
                
                context.AutoNew.AddRange(
                    new Automobiles
                    {
                        AutomobilesID = 1,
                        Make = "Ford",
                        AutoLocation = "Pampa",
                        YearMade = "1984",          //Seed data for AutomobilesID 1
                        Model = "F-150",
                        Price = 21500.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 2,
                        Make = "Jeep",
                        AutoLocation = "Canyon",
                        YearMade = "1987",          //Seed data for AutomobilesID 2
                        Model = "Wrangler",
                        Price = 9100.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 3,
                        Make = "Ford",
                        AutoLocation = "Lubbock",
                        YearMade = "2010",         //Seed data for AutomobilesID 3
                        Model = "F-150",
                        Price = 00.00M,
                        SaleTrade = "Trade"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 4,
                        Make = "GMC",
                        AutoLocation = "Memphis",
                        YearMade = "1977",          //Seed data for AutomobilesID 4
                        Model = "High Sierra Longbed",
                        Price = 13000.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 5,
                        Make = "Toyota",
                        AutoLocation = "Pampa",
                        YearMade = "1995",          //Seed data for AutomobilesID 5
                        Model = "Corolla",
                        Price = 950.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 6,
                        Make = "Ford",
                        AutoLocation = "Canyon",
                        YearMade = "2012",          //Seed data for AutomobilesID 6
                        Model = "Focus",
                        Price = 00.00M,
                        SaleTrade = "Trade"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 7,
                        Make = "Ford",
                        AutoLocation = "Amarillo",
                        YearMade = "2015",          //Seed data for AutomobilesID 7
                        Model = "Taurus",
                        Price = 15900.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 8,
                        Make = "Jeep",
                        AutoLocation = "Lubbock",
                        YearMade = "1988",          //Seed data for AutomobilesID 8
                        Model = "Cherokee",
                        Price = 8100.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 9,
                        Make = "Toyota",
                        AutoLocation = "Plainview",
                        YearMade = "2020",          //Seed data for AutomobilesID 9
                        Model = "Camry",
                        Price = 00.00M,
                        SaleTrade = "Trade"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 10,
                        Make = "Dodge",
                        AutoLocation = "Pampa",
                        YearMade = "2008",          //Seed data for AutomobilesID 10
                        Model = "Charger",
                        Price = 6550.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 11,
                        Make = "Ford",
                        AutoLocation = "Canyon",
                        YearMade = "2010",         //Seed data for AutomobilesID 11
                        Model = "Focus",
                        Price = 4900.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 12,
                        Make = "Volkswagen",
                        AutoLocation = "Pampa",
                        YearMade = "1998",        //Seed data for AutomobilesID 12
                        Model = "Jetta",
                        Price = 00.00M,
                        SaleTrade = "Trade"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 13,
                        Make = "Nissan",
                        AutoLocation = "Canyon",
                        YearMade = "2005",          //Seed data for AutomobilesID 13
                        Model = "Altima",
                        Price = 4300.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 14,
                        Make = "Toyota",
                        AutoLocation = "Amarillo",
                        YearMade = "2010",        //Seed data for AutomobilesID 14
                        Model = "Camry",
                        Price = 8000.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 15,
                        Make = "Ford",
                        AutoLocation = "Childress",
                        YearMade = "1998",         //Seed data for AutomobilesID 15
                        Model = "Expedition",
                        Price = 3500.00M,
                        SaleTrade = "Sale"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 16,
                        Make = "GMC",
                        AutoLocation = "Happy",
                        YearMade = "2006",          //Seed data for AutomobilesID 16
                        Model = "Sierra Extended Cab",
                        Price = 10950.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 17,
                        Make = "Nissan",
                        AutoLocation = "Pampa",
                        YearMade = "2020",          //Seed data for AutomobilesID 17
                        Model = "Sentra",
                        Price = 00.00M,
                        SaleTrade = "Trade"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 18,
                        Make = "GMC",
                        AutoLocation = "Canyon",
                        YearMade = "1988",          //Seed data for AutomobilesID 18
                        Model = "Sierra",
                        Price = 15500.00M,
                        SaleTrade = "Sale"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 19,
                        Make = "Mitsubishi",
                        AutoLocation = "Lubbock",
                        YearMade = "2005",        //Seed data for AutomobilesID 19
                        Model = "Eclipse",
                        Price = 7995.00M,
                        SaleTrade = "Sale"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 20,
                        Make = "Volkswagen",
                        AutoLocation = "Canyon",
                        YearMade = "1995",         //Seed data for AutomobilesID 20
                        Model = "Jetta",
                        Price = 4300.00M,
                        SaleTrade = "Sale"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 21,
                        Make = "Jeep",
                        AutoLocation = "Pampa",
                        YearMade = "1993",         //Seed data for AutomobilesID 21
                        Model = "Wrangler",
                        Price = 4500.00M,
                        SaleTrade = "Sale"

                    },

                    new Automobiles
                    {
                        AutomobilesID = 22,
                        Make = "Nissan",
                        AutoLocation = "Canyon",
                        YearMade = "2014",          //Seed data for AutomobilesID 22
                        Model = "Maxima",
                        Price = 00.00M,
                        SaleTrade = "Trade"

                    },


                    new Automobiles
                    {
                        AutomobilesID = 23,
                        Make = "Tesla",
                        AutoLocation = "Amarillo",
                        YearMade = "2021",          //Seed data for AutomobilesID 23
                        Model = "Model X Plaid",
                        Price = 00.00M,
                        SaleTrade = "Trade"
                        
                    },


                    new Automobiles
                    {
                        AutomobilesID = 24,
                        Make = "Ford",
                        AutoLocation = "Pampa",
                        YearMade = "2007",         //Seed data for AutomobilesID 24
                        Model = "Focus",
                        Price = 4500.00M,
                        SaleTrade = "Sale"

                    },



                    new Automobiles
                    {
                        AutomobilesID = 25,
                        Make = "GMC",
                        AutoLocation = "Canyon",
                        YearMade = "2010",         //Seed data for AutomobilesID 25
                        Model = "Sierra 1500 Crew Cab",
                        Price = 13600.00M,
                        SaleTrade = "Sale"

                        
                    }



                );
                
                context.SaveChanges();
            }
        }
    }
}