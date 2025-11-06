using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Produkt> ProduktList { get; set; }
        public List<string>kategorieProduktow {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ProduktList=new ObservableCollection<Produkt>();
            ProduktList.Add(new Produkt("mleko", "nabial"));
            ProduktList.Add(new Produkt("chleb", "pieczywo"));
            ProduktList.Add(new Produkt("jablka", "owoce"));
            ProduktList.Add(new Produkt("gruszka", "owoce"));

            kategorieProduktow= new List<String>();
            kategorieProduktow.Add("nabial");
            kategorieProduktow.Add("owoce");
            kategorieProduktow.Add("pieczywo");
            
           kategoria.ItemsSource=kategorieProduktow;
           kategoriaa.ItemsSource=kategorieProduktow;
            DataContext = this;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string nazwa = nazwaTextBox.Text;
            string kategoria = kategoriaa.Text;
            if (dostepnosc.IsChecked == true)
            {
                ProduktList.Add(new Produkt(nazwa, kategoria));
            }
            else
            {
                ProduktList.Add(new Produkt(nazwa, kategoria));
            }
        }
    }
}
