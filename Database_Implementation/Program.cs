using Database_Implementation.Data;
using Database_Implementation.Models;


namespace Database_Implementation
{
    public class Program 
    {
        static void Main(string[] args)
        {

            using (var db = new OrderContext())
            {
                Order o = new Order();
                o.Total_Price = 3800;
                o.Date = new DateTime( 2001, 01, 10);

                o.Clerk = new Clerk() { Name = "Martin Lawrence" };
                o.Customer = new Customer() { CustomerNumber = 1001, Name = "ABC Company", Adress = "100 Points, Manhattan, KS 66502"};
                
                o.Products.Add(new Product() { Description = "widgit small", Quantity = 40, Unit_Price = 60 });
                o.Products.Add(new Product() { Description = "thingimajigger", Quantity = 20, Unit_Price = 20 });
                o.Products.Add(new Product() { Description = "thingibob", Quantity = 100, Unit_Price = 1000 });
              
                

                db.Orders.Add(o);

                db.SaveChanges();
            }
        }

       
    }

    
}