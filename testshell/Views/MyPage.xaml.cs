using System.Windows.Input;
using testshell.Models;
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

        //private async void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    var coffee = ((ListView)sender).SelectedItem as Coffee;
        //    if (coffee == null)
        //        return;

        //    await DisplayAlert("coffee selected", coffee.Name, "OK");
        //}       

        //void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    ((ListView)sender).SelectedItem = null;
        //}

        //async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        //{
        //    var coffee = ((MenuItem)sender).BindingContext as Coffee;
        //    if (coffee == null)
        //        return;

        //    await DisplayAlert("coffee Favorited", coffee.Name, "OK");
        //}
    }
}
