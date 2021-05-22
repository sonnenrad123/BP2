using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.ViewModel
{
    public class CompetitorsTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.Competitor> Competitors { get; set; } = new ObservableCollection<Common.Models.Competitor>();

        private Common.Models.Competitor selectedCompetitor;


        public CompetitorsTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            Competitors = new ObservableCollection<Common.Models.Competitor>(repo.RepositoryProxy.ReadCompetitors());
            
        }

        public Common.Models.Competitor SelectedCompetitor
        {
            get
            {
                return selectedCompetitor;
            }
            set
            {
                selectedCompetitor = value;
            }
        }

    }
}
