using System;
using System.Collections.ObjectModel;
using WorldNewsDM.Views;

namespace WorldNewsDM.ViewModel
{
    public class NewsViewModel:ViewModelBase
    {
        static NewsViewModel _this = new NewsViewModel();
        static NewsDisplay newsDisplay = new NewsDisplay();

        public static NewsViewModel This
        {
            get { return _this; }
        }
        public void Initialise()
        {
           
        }

        private ObservableCollection<News> _News;
        public ObservableCollection<News> News
        {
            get => _News;
            set
            {
                if (_News != value)
                {
                    _News = value;
                    OnPropertyChanged();
                }
            }
        }

        private News _SelectedNews;
        public News SelectedNews
        {
            get => _SelectedNews;
            set
            {
                if (_SelectedNews != value)
                {
                    _SelectedNews = value;
   
                    if (_SelectedNews?.Url != null)
                    {
                        DisplayNewsViewModel.This.NewsSource = new Uri(_SelectedNews?.Url);
                      
                        newsDisplay.Show();
                        newsDisplay.Topmost = true;
                    }
             
                    OnPropertyChanged();
                }
            }
        }
    }
}
