using System.Windows;
using WorldNewsDM.ViewModel;

namespace WorldNewsDM.Views
{
    public partial class NewsDisplay : Window
    {
        public NewsDisplay()
        {
            InitializeComponent();
        }

        private void DisplayNewsViewControlFunc(object sender, RoutedEventArgs e)
        {
            DisplayNewsViewModel.This.Initialise();
            DisplayNewsViewControl.DataContext = DisplayNewsViewModel.This;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
            DisplayNewsViewControl.wbArticle.Navigate("about:blank");
        }

    }
}
