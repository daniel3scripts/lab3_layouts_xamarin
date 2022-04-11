//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio01Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StacklayoutCode : ContentPage
    {
        public StacklayoutCode ()
        {
            InitializeComponent ();
            var layout = new StackLayout();
            var button = new Button
            {
                Text = "StackLayout - Qatar 2022 - Lugo",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var yellowBox = new BoxView
            {
                Color = Color.Yellow,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var greenBox = new BoxView
            {
                Color = Color.Green,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var blueBox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75
            };

            layout.Children.Add(button);
            layout.Children.Add(yellowBox);
            layout.Children.Add(greenBox);
            layout.Children.Add(blueBox);
            layout.Spacing = 30;
            Content = layout;
        }
    }
}