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
                new GroceryItem{Name = "Pizza"},
                new GroceryItem{Name = "Bread"},
                new GroceryItem{Name = "Chips"},
                new GroceryItem{Name = "Trail Mix"},
                new GroceryItem{Name = "Milk"},
                new GroceryItem{Name = "Orange Juice"},
                new GroceryItem{Name = "Pancakes"},
            };
        }
    }
}
