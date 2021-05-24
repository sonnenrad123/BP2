using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class PublishingHousesTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.PublishingHouse> PublishingHouses { get; set; } = new ObservableCollection<Common.Models.PublishingHouse>();
        public PublishingHouse SelectedPublishingHouse { get => selectedPublishingHouse; set => selectedPublishingHouse = value; }

        private Common.Models.PublishingHouse selectedPublishingHouse;

        public PublishingHousesTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            PublishingHouses = new ObservableCollection<PublishingHouse>(repo.RepositoryProxy.ReadPublishingHouses());
        }
    }
}
