using Project.Models;
using System.Collections.Generic;

namespace Project
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
