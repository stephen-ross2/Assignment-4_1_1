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

namespace Assignment_4_1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            persons = MockData.CreateData();
            ContactData.ItemsSource = persons.Values;
        }
    }

    private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (Person.TryGetValue(txtSearch.Text, out Person contact))
            {
                dataGrid2.ItemSource = contact;
            }

            else
            {
                MessageBox.Show("Contact not found");
            }
        }
    }
}