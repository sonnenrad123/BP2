using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class CompetitionsTableViewModel : BindableBase
    {
        public static ObservableCollection<Common.Models.Competition> Competitions { get; set; } = new ObservableCollection<Common.Models.Competition>();
        public Competition SelectedCompetition { get => selectedCompetition; set => selectedCompetition = value; }

        private Common.Models.Competition selectedCompetition;

        public CompetitionsTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            Competitions = new ObservableCollection<Competition>(repo.RepositoryProxy.ReadCompetitions());
        }

    }
}
