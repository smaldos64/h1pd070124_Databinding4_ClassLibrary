using Databinding4_ClassLibrary.Constants;
using Databinding4_ClassLibrary.Converters;
using System.Media;
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
using ToolsLibrary;

namespace Databinding4_ClassLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double SliderMinValue { get; } = Const.MinOctetValue;
        public static double SliderMaxValue { get; } = Const.MaxOctetValue;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCheckForValidKeyPressedPositiveInteger(object sender, KeyEventArgs e)
        {
            if (!KeyHelper.IsKeyPressedValidPositiveInteger(e.Key))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
            else
            {
                TextToBinaryConverter.LastBinaryKeyPressed = Key.Home;
            }
        }

        private void txtCheckForValidKeyPressedBinaryInteger(object sender, KeyEventArgs e)
        {
            if (!KeyHelper.IsKeyPressedValidBinaryInteger(e.Key))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
            else
            {
                TextToBinaryConverter.LastBinaryKeyPressed = Key.Home;
            }
        }

        private void btnNetworkClearOctet_Click(object sender, RoutedEventArgs e)
        {
            TextBox TextBoxToClear = (TextBox)FindName(((Button)sender).Tag.ToString());

            if (null != TextBoxToClear)
            {
                TextBoxToClear.Text = Const.NothingEnteredInTextBox;
            }
        }

        private void txtIpAddressOctetBinary_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextToBinaryConverter.LastBinaryKeyPressed = e.Key;
        }
    }
}