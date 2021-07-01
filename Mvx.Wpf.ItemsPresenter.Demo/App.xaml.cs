using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;

namespace Mvx.Wpf.ItemsPresenter.Demo
{
    public partial class App
    {
        protected override void RegisterSetup()
        {
            // usage 1 (basic).
            //this.RegisterSetupType<Mvx.Wpf.ItemsPresenter.MvxWpfSetup<Core.App>>();

            // usage 2 (advanced).
            this.RegisterSetupType<Mvx.Wpf.ItemsPresenter.Demo.MvxWpfSetup>();
        }
    }
}