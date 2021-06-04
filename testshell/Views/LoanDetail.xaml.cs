using testshell.ViewModels;

using Xamarin.Forms;

namespace testshell.Views
{
    public partial class LoanDetail : ContentPage
    {
        public LoanDetail()
        {
            InitializeComponent();

            BindingContext = new LoanDeatilViewModel();
        }
    }
}
