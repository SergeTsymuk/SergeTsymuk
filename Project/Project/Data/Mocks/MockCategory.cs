using Project.Models;
using System.Collections.Generic;

namespace Project.Mocks
{
    public class MockCategory : ICarsCategory
    {
        IEnumerable<Category> ICarsCategory.AllCategories
        {
            get
            {
                List<Category> category = new List<Category>();

                category.Add(new Category() { CategoryName = "Electric Cars", Desc = "Modern Vehicles" });
                category.Add(new Category() { CategoryName = "Gasoline Cars", Desc = "Old Fashon Vehicles" });
                return category;
            }
        }
    }
}
