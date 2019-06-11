using System;

using Xamarin.Forms;

namespace XamarinFormsBasics.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello HomePage" }
                }
            };
        }
    }
}

