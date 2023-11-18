using System.Windows;

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

        private void Label_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($@"Product Name : Sprite ", "Information" , MessageBoxButton.OK , MessageBoxImage.Information );


        }

        private void ButtonCola_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($@"Product Name : Cola ", "Information" , MessageBoxButton.OK , MessageBoxImage.Information );
            
        }

        private void Fanta_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($@"Product Name : Fanta  ", "Information" , MessageBoxButton.OK , MessageBoxImage.Information );
        }

        private void TextBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (true)
            {
                text_search.Clear();

                text_search.Focus();
            }
        }

        private void text_search_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            text_search.Text = null;
            text_search.Text = "Search..";
        }
    }
}
