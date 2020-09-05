using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using UnoWithMVVM.Core.Services;

namespace UnoWithMVVM.Core.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        IGetNumberService _getNumberService;
        INavigationService _navigationService;

        public ICommand GoToDetailsCommand { get; }
        public ICommand OpenDialogCommand { get; }
        public ICommand SelectFileCommand { get; }
        public ICommand SelectObjectCommand { get; }

        public MainViewModel()
        {
            _getNumberService = Ioc.Default.GetService<IGetNumberService>();
            _navigationService = Ioc.Default.GetService<INavigationService>();
            GoToDetailsCommand = new RelayCommand(GoToDetails);
            OpenDialogCommand = new RelayCommand(OpenDialog);
            SelectFileCommand = new RelayCommand(SelectFile);
            SelectObjectCommand = new RelayCommand(SelectObject);
        }

        public int CurrentNumber
        {
            get { return _getNumberService.GetNumber(); }
        }

        private void SelectObject()
        {
            throw new NotImplementedException();
        }

        private void SelectFile()
        {
            throw new NotImplementedException();
        }

        private void OpenDialog()
        {
            throw new NotImplementedException();
        }

        private void GoToDetails()
        {
            _navigationService.Navigate(ApplicationView.DetailsView);
        }
    }
}
