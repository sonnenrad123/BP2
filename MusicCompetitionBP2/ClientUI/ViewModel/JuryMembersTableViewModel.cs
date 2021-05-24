using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Common.Models;

namespace ClientUI.ViewModel
{
    public class JuryMembersTableViewModel:BindableBase
    {
        public ObservableCollection<Common.Models.JuryMember> JuryMembers { get; set; } = new ObservableCollection<Common.Models.JuryMember>();
        

        private Common.Models.JuryMember selectedJuryMember;

        private string firstNameTB = "";
        private string lastNameTB = "";
        private string jmbgTB = "";
        private DateTime birthDP = DateTime.Now;
        private string emailTB = "";

        private string phoneNoTB = "";
        private string cityTB = "";
        private string streetTB = "";
        private string numberTB = "";

        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand ModifyCommand { get; set; }

        public JuryMembersTableViewModel()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            JuryMembers = new ObservableCollection<Common.Models.JuryMember>(repo.RepositoryProxy.ReadJuryMembers());
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd, CanAdd);
            ModifyCommand = new MyICommand(OnModify, CanModify);
        }

        private bool CanModify()
        {
            return false;
        }

        private void OnModify()
        {
            throw new NotImplementedException();
        }

        private bool CanAdd()
        {
            return (long.TryParse(JmbgTB, out long x) && FirstNameTB != "" && lastNameTB != "" && birthDP != null && emailTB != "" && phoneNoTB != "" && cityTB != "" && streetTB != "" && int.TryParse(numberTB, out int n));

        }

        private void OnAdd()
        {
            int adrnum = -1;
            if (!(int.TryParse(NumberTB, out adrnum)))
            {
                System.Windows.MessageBox.Show("Address number must be a number!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            long jmbg = -1;
            if (!(long.TryParse(JmbgTB, out jmbg)))
            {
                System.Windows.MessageBox.Show("JMBG must be a number!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                var temp = JuryMembers.FirstOrDefault((x) => x.JMBG_SIN == jmbg);
                if (temp != null)
                {
                    System.Windows.MessageBox.Show("JMBG exists in database!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }

            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            repo.RepositoryProxy.AddJuryMember(new Common.Models.JuryMember(jmbg, FirstNameTB, lastNameTB, birthDP, emailTB, phoneNoTB, new Common.Models.ADDRESS(adrnum.ToString(), cityTB, streetTB)));
            RefreshTable();
        }

        private bool CanDelete()
        {
            return SelectedJuryMember != null;
        }

        private void OnDelete()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            repo.RepositoryProxy.DeleteJuryMember(selectedJuryMember.JMBG_SIN);
            RefreshTable();
        }






        public Common.Models.JuryMember SelectedJuryMember
        {
            get
            {
                return selectedJuryMember;
            }
            set
            {
                selectedJuryMember = value;
                if (selectedJuryMember != null)
                {
                    FirstNameTB = selectedJuryMember.FIRSTNAME_SIN;
                    LastNameTB = selectedJuryMember.LASTNAME_SIN;
                    JmbgTB = selectedJuryMember.JMBG_SIN.ToString();
                    BirthDP = selectedJuryMember.BIRTHDATE_SIN;
                    EmailTB = selectedJuryMember.EMAIL_SIN;
                    //AddressTB = selectedJuryMember.ADDRESS_SIN;
                    PhoneNoTB = selectedJuryMember.PHONE_NO_SIN;
                    StreetTB = selectedJuryMember.ADDRESS_SIN.STREET;
                    CityTB = selectedJuryMember.ADDRESS_SIN.CITY;
                    NumberTB = selectedJuryMember.ADDRESS_SIN.HOME_NUMBER;

                    OnPropertyChanged("FirstNameTB");
                    OnPropertyChanged("LastNameTB");
                    OnPropertyChanged("JmbgTB");
                    OnPropertyChanged("BirthDP");
                    OnPropertyChanged("EmailTB");
                    OnPropertyChanged("PhoneNoTB");
                    OnPropertyChanged("StreetTB");
                    OnPropertyChanged("CityTB");
                    OnPropertyChanged("NumberTB");
                }
                DeleteCommand.RaiseCanExecuteChanged();
                AddCommand.RaiseCanExecuteChanged();
            }
        }
        public string FirstNameTB { get => firstNameTB; set { firstNameTB = value; OnPropertyChanged("FirstNameTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string LastNameTB { get => lastNameTB; set { lastNameTB = value; OnPropertyChanged("LastNameTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string JmbgTB { get => jmbgTB; set { jmbgTB = value; OnPropertyChanged("JmbgTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public DateTime BirthDP { get => birthDP; set { birthDP = value; OnPropertyChanged("BirthDP"); AddCommand.RaiseCanExecuteChanged(); } }
        public string EmailTB { get => emailTB; set { emailTB = value; OnPropertyChanged("EmailTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string PhoneNoTB { get => phoneNoTB; set { phoneNoTB = value; OnPropertyChanged("PhoneNoTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string CityTB { get => cityTB; set { cityTB = value; OnPropertyChanged("CityTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string StreetTB { get => streetTB; set { streetTB = value; OnPropertyChanged("StreetTB"); AddCommand.RaiseCanExecuteChanged(); } }
        public string NumberTB { get => numberTB; set { numberTB = value; OnPropertyChanged("NumberTB"); AddCommand.RaiseCanExecuteChanged(); } }
        private void RefreshTable()
        {
            RepositoryCommunicationProvider repo = new RepositoryCommunicationProvider();
            JuryMembers = new ObservableCollection<Common.Models.JuryMember>(repo.RepositoryProxy.ReadJuryMembers());
            OnPropertyChanged("JuryMembers");
        }
    }
}
