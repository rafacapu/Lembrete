using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Lembrete.Models;
using Prism.Navigation;
using static Android.Provider.ContactsContract.Contacts;

namespace Lembrete.ViewModels 
{
    public class SegundaPageViewModel : BindableBase
	{


        #region Global
        INavigationService _navigationService;

        #endregion

        #region Command
        public DelegateCommand AddSalvarClickNavigationCommand { get; set; }
        #endregion

        #region Binding
        private string Conteudo;
        public string conteudo
        {
            get { return Conteudo; }
            set { SetProperty(ref Conteudo, value); }
        }

        private string Data;
        public string data
        {
            get { return Data; }
            set { SetProperty(ref Data, value); }
        }
        #endregion

        public SegundaPageViewModel(INavigationService navigationService)
        
        {
            _navigationService = navigationService;
            AddSalvarClickNavigationCommand = new DelegateCommand(ExecuteAddSalvarClickNavigationCommand);
        }

        private void ExecuteAddSalvarClickNavigationCommand()
        {
            Lembretes p = new Lembretes();
                
        }
    }
}
