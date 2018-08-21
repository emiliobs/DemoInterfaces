namespace DALFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DALReferenceProductFactory : BaseCreator
    {
        //CreateCreator
        public override ProductInterface.IProduct GetDALProduct() => new DALJson.Product();
      

       // public string GetIdentity(ProductInterface.IProduct product) => product.GetType().FullName;
    }
}
