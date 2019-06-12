using System;
using System.Collections.ObjectModel;
using XamarinFormsBasics.Models;

namespace XamarinFormsBasics.ViewModels
{
    public class SearchPageViewModel : BaseViewModel
    {
        public ObservableCollection<GroceryItem> GroceryItems { get; set; }

        public SearchPageViewModel()
        {
            GroceryItems = new ObservableCollection<GroceryItem>
            {
                new GroceryItem{Name = "Mountain Dew"},
                new GroceryItem{Name = "Chicken Patties"},
                new GroceryItem{Name = "Pierogies"},
            };
        }
    }
}
