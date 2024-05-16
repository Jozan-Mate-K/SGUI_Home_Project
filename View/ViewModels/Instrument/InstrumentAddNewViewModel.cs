using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentAddNewViewModel : ViewModelBase<Instrument>
    {
        public string Name { get; set; }
        public ICommand AddCommand { get; }
        public InstrumentAddNewViewModel()
        {
            
        }
    }
}
