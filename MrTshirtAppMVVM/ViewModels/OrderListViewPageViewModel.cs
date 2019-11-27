using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MrTshirtAppMVVM.ViewModels
{
    public class OrderListViewPageViewModel : BindableBase
    {
        private DelegateCommand _confirmOrder;
        public DelegateCommand ConfirmOrder =>
            _confirmOrder ?? (_confirmOrder = new DelegateCommand(ExecuteConfirmOrder));

        void ExecuteConfirmOrder()
        {

        }
        private DelegateCommand _tRACKPackage;
        public DelegateCommand TRACKPackage =>
            _tRACKPackage ?? (_tRACKPackage = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {

        }
        
        public OrderListViewPageViewModel()
        {

        }
    }
}
