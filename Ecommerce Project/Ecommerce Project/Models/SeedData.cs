using Ecommerce_Project.DataAccess;
using System;

namespace Ecommerce_Project.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (PagesContext db = new PagesContext())
            {
                //create pages

                Page page1 = new Page { Title = "Home", Slug = "main page", Content = "home page", Sorting = 0 };
                Page page2 = new Page { Title = "About", Slug = "about us", Content = "about us page", Sorting = 100 };
                Page page3 = new Page { Title = "Services", Slug = "services page", Content = "services page", Sorting = 100 };
                Page page4 = new Page { Title = "Contact", Slug = "contact", Content = "contact page", Sorting = 100 };


                //add users to db
                db.Pages.Add(page1);
                db.Pages.Add(page2);
                db.Pages.Add(page3);
                db.Pages.Add(page4);
                db.SaveChanges();
            }
        }
    }
}
