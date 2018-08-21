namespace DALFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class BaseCreator
    {
        //creator
        public abstract ProductInterface.IProduct GetDALProduct();

        public string GetIdentity(ProductInterface.IProduct product) => product.GetType().FullName;
    }
}
