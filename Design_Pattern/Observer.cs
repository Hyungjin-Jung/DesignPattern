using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;  // 속성 변경 알림 이벤트

        protected virtual void OnPropertyChanged(string propertyName)  // 속성 변경 알림을 발생시키는 메서드
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MyModel : ObservableObject
    {
        private string _myProperty;  // private 필드

        public string MyProperty  // public 속성
        {
            get { return _myProperty; }
            set
            {
                if (_myProperty != value)  // 값이 변경되었을 때만
                {
                    _myProperty = value;  // 필드 값을 업데이트하고
                    OnPropertyChanged("MyProperty");  // 속성 변경 알림을 발생
                }
            }
        }
    }
}
