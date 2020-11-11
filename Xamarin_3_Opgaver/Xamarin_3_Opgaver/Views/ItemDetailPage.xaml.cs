using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_3_Opgaver.Models;
using Xamarin_3_Opgaver.ViewModels;

namespace Xamarin_3_Opgaver.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();            
        }
    }
}