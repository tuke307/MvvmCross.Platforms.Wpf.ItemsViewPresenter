using Mvx.Wpf.ItemsPresenter;

namespace Mvx.Wpf.ItemsPresenter.Demo.Views
{
    [MvxWpfPresenter("users", mvxViewPosition.NewOrExsist)]
    public partial class UserView
    {
        public UserView()
        {
            InitializeComponent();
        }
    }
}