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

namespace WpfApp2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string telephone = telNameTextBox.Text;
            string message = $"Name: {name}\nTelephone: {telephone}";
            MessageBox.Show(message, "我的資訊", MessageBoxButton.OK);      

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void computeButton_Click_2(object sender, RoutedEventArgs e)
        {
            int n= int.Parse(numberTextBox.Text);

            string result = "";
            for(int i=1;i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    result += $"{i}*{j}={i * j}\t";
                result += "\n";
            

            }
            resultTestBlock.Text = result;


        }
        }
}