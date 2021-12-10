using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM기본구조
{

    class ModelView : INotifyPropertyChanged
    {
        public RelayCommand AddCommand { get; set; }//중요

        private ObservableCollection<Model> ROOT_;

        public ObservableCollection<Model> ROOT
        {
            get
            {
                return ROOT_;
            }
            set
            {
                this.ROOT_ = value;
                this.OnPropertyChanged("RCP");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
                catch
                {
                }
            }
        }
        public ModelView()
        {
            this.ROOT = new ObservableCollection<Model>();
            this.AddCommand = new RelayCommand(AddExecuted, AddCanExecuted);
        }
        private bool AddCanExecuted(Object param)
        {
            bool ret = false;
            ret = true;
            return ret;
        }
        private void AddExecuted(object param)
        {
            this.ROOT.Add(new Model() { NAME = "TEST" }); //버튼 누르면 바로 AddExecuted가 실행됨 //단, AddCanExecuted가 true 일 때만 
        }

    }
}
