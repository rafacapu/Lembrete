using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lembrete.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        #region Global
        INavigationService _navigationService;

        #endregion

        #region Command
        public DelegateCommand ClickNavigationCommand { get; set; }
        #endregion


        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Lembrete";
            ClickNavigationCommand = new DelegateCommand(ExecuteClickNavigationCommand);


        }

        private void ExecuteClickNavigationCommand()
        {
            _navigationService.NavigateAsync("PrimeiraPage");
        }
    }
}
