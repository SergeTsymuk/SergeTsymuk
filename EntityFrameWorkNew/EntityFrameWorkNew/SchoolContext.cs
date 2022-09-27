using System.Data.Entity;

namespace EntityFrameWorkNew
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Data Source=DESKTOP-890Q20G;Initial Catalog=AdventureWorksLT2019;Integrated Security=True")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }
}
