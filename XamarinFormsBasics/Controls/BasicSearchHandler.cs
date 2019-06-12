using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XamarinFormsBasics.Models;

namespace XamarinFormsBasics.Controls
{
    public class BasicSearchHandler : SearchHandler
    {
        public static readonly BindableProperty GroceriesProperty = BindableProperty.Create(
            nameof(Groceries),
            typeof(IList<GroceryItem>),
            typeof(BasicSearchHandler),
            new List<GroceryItem>());

        public IList<GroceryItem> Groceries { 
        get { return (IList<GroceryItem>)GetValue(GroceriesProperty); } 
        set { SetValue(GroceriesProperty, value); }
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            } else
            {
                ItemsSource = Groceries.Where((g) => g.Name.ToLower().Contains(newValue.ToLower()));
            }
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            // Do something with it
        }
    }
}
