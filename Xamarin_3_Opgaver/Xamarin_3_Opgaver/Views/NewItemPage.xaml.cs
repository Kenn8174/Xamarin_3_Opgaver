using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin_3_Opgaver.Models;
using Xamarin_3_Opgaver.ViewModels;

namespace Xamarin_3_Opgaver.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();

            MessagingCenter.Subscribe<NewItemViewModel>(this, "TestButtonClicked", (sender) =>
            {
                DisplayAlert("Item", "are you sure?", "OK");
            });
        }
    }
}