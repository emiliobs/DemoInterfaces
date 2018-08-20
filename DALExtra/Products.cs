namespace DALExtra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     public class Products : ProductInterface.IProduct
    {
         public Entities.Product GetProductById(int ID)
        {
            return new Entities.Product()
            {
               ProductId  = ID,
               CategoryId = 99,
               ProductName = "Ferraries 507",
               UnitPrice =  1284,
               UnitInStock = 55,
            };                 
        }
    }
}
