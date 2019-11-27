using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MrTshirtAppMVVM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _nextpageCommand;
        public DelegateCommand NextpageCommand =>
            _nextpageCommand ?? (_nextpageCommand = new DelegateCommand(ExecuteNextpageCommand));

        void ExecuteNextpageCommand()
        {
            NavigationService.NavigateAsync("TshirtPage");
        }
        
        
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
