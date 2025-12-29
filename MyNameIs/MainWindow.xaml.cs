using System.Windows;

namespace MyNameIs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database database;

        public MainWindow()
        {
            InitializeComponent();
            database = new Database();
            persons.ItemsSource = database.GetAll().ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Either name or email was empty");
                return;
            }
            var full_name_and_email = $"name: {name.Text}, email {email.Text}";
            MessageBox.Show($"Hello, {full_name_and_email}");
            database.Insert(name.Text, email.Text);
            persons.ItemsSource = database.GetAll().ToList();
        }


    }
}