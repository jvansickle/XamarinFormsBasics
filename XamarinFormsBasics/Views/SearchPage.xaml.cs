using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsBasics.ViewModels;

namespace XamarinFormsBasics.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            BindingContext = new SearchPageViewModel();
        }
    }
}
