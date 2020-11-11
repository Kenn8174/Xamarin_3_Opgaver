using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_3_Opgaver.Services;
using Xamarin_3_Opgaver.Views;

namespace Xamarin_3_Opgaver
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var container = TinyIoCContainer.Current;
            container.Register<MockDataStore>();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
