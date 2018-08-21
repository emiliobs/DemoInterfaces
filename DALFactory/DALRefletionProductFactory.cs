namespace DALFactory
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DALRefletionProductFactory:BaseCreator
    {
        //creator
        public override ProductInterface.IProduct GetDALProduct()
        {
            ProductInterface.IProduct product = null;
              //ruta del assemble desde el appConfig
            var assemblyPath = System.Configuration.ConfigurationManager.AppSettings["Product"];
            //aqui cargo el assemble en memoria
            var assemblyObject = System.Reflection.Assembly.LoadFrom(assemblyPath);
            var productType = assemblyObject.GetTypes().Where(T =>typeof(ProductInterface.IProduct)
                .IsAssignableFrom(T)).FirstOrDefault();

            if (productType != null)
            {
              product =  assemblyObject.CreateInstance(productType.FullName) as ProductInterface.IProduct;
            }


            return product;
        }

        //public ProductInterface.IProduct GetDALProduct() => new DALJson.Product();
       // public ProductInterface.IProduct GetDALProduct() => new DALMSQL.Product();
      // public ProductInterface.IProduct GetDALProduct() => new DALExtra.Products();
       // public ProductInterface.IProduct GetDALProduct() => new DAL.Product();

           


        //public string GetIdentity(ProductInterface.IProduct product)
        //{
        //    return product.GetType().FullName;
        //}


    }

}
