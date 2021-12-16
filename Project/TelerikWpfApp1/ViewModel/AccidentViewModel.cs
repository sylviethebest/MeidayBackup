using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace TelerikWpfApp1.ViewModel
{
    public class AccidentViewModel : ViewModelBase
    {
        private DateTime _accidentTodayDateTime = DateTime.Now;
        public DateTime AccidentTodayDateTime
        {
            get => _accidentTodayDateTime;
            set
            {
                _accidentTodayDateTime = value;
                NotifyPropertyChanged(nameof(AccidentTodayDateTime));
            }
        }

        private DateTime _accidentSelectedDateTime = DateTime.Now;
        public DateTime AccidentSelectedDateTime
        {
            get => _accidentSelectedDateTime;
            set
            {
                _accidentSelectedDateTime = value;
                NotifyPropertyChanged(nameof(AccidentSelectedDateTime));
            }
        }

        // 실비보험 청구 가능기간 (3년) 제한
        private DateTime _accidentLimitedDateTime = DateTime.Today.AddYears(-3);
        public DateTime AccidentLimitedDateTime
        {
            get => _accidentLimitedDateTime;
            set
            {
                _accidentLimitedDateTime = value;
                NotifyPropertyChanged(nameof(AccidentLimitedDateTime));
            }
        }

        // 환자 이름 query문으로 넣기
        private DateTime _accidentPatientName; // = 이름
        public DateTime AccidentPatientName
        {
            get => _accidentPatientName;
            set
            {
                _accidentPatientName = value;
                NotifyPropertyChanged(nameof(AccidentPatientName));
            }
        }

        private bool _accidentTypeDisease;
        public bool AccidentTypeDisease
        {
            get => _accidentTypeDisease;
            set
            {
                _accidentTypeDisease = value;
                NotifyPropertyChanged(nameof(AccidentTypeDisease));
            }
        }

        private bool _accidentTypeInjury;
        public bool AccidentTypeInjury
        {
            get => _accidentTypeInjury;
            set
            {
                _accidentTypeInjury = value;
                NotifyPropertyChanged(nameof(AccidentTypeInjury));
            }
        }

        private bool _accidentTypeCar;
        public bool AccidentTypeCar
        {
            get => _accidentTypeCar;
            set
            {
                _accidentTypeCar = value;
                NotifyPropertyChanged(nameof(AccidentTypeCar));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
