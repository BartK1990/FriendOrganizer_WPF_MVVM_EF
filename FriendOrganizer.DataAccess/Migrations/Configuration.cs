using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Bart", LastName = "Kuriata" },
                new Friend { FirstName = "Marta", LastName = "Kuriata" },
                new Friend { FirstName = "John", LastName = "Doe" }
                );
            context.ProgrammingLanguages.AddOrUpdate(
                pl => pl.Name,
                new ProgrammingLanguage { Name = "C#" },
                new ProgrammingLanguage { Name = "TypeScript" },
                new ProgrammingLanguage { Name = "F#" },
                new ProgrammingLanguage { Name = "Swift" });

            context.SaveChanges();

            context.FriendPhoneNumbers.AddOrUpdate(
                pn => pn.Number,
                new FriendPhoneNumber { Number = "+48 12345678", FriendId = context.Friends.First().Id });

            context.Meetings.AddOrUpdate(
                m => m.Title,
                new Meeting
                {
                    Title = "Watching Soccer",
                    DateFrom = new DateTime(2020, 05, 25),
                    DateTo = new DateTime(2020, 05, 25),
                    Friends = new List<Friend>
                    {
                        context.Friends.Single(f => f.FirstName == "Bart" && f.LastName == "Kuriata"),
                        context.Friends.Single(f => f.FirstName == "Marta" && f.LastName == "Kuriata")
                    }
                });
        }
    }
}
