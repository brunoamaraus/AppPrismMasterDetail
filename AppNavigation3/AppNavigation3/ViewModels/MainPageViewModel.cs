using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNavigation3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand FirstCommend { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
            FirstCommend = new DelegateCommand(StartFirstPage);
        }

        private void StartFirstPage()
        {
            _navigationService.NavigateAsync("FirstPage");
        }
    }
}
