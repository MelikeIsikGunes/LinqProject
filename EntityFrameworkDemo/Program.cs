using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET = Veritabanına bağlanmamızı, veritabanını kontrol etmemizi, veritabanına sorgu yazmamızı sağlayan bir kütüphanedir.
            //Ado.net'le yazmak biraz yorucu. Günümüzde bu süreçleri kolaylaştırmak için ORM denilen yapıları kullanırız.
            //Entity Framework -- Bir ORM'dir. -Object Relational Mapping ---Nesnelerin Veritabanıyla Bağdaştırılması 
            //Bir alternatifi: NHibernate
            //Dapper: Ado.net'in kolaylaştırılmış versiyonudur.


            //GetAll();
            GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p=>p.CategoryId==categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
