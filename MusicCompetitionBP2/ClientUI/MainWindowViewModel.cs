﻿using ClientUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI
{
    public class MainWindowViewModel: BindableBase
    {
        public MyICommand<string> MenuCommand { get; private set; }
       
        public MyICommand BackCommand { get; set; }
        public MyICommand BackToHome { get; set; }

        private BindableBase currentViewModel;
        private MainMenuViewModel MainMenu;
        //private CompetitorsTableViewModel competitorsTable = new CompetitorsTableViewModel();



        //Lista u kojoj se cuvaju izvrsene akcije
        public static List<Akcija> akcije = new List<Akcija>();


       


        public MainWindowViewModel()
        {
            MainMenu = new MainMenuViewModel(this);
            CurrentViewModel = MainMenu;
            MenuCommand = new MyICommand<string>(Navigate);
            BackToHome = new MyICommand(Home);
            BackCommand = new MyICommand(Back);
        }


        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }


        public void Home()
        {
            CurrentViewModel = MainMenu;
        }


        private void Back()
        {

        }


        public void Navigate(string view)
        {
            akcije.Add(new Akcija("Navigacija", currentViewModel));//cuvamo prethodni view
            switch (view)
            {
                case "Competitors":
                    CurrentViewModel = new CompetitorsTableViewModel();
                    break;
                case "JuryMembers":

                    break;
                case "Competitions":

                    break;
                case "Genres":

                    break;
                case "PublishingHouses":

                    break;
                case "PerformanceHalls":

                    break;
                case "MusicPerformances":

                    break;
            }
        }
    }
}