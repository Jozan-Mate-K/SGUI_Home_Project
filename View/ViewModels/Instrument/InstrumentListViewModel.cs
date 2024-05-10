using Connectors;
using Models;
using SGUI_Home_Project.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentListViewModel: ViewModelBase<Instrument>
    {
        private InstrumentListView view;

        public InstrumentListViewModel(InstrumentListView view)
        {
            connect = new InstrumentConnect();
            Items = new ObservableCollection<Instrument>(connect.GetAll());
            this.view = view;
            view.lstView.ItemsSource = Items;
        }
    }
}
