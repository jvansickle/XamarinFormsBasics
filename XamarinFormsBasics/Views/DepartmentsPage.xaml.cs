using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsBasics.ViewModels;

namespace XamarinFormsBasics.Views
{
    public partial class DepartmentsPage : ContentPage
    {
        public DepartmentsPage()
        {
            InitializeComponent();
            BindingContext = new DepartmentsViewModel();
        }
    }
}
