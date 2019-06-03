using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BasicWPFDataBinding
{
    public class MyData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public MyData()
        {
            Name = "Tom";
        }

        private string _Name;
        public string Name
        {
            set
            {
                _Name = value;

                if (PropertyChanged != null)
                {
                    // 引发PropertyChanged事件，
                    // PropertyChangedEventArgs构造方法中的参数字符串表示属性名
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get
            {
                return _Name;
            }
        }
    }
}
