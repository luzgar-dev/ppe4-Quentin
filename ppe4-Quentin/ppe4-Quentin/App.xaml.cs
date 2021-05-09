using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE4_Damien
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PPE4Damien.Vues.AuthentificationVue();
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
