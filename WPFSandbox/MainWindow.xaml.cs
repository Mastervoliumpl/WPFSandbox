using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<string> lstNames { get; set; } = new List<string>();
        private Options options;
        public MainWindow()
        {
            InitializeComponent();
            options = new(true, 6);
        }

        private void ClearList() => lstNames.Items.Clear();

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text) && lstNames.Items.Count < options.NumberOfNamesAllowed)
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                ClearList();
            }
        }

        private void ButtonClearNames_Click(object sender, RoutedEventArgs e)
        {
            ClearList();
        }

        private void lstNames_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (options.ClearByClick)
            {
                ClearList();
            }           
        }

        private void ButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            options.Show();
        }
    }
}