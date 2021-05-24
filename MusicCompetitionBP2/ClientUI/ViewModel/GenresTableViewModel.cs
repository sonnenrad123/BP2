using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class GenresTableViewModel:BindableBase
    {
        public static ObservableCollection<Common.Models.Genre> Genres { get; set; } = new ObservableCollection<Common.Models.Genre>();
        public Genre SelectedGenre { get => selectedGenre; set => selectedGenre = value; }

        private Common.Models.Genre selectedGenre;
        public GenresTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            Genres = new ObservableCollection<Genre>(repo.RepositoryProxy.ReadGenres());
        }
    }
}
