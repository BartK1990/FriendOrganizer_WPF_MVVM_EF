using System.Windows;
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI
{
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var bootstraper = new Bootstrapper();
            var container = bootstraper.Bootstrap();

            // var mainWindow = new MainWindow(new MainViewModel(new FriendDataService()));
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
