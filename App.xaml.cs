using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio01Layout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new StackLayoutDemo();
            //MainPage = new GridDemo();
            MainPage = new StacklayoutCode();
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
