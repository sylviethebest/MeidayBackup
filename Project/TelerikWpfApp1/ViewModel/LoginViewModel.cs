﻿using System.ComponentModel;
using System.Windows.Input;
namespace TelerikWpfApp1
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        //아래 두 필드는 속성으로 구현되어 있다. //출력될 문자들을 담아둘 변수
        string inputString = string.Empty;
        //계산기 화면의 출력 텍스트박스에 대응되는 필드
        string displayText = "";
        //View와 바인딩된 속성값이 바뀔때 이를 WPF에게 알리기 위한 이벤트
        public event PropertyChangedEventHandler PropertyChanged;
        //생성자, 명령 객체들을 초기화 //명령 객체들은 UI쪽 버튼의 Command에 바인딩되어 있다.
        public LoginViewModel()
        {
            //이벤트 핸들러 정의 
            //숫자 버튼을 클릭할 때 실행
            this.Append = new Append(this);
            //백 스페이스 버튼을 클릭할 때 실행, 한글자 삭제
            this.BackSpace = new BackSpace(this);
        }
        public string InputString
        {
            internal set
            {
                if (inputString != value)
                {
                    inputString = value; OnPropertyChanged("InputString"); if (value != "")
                    {
                        DisplayText = value;
                    }
                }
            }
            get { return inputString; }
        }

        /// <summary> 
        ///  계산기의 출력창과 바인딩된 속성 
        ///  </summary>

        public string DisplayText // 읽기전용?
        {
            internal set
            {
                if (displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");
                }
            }
            get
            {
                return displayText;
            }
        }
        public ICommand Append { protected set; get; }
        public ICommand BackSpace { protected set; get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}








