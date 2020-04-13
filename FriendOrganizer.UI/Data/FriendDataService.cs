using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // todo Add access to real Database
            yield return new Friend() {FirstName = "John", LastName = "Doe"};
            yield return new Friend() {FirstName = "Bart", LastName = "Kuriata"};
            yield return new Friend() {FirstName = "Simon", LastName = "Garfunkel"};

        }
    }
}
