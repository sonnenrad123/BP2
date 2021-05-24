using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class PerformanceHallsTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.PerformanceHall> PerformanceHalls { get; set; } = new ObservableCollection<Common.Models.PerformanceHall>();
        public PerformanceHall SelectedPerformanceHall { get => selectedPerformanceHall; set => selectedPerformanceHall = value; }

        private Common.Models.PerformanceHall selectedPerformanceHall;

        public PerformanceHallsTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            PerformanceHalls = new ObservableCollection<PerformanceHall>(repo.RepositoryProxy.ReadPerformanceHalls());
        }
    }
}
