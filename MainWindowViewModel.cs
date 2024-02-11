using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private LotsOfCheckboxes[] _tableObjects;
        public LotsOfCheckboxes[] TableObjects
        {
            get { return _tableObjects; }
            set
            {
                _tableObjects = value;
                OnPropertyChanged(nameof(TableObjects));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
