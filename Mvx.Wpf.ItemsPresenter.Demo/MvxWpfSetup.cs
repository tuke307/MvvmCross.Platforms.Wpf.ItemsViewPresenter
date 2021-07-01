using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Mvx.Wpf.ItemsPresenter.Demo
{
    /// <summary>
    /// usage 2 (advanced).
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Core.MvxWpfSetup&lt;Mvx.Wpf.ItemsPresenter.Core.App&gt;" />
    public class MvxWpfSetup : MvvmCross.Platforms.Wpf.Core.MvxWpfSetup<Core.App>
    {
        protected override ILoggerFactory CreateLogFactory()
        {
            return null;
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return null;
        }

        /// <inheritdoc />
        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new Mvx.Wpf.ItemsPresenter.MvxWpfPresenter(root);
        }
    }
}