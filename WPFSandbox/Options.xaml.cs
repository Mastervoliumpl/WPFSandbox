using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFSandbox
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public int NumberOfNamesAllowed { get; set; }
        public bool ClearByClick { get; set; }

        public Options(bool boolean, int numberOfNamesAllowed)
        {
            InitializeComponent();
            ClearByClick = boolean;
        }

        private void chkClearByClick_Checked(object sender, RoutedEventArgs e)
        {
            ClearByClick = true;
        }

        private void chkClearByClick_Unchecked(object sender, RoutedEventArgs e)
        {
            ClearByClick = false;
        }

        private void txtAmountOfNames_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(txtAmountOfNames.Text, out int result))
            {
                NumberOfNamesAllowed = result;
            }
        }
    }
}
