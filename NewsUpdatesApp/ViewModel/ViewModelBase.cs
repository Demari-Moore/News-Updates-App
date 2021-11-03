using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WorldNewsDM.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            try
            {
                var handler = PropertyChanged;
                if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
            }
        }
    }
}
