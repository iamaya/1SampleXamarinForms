using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    class FirstPage : ContentPage
    {
        public FirstPage()
        {
            BackgroundColor = Color.Red;

            var btn =  new Button
                    {
                    HorizontalOptions = LayoutOptions.Start, Text = "Submit", Font = Font.OfSize("Helvetica",25), 
                    BackgroundColor= Color.Red
                    };

            btn.Clicked +=   delegate 
            {
            DisplayAlert("Title","Message","OK",null);
            };

            Content = new StackLayout
                {
                    Padding = 20,
                    BackgroundColor = Color.Silver,
                    Orientation = StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.Center,

                    Children = {
                    new Label
                    {
                     Text = "Login", Font = Font.OfSize("Helvetica",30), HorizontalOptions = LayoutOptions.Start, TextColor = Color.Red
                    },

                    new Entry
                    {
                        HorizontalOptions=LayoutOptions.StartAndExpand, Placeholder="User Id", WidthRequest= 350
                    },

                    new Entry
                    {
                        HorizontalOptions=LayoutOptions.StartAndExpand, Placeholder="Password", WidthRequest= 350, IsPassword = true,
                        Keyboard = Keyboard.Numeric
                    },

                   btn
                    }
                };
        }
    }
}
