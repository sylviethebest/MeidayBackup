using System.Windows.Input;

namespace TelerikWpfApp1
{
    public class MainViewModel : ViewModelBase
    {
        private int switchView;
        public int SwitchView
        {
            get
            {
                return switchView;
            }
            set
            {
                switchView = value;
                OnPropertyChanged("SwitchView");
            }
        }

        public ICommand SwitchViewCommand { get; }

        public MainViewModel()
        {
            SwitchView = 0;

            SwitchViewCommand = new RelayCommand<object>(p => OnSwitchView(p));
        }

        private void OnSwitchView(object index)
        {
            SwitchView = int.Parse(index.ToString());
        }
    }
}
