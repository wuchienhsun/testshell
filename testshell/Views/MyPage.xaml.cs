using testshell.ViewModels;
using Xamarin.Forms;

namespace testshell.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }

        async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new LoanDetail());

        }
    }
}
