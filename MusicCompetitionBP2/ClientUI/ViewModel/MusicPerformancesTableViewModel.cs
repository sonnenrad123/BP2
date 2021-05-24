using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class MusicPerformancesTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.MusicPerformance> MusicPerformances { get; set; } = new ObservableCollection<Common.Models.MusicPerformance>();
        public MusicPerformance SelectedMusicPerformance { get => selectedMusicPerformance; set => selectedMusicPerformance = value; }

        private Common.Models.MusicPerformance selectedMusicPerformance;

        public MusicPerformancesTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            MusicPerformances = new ObservableCollection<MusicPerformance>(repo.RepositoryProxy.ReadMusicPerformances());
        }
    }
}
