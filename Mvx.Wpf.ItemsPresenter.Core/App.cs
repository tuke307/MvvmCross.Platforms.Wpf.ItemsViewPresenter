using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvx.Wpf.ItemsPresenter.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewModels.LoginViewModel>();
            base.Initialize();
        }
    }
}