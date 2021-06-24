using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Presenters;
using MvvmCross.ViewModels;

namespace MvvmCross.Platforms.Wpf.ItemsPresenter
{
    public class MvxWpfSetup<TApplication> : MvvmCross.Platforms.Wpf.Core.MvxWpfSetup<TApplication>
        where TApplication : class, IMvxApplication, new()
    {
        protected override ILoggerFactory CreateLogFactory()
        {
            throw new NotImplementedException();
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            throw new NotImplementedException();
        }

        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new MvxWpfPresenter(root);
        }
    }
}