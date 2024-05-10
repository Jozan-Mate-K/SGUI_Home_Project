using Connectors;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.ViewModels
{
    public class ViewModelBase<T> : INotifyPropertyChanged where T: class 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected ObservableCollection<T> Items { get; set; } = new ObservableCollection<T>();
        protected IConnect<T> connect;

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
