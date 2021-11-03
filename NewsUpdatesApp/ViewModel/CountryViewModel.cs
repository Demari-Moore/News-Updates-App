using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WorldNewsDM.Models;
using WorldNewsDM.Services;

namespace WorldNewsDM.ViewModel
{
    class CountryViewModel : ViewModelBase
    {
        static CountryViewModel _this = new CountryViewModel();

        public static CountryViewModel This
        {
            get { return _this; }
        }
        public void Initialise()
        {
            PopulateCountries();
        }
        private void PopulateCountries()
        {
            _Countries = JsonLoader.LoadCountryJsonFromFile();
            SelectedCountry= _Countries.Where(c => c.Code.ToUpper() == "AR").FirstOrDefault();
        }

        private ObservableCollection<Country> _Countries;
        public ObservableCollection<Country> Countries
        {
            get => _Countries;
            set
            {
                if (_Countries != value)
                {
                    _Countries = value;
                    OnPropertyChanged();
                }
            }
        }

        private Country _SelectedCountry;
        public Country SelectedCountry
        {
            get => _SelectedCountry;
            set
            {
                if (_SelectedCountry != value)
                {
                    _SelectedCountry = value;
                    OnPropertyChanged();

                    Application.Current.Dispatcher.InvokeAsync(async () => { NewsViewModel.This.News =  await JsonLoader.GetNewsJsonFromUrl(_SelectedCountry); });

                }
            }
        }

    }
}
