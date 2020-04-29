namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationItemViewModel : ViewModelBase
    {
        public int Id { get; }

        public NavigationItemViewModel(string displayMember, int id)
        {
            DisplayMember = displayMember;
            Id = id;
        }

        private string _displayMember;
        public string DisplayMember
        {
            get => _displayMember;
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }
    }
}
