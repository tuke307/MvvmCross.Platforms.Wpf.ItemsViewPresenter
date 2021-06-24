using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvx.Wpf.ItemsPresenter.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _Name = "Admin";

        private string _Password = "1234";

        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        public IMvxCommand OkCommand { get; private set; }

        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            OkCommand = new MvxCommand(() => navigationService.Navigate<HomeViewModel>());
        }
    }
}