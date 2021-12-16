using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace TelerikWpfApp1
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
                OnPropertyChanged(nameof(AccidentTodayDateTime));
            }
        }

        private DateTime _accidentSelectedDateTime = DateTime.Now;
        public DateTime AccidentSelectedDateTime
        {
            get => _accidentSelectedDateTime;
            set
            {
                _accidentSelectedDateTime = value;
                OnPropertyChanged(nameof(AccidentSelectedDateTime));
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
                OnPropertyChanged(nameof(AccidentLimitedDateTime));
            }
        }

        // 환자 이름 query문으로 넣기
        private string _accidentPatientName = "홍길동"; // = 이름
        public string AccidentPatientName
        {
            get => _accidentPatientName;
            set
            {
                _accidentPatientName = value;
                OnPropertyChanged(nameof(AccidentPatientName));
            }
        }

        private bool _accidentTypeDisease;
        public bool AccidentTypeDisease
        {
            get => _accidentTypeDisease;
            set
            {
                _accidentTypeDisease = value;
                OnPropertyChanged(nameof(AccidentTypeDisease));
            }
        }

        private bool _accidentTypeInjury;
        public bool AccidentTypeInjury
        {
            get => _accidentTypeInjury;
            set
            {
                _accidentTypeInjury = value;
                OnPropertyChanged(nameof(AccidentTypeInjury));
            }
        }

        private bool _accidentTypeCar;
        public bool AccidentTypeCar
        {
            get => _accidentTypeCar;
            set
            {
                _accidentTypeCar = value;
                OnPropertyChanged(nameof(AccidentTypeCar));
            }
        }

        private string _insuranceCompany = "메리츠"; // = 이름
        public string InsuranceCompanyName
        {
            get => _insuranceCompany;
            set
            {
                _insuranceCompany = value;
                OnPropertyChanged(nameof(InsuranceCompanyName));
            }
        }

        private string _insuranceProduct = "실비보험"; // = 이름
        public string InsuranceProduct
        {
            get => _insuranceProduct;
            set
            {
                _insuranceProduct = value;
                OnPropertyChanged(nameof(InsuranceProduct));
            }
        }
    }
}
