using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lembrete.ViewModels
{
	public class PrimeiraPageViewModel : BindableBase
	{
        #region Global
        INavigationService _navigationService;

        #endregion

        #region Command
        public DelegateCommand AddClickNavigationCommand { get; set; }
        public DelegateCommand SecondClickNavigationCommand { get; set; }
        #endregion


        public PrimeiraPageViewModel(INavigationService navigationService)
        {
        
                _navigationService = navigationService;
                AddClickNavigationCommand = new DelegateCommand(ExecuteAddClickNavigationCommand);
            SecondClickNavigationCommand = new DelegateCommand(ExecuteSecondClickNavigationCommand);

        }

        private void ExecuteSecondClickNavigationCommand()
        {
            _navigationService.NavigateAsync("TerceiraPage");
        }

        private void ExecuteAddClickNavigationCommand()
            {
                _navigationService.NavigateAsync("SegundaPage");
            }
    }
}
	

