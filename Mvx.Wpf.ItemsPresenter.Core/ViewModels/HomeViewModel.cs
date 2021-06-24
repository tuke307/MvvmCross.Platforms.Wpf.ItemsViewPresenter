using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvx.Wpf.ItemsPresenter.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public IMvxCommand FirstCommand { get; set; }

        public IMvxCommand SecondCommand { get; set; }

        public IMvxCommand ThirdCommand { get; set; }

        public IMvxCommand<object> UserCommand { get; set; }

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            FirstCommand = new MvxCommand(() => navigationService.Navigate<FirstViewModel>());
            SecondCommand = new MvxCommand(() => navigationService.Navigate<SecondViewModel>());
            ThirdCommand = new MvxCommand(() => navigationService.Navigate<ThirdViewModel>());
            UserCommand = new MvxCommand<object>((i) => navigationService.Navigate(new UserViewModel(), (int)i));
        }
    }
}