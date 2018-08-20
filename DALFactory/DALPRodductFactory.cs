namespace DALFactory
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DALPRodductFactory
    {
        //public ProductInterface.IProduct GetDALProduct() => new DALJson.Product();
        //public ProductInterface.IProduct GetDALProduct() => new DALMSQL.Product();
      // public ProductInterface.IProduct GetDALProduct() => new DALExtra.Products();
        public ProductInterface.IProduct GetDALProduct() => new DAL.Product();


        public string GetIdentity(ProductInterface.IProduct product)
        {
            return product.GetType().FullName;
        }


    }

}
