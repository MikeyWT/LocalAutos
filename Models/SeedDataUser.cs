using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;



namespace LocalAutos.Models
{
    public static class SeedDataTwo
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutoContext(
                serviceProvider.GetRequiredService<DbContextOptions<AutoContext>>())
)
            {
                // Look for any Automobiles.
                if (context.UserNew.Any())
                {
                    return; // DB has been seeded
                }
                
                context.UserNew.AddRange(
                    new User
                    {
                        UserID = 1,
                        FirstName = "Tim",
                        LastName = "Booth",
                        Location = "Pampa",          //Seed data for UserID 1
                        UserName = "IceeStorm2"

                    },


                    new User
                    {
                        UserID = 2,
                        FirstName = "Matthew",
                        LastName = "Strickland",
                        Location = "Canyon",          //Seed data for UserID 2
                        UserName = "GrassyBoots"
                        
                    },


                    new User
                    {
                        UserID = 3,
                        FirstName = "Brendan",
                        LastName = "Cobb",
                        Location = "Lubbock",          //Seed data for UserID 3
                        UserName = "WishinForFishin34"

                    },

                    new User
                    {
                        UserID = 4,
                        FirstName = "Amy",
                        LastName = "Sanchez",
                        Location = "Memphis",          //Seed data for UserID 4
                        UserName = "ASanchez454"

                    },


                    new User
                    {
                        UserID = 5,
                        FirstName = "Dawn",
                        LastName = "Hatfield",
                        Location = "Pampa",          //Seed data for UserID 5
                        UserName = "NewDawn"
                        
                    },


                    new User
                    {
                        UserID = 6,
                        FirstName = "James",
                        LastName = "Rice",
                        Location = "Canyon",          //Seed data for UserID 6
                        UserName = "GuyWithTheCats"

                    },

                    new User
                    {
                        UserID = 7,
                        FirstName = "Elizabeth",
                        LastName = "Blackburn",
                        Location = "Amarillo",          ///Seed data for UserID 7
                        UserName = "LostZebra"

                    },


                    new User
                    {
                        UserID = 8,
                        FirstName = "Christopher",
                        LastName = "Fowler",
                        Location = "Lubbock",          //Seed data for UserID 8
                        UserName = "WildChris"
                        
                    },


                    new User
                    {
                        UserID = 9,
                        FirstName = "Isaac",
                        LastName = "Ferguson",
                        Location = "Plainview",          //Seed data for UserID 9
                        UserName = "TheFerg44"

                    },

                    new User
                    {
                        UserID = 10,
                        FirstName = "Anna",
                        LastName = "Barnes",
                        Location = "Pampa",          //Seed data for UserID 10
                        UserName = "SunnyAnna"

                    },


                    new User
                    {
                        UserID = 11,
                        FirstName = "Cathy",
                        LastName = "Tran",
                        Location = "Canyon",         //Seed data for UserID 11
                        UserName = "ChattyCathy"
                        
                    },


                    new User
                    {
                        UserID = 12,
                        FirstName = "Paul",
                        LastName = "Silvas",
                        Location = "Pampa",          //Seed data for UserID 12
                        UserName = "TradeMyCar"

                    },

                    new User
                    {
                        UserID = 13,
                        FirstName = "Michael",
                        LastName = "Miller",
                        Location = "Canyon",          //Seed data for UserID 13
                        UserName = "MillerTime"

                    },


                    new User
                    {
                        UserID = 14,
                        FirstName = "Susan",
                        LastName = "Trevino",
                        Location = "Amarillo",          //Seed data for UserID 14
                        UserName = "DoctorSus"
                        
                    },


                    new User
                    {
                        UserID = 15,
                        FirstName = "Cody",
                        LastName = "Burton",
                        Location = "Childress",         //Seed data for UserID 15
                        UserName = "ChillinCodyBurt"

                    },

                    new User
                    {
                        UserID = 16,
                        FirstName = "Maria",
                        LastName = "Bridges",
                        Location = "Happy",          //Seed data for UserID 16
                        UserName = "MyMaria23"

                    },


                    new User
                    {
                        UserID = 17,
                        FirstName = "Jennifer",
                        LastName = "Bennett",
                        Location = "Pampa",         //Seed data for UserID 17
                        UserName = "JenniBenne"
                        
                    },


                    new User
                    {
                        UserID = 18,
                        FirstName = "Laurie",
                        LastName = "Smith",
                        Location = "Canyon",          //Seed data for UserID 18
                        UserName = "LoudLaurie054"

                    },

                    new User
                    {
                        UserID = 19,
                        FirstName = "Isaac",
                        LastName = "Philips",
                        Location = "Lubbock",          //Seed data for UserID 19
                        UserName = "CarGuy12"

                    },


                    new User
                    {
                        UserID = 20,
                        FirstName = "David",
                        LastName = "Nunez",
                        Location = "Canyon",          //Seed data for UserID 20
                        UserName = "DreaminDave"
                        
                    },


                    new User
                    {
                        UserID = 21,
                        FirstName = "Ann",
                        LastName = "Allen",
                        Location = "Pampa",          //Seed data for UserID 21
                        UserName = "AwesomeAnn42"

                    },

                    new User
                    {
                        UserID = 22,
                        FirstName = "Mitchell",
                        LastName = "Harper",
                        Location = "Canyon",          //Seed data for UserID 22
                        UserName = "MightyMitch"

                    },


                    new User
                    {
                        UserID = 23,
                        FirstName = "Miguel",
                        LastName = "Love",
                        Location = "Amarillo",         //Seed data for UserID 23
                        UserName = "CarsandLove"
                        
                    },


                    new User
                    {
                        UserID = 24,
                        FirstName = "Abigail",
                        LastName = "Neal",
                        Location = "Pampa",          //Seed data for UserID 24
                        UserName = "WildAbi"

                    },



                    new User
                    {
                        UserID = 25,
                        FirstName = "Claire",
                        LastName = "Hall",
                        Location = "Canyon",          //Seed data for UserID 25
                        UserName = "ClaireHall12"

                        
                    }



                );
                
                context.SaveChanges();
            }
        }
    }
}