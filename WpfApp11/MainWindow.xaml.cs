using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void przyciskOk_Click(object sender, RoutedEventArgs e)
        {
            string koloroczu;
            if (kolorNiebieski.IsChecked == true)
            {

                koloroczu = "Niebieski";

            }
            else if (kolorPiwne.IsChecked == true)
            {
                koloroczu = "Piwne";
            }
            else if (kolorZielony.IsChecked == true)
            {
                koloroczu = "Zielony";
            }
            if (imieText.Text == "" || naziwskoText.Text == "")
            {
                MessageBox.Show("Uzupełnij dane");
            }
            else
            {
                MessageBox.Show($"{imieText.Text} {naziwskoText.Text} {numerText.Text}");
            }


        }

        private void numerText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            /* if (imieText)
             {
                 MessageBox.Show($"{imieText.Text} {numerText.Text} {naziwskoText.Text}")
             }
             else
             {
                 MessageBox.Show("Wprowadź Dane!");
             }
            

            if (kolorNiebieski.IsChecked == true)
            {

                koloroczu = "Niebieski";

            }
            else if (kolorPiwne.IsChecked == true)
            {
                koloroczu = "Piwne";
            }
            else if (kolorZielony.IsChecked == true)
            {
                koloroczu = "Zielony";
            }
            if (imieText.Text == "" || naziwskoText.Text =="")
            {
                MessageBox.Show("Uzupełnij dane");
            }
            else
            {
                MessageBox.Show($"{imieText.Text} {naziwskoText.Text} {numerText.Text}");
            }

            */
          
        }
    }
}