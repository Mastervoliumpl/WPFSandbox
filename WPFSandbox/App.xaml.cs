using System.Configuration;
using System.Data;
using System.Windows;

namespace WPFSandbox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MainWindow window = new MainWindow();
            // Do stuff here, e.g. to the window
            window.Title = "WPF Names";
            // Show the window
            window.Show();
        }
    }
}
