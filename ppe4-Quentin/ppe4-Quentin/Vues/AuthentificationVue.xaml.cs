using PPE4_Damien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE4Damien.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthentificationVue : ContentPage
    {
        public AuthentificationVue()
        {
            InitializeComponent();
        }

        public void Valider_OnClicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();


        }
    }

}