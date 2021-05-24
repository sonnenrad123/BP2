using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class JuryMembersTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.JuryMember> JuryMembers { get; set; } = new ObservableCollection<Common.Models.JuryMember>();
        public JuryMember SelectedJuryMember { get => selectedJuryMember; set => selectedJuryMember = value; }

        private Common.Models.JuryMember selectedJuryMember;

        public JuryMembersTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            JuryMembers = new ObservableCollection<Common.Models.JuryMember>(repo.RepositoryProxy.ReadJuryMembers());
        }



    }
}
