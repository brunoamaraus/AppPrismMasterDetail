using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppNavigation3.ViewModels
{
    public class MyMasterDetailViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand FirstCommand { get; set; }

        public MyMasterDetailViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            FirstCommand = new DelegateCommand(StartFirstPage);
        }

        private void StartFirstPage()
        {
            _navigationService.NavigateAsync("MyMasterDetail/MyNavigation/FirstPage");
        }
    }
}