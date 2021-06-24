using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MvvmCross.Platforms.Wpf.ItemsPresenter.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public HomeViewModel(IMvxNavigationService navigationService)
        {
            FirstCommand = new MvxCommand(() => navigationService.Navigate<FirstViewModel>());
            SecondCommand = new MvxCommand(() => navigationService.Navigate<SecondViewModel>());
            ThirdCommand = new MvxCommand(() => navigationService.Navigate<ThirdViewModel>());
            UserCommand = new MvxCommand<object>((i) => navigationService.Navigate(new UserViewModel(), (int)i));
        }

        public IMvxCommand FirstCommand { get; set; }
        public IMvxCommand SecondCommand { get; set; }
        public IMvxCommand ThirdCommand { get; set; }
        public IMvxCommand<object> UserCommand { get; set; }
    }
}