﻿using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend() { FirstName = "Bart", LastName = "Kuriata" },
                new Friend() { FirstName = "Marta", LastName = "Kuriata" },
                new Friend() { FirstName = "John", LastName = "Doe" }
                );
            context.ProgrammingLanguages.AddOrUpdate(
                pl => pl.Name,
                new ProgrammingLanguage() { Name = "C#" },
                new ProgrammingLanguage() { Name = "TypeScript" },
                new ProgrammingLanguage() { Name = "F#" },
                new ProgrammingLanguage() { Name = "Swift" });
        }
    }
}
