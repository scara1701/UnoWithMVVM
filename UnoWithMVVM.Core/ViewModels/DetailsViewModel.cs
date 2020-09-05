using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using UnoWithMVVM.Core.Services;

namespace UnoWithMVVM.Core.ViewModels
{
    public class DetailsViewModel : ObservableObject
    {
        IGetNumberService _getNumberService;
        INavigationService _navigationService;
        public ICommand GoBackCommand { get; set; }
        public DetailsViewModel()
        {
            _navigationService = Ioc.Default.GetService<INavigationService>();
            _getNumberService = Ioc.Default.GetService<IGetNumberService>();
            GoBackCommand = new RelayCommand(GoBack);
        }

        public List<MyObject> TheList
        {
            get { return ListService.MyObjects(_getNumberService); }
        }

        private void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
