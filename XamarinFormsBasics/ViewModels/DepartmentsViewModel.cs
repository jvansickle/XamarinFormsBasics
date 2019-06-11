using System;
using System.Collections.ObjectModel;
using XamarinFormsBasics.Models;

namespace XamarinFormsBasics.ViewModels
{
    public class DepartmentsViewModel : BaseViewModel
    {
        public ObservableCollection<Department> Departments { get; set; }

        public DepartmentsViewModel()
        {
            Departments = new ObservableCollection<Department>
            {
                new Department{ Name = "Summer Grilling", Image="icon.png" },
                new Department{ Name = "Summer Activities", Image="icon" },
                new Department{ Name = "Fruits & Vegetables", Image="icon" },
                new Department{ Name = "Meat", Image="icon" },
                new Department{ Name = "Eggs & Dairy", Image="icon" },
                new Department{ Name = "Deli", Image="icon" },
                new Department{ Name = "Bread & Bakery", Image="icon" },
                new Department{ Name = "Pantry", Image="icon" },
                new Department{ Name = "Snacks & Candy", Image="icon" },
                new Department{ Name = "Beverages", Image="icon" },
            };
        }
    }
}
