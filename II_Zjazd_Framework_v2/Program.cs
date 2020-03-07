using II_Zjazd_Framework_v2.NorthwindModel;
using System;
using System.Linq;

namespace II_Zjazd_Framework_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();
            ctx.Database.EnsureCreated();
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4", IloscObecnych = 15, Sala = "B316" });
            ctx.SaveChanges();
            //foreach (var item in ctx.Zajecias)
            //{
            //    Console.WriteLine(item.Nazwa);
            //}
            using (var northwindContext = new NorthwindContext())
            {
                var ukClients = northwindContext.Customers.Where(x => x.Country == "UK");
                foreach (var item in ukClients)
                {
                    Console.WriteLine(item.CompanyName);
                    foreach (var item2 in item.Orders)
                    {
                        foreach (var itemDetails in item2.OrderDetails)
                        {
                            Console.WriteLine(itemDetails.Product.ProductName + itemDetails);
                        }
                    }
                }
            }
        }
    }
}
