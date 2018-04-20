using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppNavigation3.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
            LoginCommand = new DelegateCommand(StartLogin);
        }

        private void StartLogin()
        {
            _navigationService.NavigateAsync("../MainPage");
        }
    }
}