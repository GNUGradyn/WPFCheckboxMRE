using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class LotsOfCheckboxes : INotifyPropertyChanged
    {
        private bool _test1 = false;
        private bool _test2 = false;
        private bool _test3 = false;
        private bool _test4 = false;
        private bool _test5 = false;

        public bool Test1
        {
            get
            {
                return _test1;
            }
            set
            {
                _test1 = value;
                OnPropertyChanged(nameof(Test1));
            }
        }
        public bool Test2
        {
            get
            {
                return _test2;
            }
            set
            {
                _test2 = value;
                OnPropertyChanged(nameof(Test2));
            }
        }
        public bool Test3
        {
            get
            {
                return _test3;
            }
            set
            {
                _test3 = value;
                OnPropertyChanged(nameof(Test3));
            }
        }
        public bool Test4
        {
            get
            {
                return _test4;
            }
            set
            {
                _test4 = value;
                OnPropertyChanged(nameof(Test4));
            }
        }
        public bool Test5
        {
            get
            {
                return _test5;
            }
            set
            {
                _test5 = value;
                OnPropertyChanged(nameof(Test5));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
