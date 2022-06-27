using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WPF_Study
{
    class Model : Abstractions.IModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
        
    }
}
