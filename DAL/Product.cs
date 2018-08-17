namespace DAL
{
    using System.Collections.Generic;
    using System.Linq;

    public class Product
    {

        public Entities.Product GetProductById(int id)
        {
            return Products.Where(p=>p.ProductId.Equals(id)).FirstOrDefault();
        }

        List<Entities.Product> Products = new List<Entities.Product>()
        {
           new Entities.Product
           {
              ProductId = 1,
              ProductName = "Azucar",
              UnitPrice = 12,
              UnitInStock = 100,
              CategoryId = 1,

           },
           new Entities.Product
           {
              ProductId = 2,
              ProductName = "Panela",
              UnitPrice = 15,
              UnitInStock = 300,
              CategoryId = 2,

           },
           new Entities.Product
           {
              ProductId = 3,
              ProductName = "Aceite",
              UnitPrice = 78,
              UnitInStock = 150,
              CategoryId = 3,

           },

        };

    }


}
