﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendLookupDataService : IFriendLookupDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendLookupDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking()
                    .Select(f =>
                        new LookupItem()
                        {
                            Id = f.Id,
                            DisplayMember = f.FirstName + " " + f.LastName
                        })
                    .ToListAsync();
            }
        }
    }
}