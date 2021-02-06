using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    //NuGet = .NET ortamındaki kullanabileceğimiz paketleri barındıran yer.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); // @ işaretini \ için koyuyoruz.
        }

       public DbSet<Product> Products { get; set;} //Product nesnemizi veritabanındaki Products tablosuyla ilişkilendiriyoruz.       
    }
}
