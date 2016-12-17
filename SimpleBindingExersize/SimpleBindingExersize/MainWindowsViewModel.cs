using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBindingExersize
{
    public class MainWindowsViewModel
    {
        public ObservableCollection<string> ListaStringova { get; set; }
        public MainWindowsViewModel()
        {
            ListaStringova = new ObservableCollection<string>();
        }
    }
}
