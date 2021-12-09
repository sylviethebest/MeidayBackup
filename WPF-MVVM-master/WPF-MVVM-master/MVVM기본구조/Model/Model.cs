using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM기본구조
{
    class Model : INotifyPropertyChanged
    {
        private string NAME_;

        public string NAME
        {
            get { return this.NAME_; }
            set
            {
                this.NAME_ = value;
                this.OnPropertyChanged("NAME");
            }
        }

        // 이 함수 굉장히 중요
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
                catch { }
            }
        }

        public Model()
        {

        }

    }
}
