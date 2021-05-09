using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PPE4_Damien
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }
        public void NavigateButton_OnClicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new PPE4Damien.Vues.AuthentificationVue();
            
        }
    }
}

