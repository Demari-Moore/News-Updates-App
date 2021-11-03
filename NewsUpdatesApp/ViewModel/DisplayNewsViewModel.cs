using System;

namespace WorldNewsDM.ViewModel
{
    class DisplayNewsViewModel : ViewModelBase
    {
        static DisplayNewsViewModel _this = new DisplayNewsViewModel();
        public static DisplayNewsViewModel This
        {
            get { return _this; }
        }
        public void Initialise()
        {
            
        }

        private Uri _NewsSource;
        public Uri NewsSource
        {
            get => _NewsSource;
            set
            {
                if (_NewsSource != value)
                {
                    _NewsSource = value;
                    OnPropertyChanged();

                }
            }
        }
    }
}
