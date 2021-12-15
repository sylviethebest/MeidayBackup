using System.Windows.Input;
using System.Windows;
using Telerik.Windows.Controls;

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

        private bool _isChecked = false;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
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
            if(SwitchView == 3 && _isChecked == false)
            {
                SwitchView = 2;
                MessageBox.Show("개인정보 동의가 필요합니다.", "알림", MessageBoxButton.OK, MessageBoxImage.Information);
                /*                RadWindow rad = new RadWindow();
                                rad.Content = "개인정보 동의가 필요합니다.";
                                rad.HorizontalAlignment = HorizontalAlignment.Center;
                                rad.VerticalAlignment = VerticalAlignment.Center;
                                rad.HorizontalContentAlignment = HorizontalAlignment.Center;
                                rad.VerticalContentAlignment = VerticalAlignment.Center;
                                rad.Left = 500;
                                rad.Top = 300;
                                rad.Width = 300;
                                rad.Height = 150;
                                rad.Show();*/
            }
            if (SwitchView == 2)
            {
                _isChecked = false;
            }
        }
    }
}
