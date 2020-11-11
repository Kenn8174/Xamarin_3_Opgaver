using System;
using System.Collections.Generic;
using Xamarin_3_Opgaver.ViewModels;
using Xamarin_3_Opgaver.Views;
using Xamarin.Forms;

namespace Xamarin_3_Opgaver
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
