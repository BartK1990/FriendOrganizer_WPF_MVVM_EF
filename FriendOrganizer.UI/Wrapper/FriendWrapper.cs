using System;
using System.Security.Permissions;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Wrapper
{
    public class FriendWrapper : ModelWrapper<Friend>
    {
        public FriendWrapper(Friend model) : base(model)
        {
        }

        public int Id => Model.Id;

        public string FirstName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
                ValidateProperty(nameof(FirstName));
            }
        }

        private void ValidateProperty(string propertyName)
        {
            ClearErrors(propertyName);
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        AddError(propertyName, "Robots are not valid friends");
                    }
                    break;
            }
        }

        public string LastName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }
    }
}
