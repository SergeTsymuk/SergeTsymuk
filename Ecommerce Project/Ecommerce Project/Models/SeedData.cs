using Ecommerce_Project.DataAccess;
using System;
using System.Linq;

namespace Ecommerce_Project.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (PagesContext db = new PagesContext())
            {

                if (db.Pages.Any())
                {
                    return;
                }
                //create pages
                db.Pages.AddRange(
                    new Page { Title = "Home", Slug = "main page", Content = "home page", Sorting = 0 },
                    new Page { Title = "About", Slug = "about us", Content = "about us page", Sorting = 100 },
                    new Page { Title = "Services", Slug = "services page", Content = "services page", Sorting = 100 },
                    new Page { Title = "Contact", Slug = "contact", Content = "contact page", Sorting = 100 }
                );
                db.SaveChanges();
            }
        }
    }
}
