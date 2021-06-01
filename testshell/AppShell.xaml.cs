using testshell.Views;
using Xamarin.Forms;

namespace testshell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MyPage), typeof(MyPage));
        }

    }
}
