using System.Windows;
using WorldNewsDM.ViewModel;

namespace WorldNewsDM
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CountryViewControlFunc(object sender, RoutedEventArgs e)
        {
            CountryViewModel.This.Initialise();
            CountryViewControl.DataContext = CountryViewModel.This;
        }
        private void NewsViewControlFunc(object sender, RoutedEventArgs e)
        {
            NewsViewModel.This.Initialise();
            NewsViewControl.DataContext = NewsViewModel.This;
        }
    }
}
